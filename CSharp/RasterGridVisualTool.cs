using System;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.ImageFiles;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.UI.VisualTools;

using DemosCommonCode;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging;

namespace RasterGridImageEditorDemo
{
    /// <summary>
    /// Visual tool which draws the raster grid for image in image viewer and
    /// allows to change any rectangle of image without reencoding of whole image.
    /// </summary>
    public class RasterGridVisualTool : VisualTool
    {

        #region Fields

        ContextMenuStrip _contextMenu;
        OpenFileDialog _openFileDialog;
        Cursor _currentCursor;

        #endregion



        #region Constructors

        public RasterGridVisualTool()
            : base()
        {
            _contextMenu = new ContextMenuStrip();
            _contextMenu.Items.Add(new ToolStripMenuItem("Change cell image", null, ChangeImageRect_Click));

            _openFileDialog = new OpenFileDialog();
            CodecsFileFilters.SetOpenFileDialogFilter(_openFileDialog);
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the name of visual tool.
        /// </summary>
        public override string Name
        {
            get { return "Raster grid visual tool"; }
        }

        /// <summary>
        /// Gets the rectangle grid for image in image viewer.
        /// </summary>
        public Rectangle[] ImageRectGrid
        {
            get
            {
                // get reference to the source image
                VintasoftImage image = this.ImageViewer.Image;
                // if image viewer contains image
                if (image != null)
                {
                    // get the raster grid editor for image
                    IRasterGridEditor rasterGridEditor = image.SourceInfo.Decoder.GetRasterGridEditor();
                    // if image has the raster grid editor
                    if (rasterGridEditor != null)
                    {
                        // get the rectangle grid for image
                        return rasterGridEditor.GetRasterEditorGrid(image.SourceInfo.PageIndex);
                    }
                }

                return null;
            }
        }

        int _selectedRectIndex;
        public int SelectedImageRectIndex
        {
            get { return _selectedRectIndex; }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Paints a content of this tool.
        /// </summary>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (!this.Enabled)
                return;

            // if image has the rectangle grid
            if (ImageRectGrid != null)
            {
                // get image location in viewer
                PointF imageLocationInViewer = this.ImageViewer.ViewerState.ImageLocationInViewer;
                // get image scale in viewer
                Scale imageScale = this.ImageViewer.ViewerState.ScaleToImage;

                // create a pen
                using (Pen pen = new Pen(Color.FromArgb(0x80, 0xFF, 0, 0)))
                {
                    RectangleF firstRectOnViewer = ImageViewer.RectangleToControl(ImageRectGrid[0]);
                    if (firstRectOnViewer.Width > 2 && firstRectOnViewer.Height > 2)
                    {
                        // for each rectangle in grid
                        for (int i = 0; i < ImageRectGrid.Length; i++)
                        {
                            if (i != _selectedRectIndex)
                            {
                                // converts image rectangle to viewer rectangle
                                RectangleF rect = ImageViewer.RectangleToControl(ImageRectGrid[i]);
                                // draw rectangle
                                e.Graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
                            }
                        }
                    }

                    // if rect selected
                    if (_selectedRectIndex >= 0)
                    {
                        pen.Color = Color.FromArgb(0xA0, 0, 0xFF, 0);
                        pen.Width = 2;
                        // converts image rectangle to viewer rectangle
                        RectangleF rect = ImageViewer.RectangleToControl(ImageRectGrid[_selectedRectIndex]);
                        // draw selected rectangle
                        e.Graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
                    }
                }
            }
        }

        protected override void Reset()
        {
            base.Reset();

            _selectedRectIndex = -1;

            ImageViewer.ImagePainted += new EventHandler<ImageLoadedEventArgs>(ImageViewer_ImagePainted);
        }

        /// <summary>
        /// Mouse is moved.
        /// </summary>
        protected override void OnMouseMove(VisualToolMouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (!this.Enabled)
                return;

            int previousRectIndex = _selectedRectIndex;

            // get an index of rectangle on the source image
            _selectedRectIndex = GetRectIndex(e.Location);

            if (previousRectIndex != _selectedRectIndex)
            {
                // calculate invalidate rect
                int index1 = previousRectIndex;
                if (previousRectIndex < 0)
                    index1 = _selectedRectIndex;
                int index2 = _selectedRectIndex;
                if (_selectedRectIndex < 0)
                    index2 = previousRectIndex;
                Rectangle[] grid = ImageRectGrid;
                if (grid != null)
                {
                    RectangleF rect1 = ImageViewer.RectangleToControl(grid[index1]);
                    RectangleF rect2 = ImageViewer.RectangleToControl(grid[index2]);
                    rect1.Inflate(2, 2);
                    rect2.Inflate(2, 2);
                    // invalidate viewer
                    InvalidateViewer(RectangleF.Union(rect1, rect2));
                }

                if (CurrentImageRectIndexChanged != null)
                    CurrentImageRectIndexChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Mouse button is down.
        /// </summary>
        protected override void OnMouseDown(VisualToolMouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!this.Enabled)
                return;

            // if right mouse button is down
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                // if mouse is over the image
                if (_selectedRectIndex >= 0)
                    // show context menu
                    _contextMenu.Show(this.ImageViewer, e.Location);
            }
        }


        /// <summary>
        /// "Change cell image" context menu is selected.
        /// </summary>
        private void ChangeImageRect_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ImageCollection imageCollection = new ImageCollection())
                {
                    // add opening file in image collection
                    imageCollection.Add(_openFileDialog.FileName);

                    int selectedImageIndex = 0;
                    // if image collection have more than one image
                    if (imageCollection.Count > 1)
                    {
                        // create form that allows to select image in image collection
                        using (SelectImageForm selectImageForm = new SelectImageForm(imageCollection))
                        {
                            if (selectImageForm.ShowDialog() != DialogResult.OK)
                            {
                                return;
                            }

                            // set selected image index
                            selectedImageIndex = selectImageForm.SelectedImageIndex;
                        }
                    }

                    _currentCursor = ImageViewer.Cursor;
                    ImageViewer.Cursor = Cursors.WaitCursor;
                    EnableViewerInvalidate = false;
                    try
                    {
                        // create an image for rectangle of source image
                        using (VintasoftImage rectImage = CreateRectImage(imageCollection[selectedImageIndex]))
                        {
                            // get reference to the source image
                            VintasoftImage image = this.ImageViewer.Image;
                            // get image index in the source
                            int pageIndex = image.SourceInfo.PageIndex;
                            // get the raster grid editor for image
                            IRasterGridEditor rasterGridEditor = image.SourceInfo.Decoder.GetRasterGridEditor();
                            // sets an image rectangle
                            rasterGridEditor.SetImageRect(pageIndex, _selectedRectIndex, rectImage, null);
                            // reload the source image
                            Rectangle[] rectGrid = rasterGridEditor.GetRasterEditorGrid(pageIndex);
                            image.Reload(rectGrid[_selectedRectIndex]);

                            // raise event after image is edited
                            if (ImageEdited != null)
                                ImageEdited(this, EventArgs.Empty);
                        }
                    }
                    catch (Exception ex)
                    {
                        EnableViewerInvalidate = true;
                        ImageViewer.Cursor = _currentCursor;
                        DemosTools.ShowErrorMessage(ex);
                    }
                }
            }
        }

        /// <summary>
        /// Image in viewer is painted.
        /// </summary>
        private void ImageViewer_ImagePainted(object sender, ImageLoadedEventArgs e)
        {
            if (!EnableViewerInvalidate)
            {
                EnableViewerInvalidate = true;
                ImageViewer.Cursor = _currentCursor;
            }
        }

        /// <summary>
        /// Returns an index of rectangle on the source image.
        /// </summary>
        private int GetRectIndex(Point mouseLocation)
        {
            // if image has the rectangle grid
            if (ImageRectGrid != null)
            {
                // convert mouse location from the screen coordinates to the image coordinates
                Point pointOnImage = ImageViewer.PointToImage(mouseLocation);

                // for each rectangle in the rectangle grid
                for (int i = 0; i < ImageRectGrid.Length; i++)
                {
                    // if mouse location contains in rectangle
                    if (ImageRectGrid[i].Contains(pointOnImage))
                        // return the rectangle index
                        return i;
                }
            }

            // mouse is not over the image
            return -1;
        }

        /// <summary>
        /// Creates an image for rectangle of source image.
        /// </summary>
        private VintasoftImage CreateRectImage(VintasoftImage image)
        {
            // get reference to the source image
            VintasoftImage sourceImage = this.ImageViewer.Image;
            // get rectangle of source image
            Rectangle rect = this.ImageRectGrid[_selectedRectIndex];
            // load image for rectangle of source image
            VintasoftImage rectImage = image;

            // if rectangle size and rectangle image size are different
            if (rect.Width != rectImage.Width || rect.Height != rectImage.Height)
            {
                // resize rectangle image
                ResizeCommand resizeCommand = new ResizeCommand(rect.Width, rect.Height);
                resizeCommand.ExecuteInPlace(rectImage);
            }

            // if pixel format of source image and rectangle image are different
            if (sourceImage.PixelFormat != rectImage.PixelFormat)
            {
                if (sourceImage.PixelFormat == PixelFormat.Indexed1 ||
                    sourceImage.PixelFormat == PixelFormat.Indexed4 ||
                    sourceImage.PixelFormat == PixelFormat.Indexed8)
                {
                    ChangePixelFormatToPaletteCommand changePixelFormatToPaletteCommand = new ChangePixelFormatToPaletteCommand(sourceImage.PixelFormat, sourceImage.Palette);
                    changePixelFormatToPaletteCommand.ExecuteInPlace(rectImage);
                }
                else
                {
                    // change pixel format of rectangle image
                    ChangePixelFormatCommand changePixelFormatCommand = new ChangePixelFormatCommand(sourceImage.PixelFormat);
                    changePixelFormatCommand.ExecuteInPlace(rectImage);
                }
            }

            // if palette of source image and rectangle image are different
            if (!sourceImage.Palette.Equals(rectImage.Palette))
            {
                if (sourceImage.PixelFormat == PixelFormat.BlackWhite)
                {
                    rectImage.Invert();
                }
                else
                {
                    ChangePixelFormatToPaletteCommand changePixelFormatToPaletteCommand = new ChangePixelFormatToPaletteCommand(sourceImage.PixelFormat, sourceImage.Palette);
                    changePixelFormatToPaletteCommand.ExecuteInPlace(rectImage);
                }
            }

            // return rectangle image
            return rectImage;
        }

        #endregion



        #region Events

        public event EventHandler ImageEdited;

        public event EventHandler CurrentImageRectIndexChanged;

        #endregion

    }
}