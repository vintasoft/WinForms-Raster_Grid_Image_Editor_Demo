using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.ImageFiles;
using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.UI;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging.Codecs.Dialogs;

namespace RasterGridImageEditorDemo
{
    /// <summary>
    /// The main form of Raster Grid Image Editor Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Template of the application's title.
        /// </summary>
        string _titlePrefix = string.Format("VintaSoft Raster Grid Image Editor Demo v{0}", ImagingGlobalSettings.ProductVersion);

        /// <summary>
        /// Current image filename.
        /// </summary>
        string _imageFilename;

        /// <summary>
        /// Current image stream.
        /// </summary>
        Stream _imageStream;

        /// <summary>
        /// Filters for image saving dialog.
        /// </summary>
        static string _defaultEncodingFilter = "TIFF files|*.tif*;*.btf";

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            Jpeg2000AssemblyLoader.Load();

            // create visual tool for image editing
            RasterGridVisualTool rasterGridVisualTool = new RasterGridVisualTool();
            rasterGridVisualTool.ImageEdited += new EventHandler(rasterGridVisualTool_ImageEdited);
            rasterGridVisualTool.CurrentImageRectIndexChanged += new EventHandler(rasterGridVisualTool_CurrentImageRectIndexChanged);
            imageViewer1.VisualTool = rasterGridVisualTool;

            // set default folders for images
            DemosTools.SetTestFilesFolder(openImageFileDialog);
            // set filter for open dialog
            CodecsFileFilters.SetOpenFileDialogFilter(openImageFileDialog);

#if !REMOVE_JPEG2000_PLUGIN
            _defaultEncodingFilter += "|JPEG2000 files|*.jp2;*j2k;*jpc;*.j2c";
#endif

            // update UI
            UpdateUI();
            UpdateApplicationTitle();
        }

        #endregion



        #region Properties

        bool _isImageFileOpening = false;
        /// <summary>
        /// Gets or sets a value indicating whether image file is opening.
        /// </summary>
        bool IsImageFileOpening
        {
            get
            {
                return _isImageFileOpening;
            }
            set
            {
                _isImageFileOpening = value;
                UpdateUI();
            }
        }

        bool _isImageFileLocked = false;
        /// <summary>
        /// Gets or sets a value indicating whether image file is locked.
        /// </summary>
        bool IsImageFileLocked
        {
            get
            {
                return _isImageFileLocked;
            }
            set
            {
                if (value)
                    Cursor = Cursors.WaitCursor;
                else
                    Cursor = Cursors.Default;

                _isImageFileLocked = value;
                UpdateUI();
            }
        }

        bool _isImageModified;
        /// <summary>
        /// Gets or sets a value indicating whether image is modified.
        /// </summary>
        bool IsImageModified
        {
            get { return _isImageModified; }
            set
            {
                _isImageModified = value;

                UpdateUI();
            }
        }

        #endregion



        #region Methods

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of createToolStripMenuItem object.
        /// </summary>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateNewImageForm dlg = new CreateNewImageForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    saveImageFileDialog.Filter = _defaultEncodingFilter;
                    if (saveImageFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // close currently opened image stream
                        CloseImageStream();

                        // create a new image
                        using (VintasoftImage image = dlg.CreateImage())
                        {
                            // create encoder for new image

                            EncoderBase encoder = null;
#if !REMOVE_JPEG2000_PLUGIN
                            if (saveImageFileDialog.FileName.ToUpperInvariant().EndsWith(".JP2"))
                            {
                                Jpeg2000Encoder jpeg2000Encoder = new Jpeg2000Encoder();

                                using (Jpeg2000EncoderSettingsForm jpeg2000EncoderSettingsForm = new Jpeg2000EncoderSettingsForm())
                                {
                                    jpeg2000EncoderSettingsForm.EncoderSettings = jpeg2000Encoder.Settings;
                                    jpeg2000EncoderSettingsForm.ShowDialog();
                                }

                                encoder = jpeg2000Encoder;
                            }
#endif
                            if (encoder == null)
                            {
                                TiffEncoder tiffEncoder = new TiffEncoder();
                                tiffEncoder.Settings.RowsPerStrip = 256;
                                tiffEncoder.Settings.TileSize = new Size(256, 256);

                                using (TiffEncoderSettingsForm tiffEncoderSettingsForm = new TiffEncoderSettingsForm())
                                {
                                    tiffEncoderSettingsForm.EncoderSettings = tiffEncoder.Settings;
                                    tiffEncoderSettingsForm.ShowDialog();
                                }

                                encoder = tiffEncoder;
                            }

                            // open file stream
                            using (FileStream stream = new FileStream(saveImageFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                            {
                                // save new image to the file stream
                                encoder.SaveImage(image, stream, ImagesEncodingProgress);
                            }

                            try
                            {
                                // open image from file
                                OpenFile(saveImageFileDialog.FileName);
                            }
                            catch (Exception ex)
                            {
                                DemosTools.ShowErrorMessage(ex);
                            }
                        }
                    }
                    else
                        DemosTools.ShowErrorMessage("Image is not saved.");
                }
            }
        }

        /// <summary>
        /// Handles the Click event of openToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IsImageFileOpening = true;

            if (openImageFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    // open existing image file
                    OpenFile(openImageFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }

            IsImageFileOpening = false;
        }


        /// <summary>
        /// Handles the Click event of saveChangesToolStripMenuItem object.
        /// </summary>
        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IRasterGridEditor rasterGridEditor = imageViewer1.Image.SourceInfo.Decoder.GetRasterGridEditor();
            if (rasterGridEditor != null)
            {
                // save changes in opened image file
                rasterGridEditor.SaveChanges(ImagesEncodingProgress);

                IsImageModified = false;
            }
        }

        /// <summary>
        /// Handles the Click event of saveToolStripMenuItem object.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImageFileDialog.Filter = string.Format("{0} files|*{0}", Path.GetExtension(_imageFilename));
            if (saveImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                IRasterGridEditor rasterGridEditor = imageViewer1.Image.SourceInfo.Decoder.GetRasterGridEditor();
                if (rasterGridEditor != null)
                {
                    try
                    {
                        if (File.Exists(saveImageFileDialog.FileName))
                            File.Delete(saveImageFileDialog.FileName);

                        using (FileStream stream = new FileStream(saveImageFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        {
                            // save opened image file to a new image file
                            rasterGridEditor.Save(stream, ImagesEncodingProgress);

                            IsImageModified = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        DemosTools.ShowErrorMessage(ex);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of closeToolStripMenuItem object.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close opened image stream
            CloseImageStream();

            // update the application's title after image file is loaded
            UpdateApplicationTitle();

            // update UI
            UpdateUI();
        }


        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // close the opened image stream
            CloseImageStream();
            // close application's form
            Close();
        }

        #endregion


        #region 'Edit' menu

        /// <summary>
        /// Handles the Click event of undoAllChangesToolStripMenuItem object.
        /// </summary>
        private void undoAllChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save the image filename
            string filename = _imageFilename;
            // close the currently opened image stream
            CloseImageStream();
            // reopen the image stream
            OpenImageStream(filename);

            // if image stream is loaded successfully
            if (_imageStream != null)
            {
                // load images from image stream in image viewer
                imageViewer1.Images.Add(_imageStream);
            }
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of imageViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void imageViewerSettingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // create and show a dialog that allows to change image viewer settings
            ImageViewerSettingsForm viewerSettingsDialog = new ImageViewerSettingsForm(imageViewer1);
            viewerSettingsDialog.CanEditMultipageSettings = false;
            viewerSettingsDialog.ShowDialog();
            UpdateImageRendererInfo();
        }

        #endregion


        #region 'About' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        #region Image Viewer

        /// <summary>
        /// Image loading is in progress.
        /// </summary>
        private void imageViewer1_ImageLoadingProgress(object sender, ProgressEventArgs e)
        {
            imageLoadingProgressBarLabel.Visible = e.Progress != 100;
            imageLoadingProgressBar.Visible = e.Progress != 100;
            imageLoadingProgressBar.Value = e.Progress;
            UpdateImageRendererInfo();
        }

        /// <summary>
        /// Image is loaded in image viewer.
        /// </summary>
        private void imageViewer1_ImageLoaded(object sender, ImageLoadedEventArgs e)
        {
            VintasoftImage image = imageViewer1.Image;
            if (image != null)
            {
                labelImageInfo.Text = string.Format("Size={0}x{1}; Resolution={2}; BitsPerPixel={3}",
                    image.Width, image.Height, image.Resolution, image.BitsPerPixel);
            }
        }

        /// <summary>
        /// Handles the FocusedIndexChanged event of imageViewer1 object.
        /// </summary>
        private void imageViewer1_FocusedIndexChanged(object sender, FocusedIndexChangedEventArgs e)
        {
            UpdateImageInfo();
            UpdateImageRendererInfo();
            UpdateRasterGridVisualToolInfo();
        }

        #endregion


        /// <summary>
        /// Handles the CheckedChanged event of enableRasterGridVisualToolCheckBox object.
        /// </summary>
        private void enableRasterGridVisualToolCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // disable/enable visual tool for image editing
            if (imageViewer1.VisualTool != null)
                imageViewer1.VisualTool.Enabled = enableRasterGridVisualToolCheckBox.Checked;
        }

        #endregion


        #region UI state

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            // get the current status of application
            bool isImageFileOpening = IsImageFileOpening;
            bool isImageFileLoaded = _imageStream != null;
            bool isImageFileEmpty = true;
            if (isImageFileLoaded)
                isImageFileEmpty = imageViewer1.Images.Count == 0;
            bool isImageFileLocked = IsImageFileLocked;

            // "File" menu
            saveChangesToolStripMenuItem.Enabled = !isImageFileEmpty && _isImageModified;
            saveToolStripMenuItem.Enabled = !isImageFileEmpty;

            // "Edit" menu
            undoAllChangesToolStripMenuItem.Enabled = _isImageModified;

            // Toolstip
            imageViewerToolstrip1.CanSaveFile = saveToolStripMenuItem.Enabled;

            imageInfoGroupBox.Enabled = !isImageFileEmpty;
            imageRendererInfoGroupBox.Enabled = !isImageFileEmpty;
        }

        /// <summary>
        /// Updates the application's title after image file is created/loaded/saved/closed.
        /// </summary>
        private void UpdateApplicationTitle()
        {
            if (_imageStream != null)
                this.Text = string.Format("{0} - {1}", _titlePrefix, _imageFilename);
            else
                this.Text = _titlePrefix;
        }

        /// <summary>
        /// Updates information about image.
        /// </summary>
        private void UpdateImageInfo()
        {
            string imageWidth = string.Empty, imageHeight = string.Empty, imageSize = string.Empty;
            string imagePixelFormat = string.Empty, imageResolution = string.Empty, imageDecoder = string.Empty;

            VintasoftImage image = imageViewer1.Image;
            if (image != null)
            {
                imageWidth = image.Width.ToString();
                imageHeight = image.Height.ToString();

                // image size (megapixels or gigapixels)
                float mpx = (float)image.Width * image.Height / (1000f * 1000f);
                if (mpx < 0.01)
                    imageSize = (image.Width * image.Height).ToString() + " Px";
                else if (mpx < 10)
                    imageSize = mpx.ToString("F2", CultureInfo.InvariantCulture) + " MPx";
                else if (mpx < 1000)
                    imageSize = mpx.ToString("F1", CultureInfo.InvariantCulture) + " MPx";
                else
                    imageSize = (mpx / 1000f).ToString("F2", CultureInfo.InvariantCulture) + " GPx";

                imagePixelFormat = image.PixelFormat.ToString();
                imageResolution = image.Resolution.ToString();
                imageDecoder = image.SourceInfo.DecoderName;
            }

            widthValueLabel.Text = imageWidth;
            heightValueLabel.Text = imageHeight;
            sizeValueLabel.Text = imageSize;
            pixelFormatValueLabel.Text = imagePixelFormat;
            resolutionValueLabel.Text = imageResolution;
            decoderValueLabel.Text = imageDecoder;
        }

        /// <summary>
        /// Updates information about visual tool for image editing.
        /// </summary>
        private void UpdateRasterGridVisualToolInfo()
        {
            RasterGridVisualTool rasterGridVisualTool = (RasterGridVisualTool)imageViewer1.VisualTool;
            Rectangle[] imageRectGrid = rasterGridVisualTool.ImageRectGrid;

            string gridEditorAvailable = "Yes", cellCount = string.Empty;
            string cellWidth = string.Empty, cellHeight = string.Empty;
            if (imageRectGrid == null)
            {
                gridEditorAvailable = "No";

                if (imageViewer1.FocusedIndex != -1)
                {
                    MessageBox.Show("Image does not have raster grid and cannot be edited by this demo.");
                }
            }
            else
            {
                cellCount = imageRectGrid.Length.ToString();
                cellWidth = imageRectGrid[0].Width.ToString();
                cellHeight = imageRectGrid[0].Height.ToString();
            }

            gridEditorAvailableValueLabel.Text = gridEditorAvailable;
            cellCountValueLabel.Text = cellCount;
            cellWidthValueLabel.Text = cellWidth;
            cellHeightValueLabel.Text = cellHeight;

            gridEditorInstructionsTextBox.Visible = imageRectGrid != null;
            rasterGridVisualToolInfoGroupBox.Enabled = imageRectGrid != null;
        }

        /// <summary>
        /// Updates information about image renderer of image viewer.
        /// </summary>
        private void UpdateImageRendererInfo()
        {
            cacheSizeValueLabel.Text = string.Format("{0} Mb", imageViewer1.RendererCacheSize);
            usedCacheSizeValueLabel.Text = string.Format("{0:f1} Mb", imageViewer1.RendererCacheDataSize);
        }

        #endregion


        /// <summary>
        /// Opens an image file.
        /// </summary>
        private void OpenFile(string filename)
        {
            // close opened image stream
            CloseImageStream();

            // open image stream
            OpenImageStream(filename);

            // if the image stream is loaded successfully
            if (_imageStream != null)
            {
                // load images from image stream in image viewer
                imageViewer1.Images.Add(_imageStream);
            }

            // update application's title after image file is loaded
            UpdateApplicationTitle();

            UpdateUI();
        }

        /// <summary>
        /// Opens an image stream.
        /// </summary>
        private void OpenImageStream(string filename)
        {
            try
            {
                // save information about image filename
                _imageFilename = filename;

                // open image stream
                _imageStream = new FileStream(_imageFilename, FileMode.Open, FileAccess.ReadWrite);
            }
            catch (Exception ex)
            {
                // show error message
                DemosTools.ShowErrorMessage("File load error", ex);
            }
        }

        /// <summary>
        /// Closes the opened image stream.
        /// </summary>
        private void CloseImageStream()
        {
            // if the image stream is opened
            if (_imageStream != null)
            {
                // clear and dispose images loaded in image viewer
                imageViewer1.Images.ClearAndDisposeItems();

                // close image stream
                _imageStream.Close();
                _imageStream.Dispose();
                _imageStream = null;

                // clear information about image filename
                _imageFilename = null;

                // update application's title after image file is closed
                UpdateApplicationTitle();

                labelImageInfo.Text = "";
            }
        }

        /// <summary>
        /// Image encoding is in progress.
        /// </summary>
        private void ImagesEncodingProgress(object sender, ProgressEventArgs e)
        {
            imagesEncodingProgressBarLabel.Visible = e.Progress != 100;
            imagesEncodingProgressBar.Visible = e.Progress != 100;
            imagesEncodingProgressBar.Value = e.Progress;

            Application.DoEvents();
        }

        /// <summary>
        /// Handler of the RasterGridVisualTool.ImageEdited event.
        /// </summary>
        private void rasterGridVisualTool_ImageEdited(object sender, EventArgs e)
        {
            IsImageModified = true;
        }

        /// <summary>
        /// Handler of the RasterGridVisualTool.CurrentImageRectIndexChanged event.
        /// </summary>
        private void rasterGridVisualTool_CurrentImageRectIndexChanged(object sender, EventArgs e)
        {
            RasterGridVisualTool rasterGridVisualTool = (RasterGridVisualTool)sender;
            cellIndexValueLabel.Text = rasterGridVisualTool.SelectedImageRectIndex.ToString();
        }

        #endregion

    }
}
