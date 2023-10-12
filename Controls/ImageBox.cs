using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BeebSpriter.Controls
{
    public partial class ImageBox : ScrollableControl
    {
        private bool IsSelected;
        private Point SelectionStart;
        private Point SelectionEnd;
        private Size PixelGridSize;

        public int ZoomFactor { get; set; }
        public Bitmap Image { get; set; }
        public Bitmap OriginalImage { get; set; }
        public Size ImageSize { get; set; }
        public Rectangle ImageRect { get; private set; }
        public Pen PixelPenGrid { get; set; }
        public Pen SpritePenGrid { get; set; }
        public bool ShowGrid { get; set; }

        public readonly List<Rectangle> SpriteList;

        /// <summary>
        ///
        /// </summary>
        public ImageBox()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            PixelGridSize = new Size(1, 1);

            PixelPenGrid = new Pen(SystemColors.ControlDarkDark)
            {
                Width = 1f,
                DashStyle = DashStyle.Dash
            };

            SpritePenGrid = new Pen(Color.Aquamarine)
            {
                Width = 1f,
                DashStyle = DashStyle.Dash
            };

            SpriteList = new List<Rectangle>();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {
            Image = (Bitmap)System.Drawing.Image.FromFile(fileName);

            OriginalImage = (Bitmap)Image.Clone();

            ImageSize = new Size(Image.Width, Image.Height);

            Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        public new void Invalidate()
        {
            if (Image != null)
            {
                int width = ImageSize.Width * ZoomFactor;
                int height = ImageSize.Height * ZoomFactor;

                AutoScrollMinSize = new Size(width, height);

                ImageRect = new Rectangle(0, 0, width, height);
            }

            base.Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsSelected = true;
                SelectionStart = ConvertMouseCoords(e.Location);
                SelectionEnd = ConvertMouseCoords(e.Location);
                Invalidate();
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (IsSelected)
            {
                Point point = ConvertMouseCoords(e.Location);

                if (point != SelectionStart)
                {
                    SelectionEnd = point;
                    Invalidate();
                }
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (IsSelected)
            {
                if (SelectionStart != SelectionEnd)
                {
                    Rectangle rect = ValidateRect();
                    SpriteList.Add(rect);
                }
            }

            IsSelected = false;

            base.OnMouseUp(e);
        }

        /// <summary>
        ///
        /// </summary>
        private Rectangle ValidateRect()
        {
            Point topLeft = new(Math.Min(SelectionStart.X, SelectionEnd.X), Math.Min(SelectionStart.Y, SelectionEnd.Y));

            Point bottomRight = new(Math.Max(SelectionStart.X, SelectionEnd.X) + 1, Math.Max(SelectionStart.Y, SelectionEnd.Y) + 1);

            Size size = new(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);

            Rectangle rect = new(topLeft, size);

            return rect;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public Point ConvertMouseCoords(Point point)
        {
            Point newPoint = Point.Subtract(point, (Size)AutoScrollPosition);
            newPoint.X /= ZoomFactor;
            newPoint.Y /= ZoomFactor;

            return newPoint;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

            e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

            if (Image != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.CompositingMode = CompositingMode.SourceCopy;
                e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

                e.Graphics.DrawImage(Image, ImageRect);
            }

            if (ShowGrid)
            {
                PaintGrid(e.Graphics, ImageRect, PixelGridSize, PixelPenGrid);
            }

            PaintSprites(e.Graphics, SpritePenGrid);
            PaintSelector(e.Graphics, SpritePenGrid);

            base.OnPaint(e);
        }

        /// <summary>
        /// Paint selected sprites
        /// </summary>
        /// <param name="gfx"></param>
        private void PaintSprites(Graphics gfx, Pen pen)
        {
            foreach (Rectangle rect in SpriteList)
            {
                Rectangle zoomRect = new(rect.X * ZoomFactor, rect.Y * ZoomFactor, rect.Width * ZoomFactor, rect.Height * ZoomFactor);
                gfx.DrawRectangle(pen, zoomRect);
            }
        }

        /// <summary>
        /// Paint current selector
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="pen"></param>
        private void PaintSelector(Graphics gfx, Pen pen)
        {
            if (IsSelected)
            {
                Rectangle rect = ValidateRect();
                Rectangle zoomRect = new(rect.X * ZoomFactor, rect.Y * ZoomFactor, rect.Width * ZoomFactor, rect.Height * ZoomFactor);
                gfx.DrawRectangle(pen, zoomRect);
            }
        }

        /// <summary>
        /// Paint the pixel grid
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="rect"></param>
        /// <param name="gridSize"></param>
        /// <param name="pen"></param>
        private void PaintGrid(Graphics gfx, Rectangle rect, Size gridSize, Pen pen)
        {
            int GridXOffset = gridSize.Width * ZoomFactor;

            for (int x = GridXOffset; x < rect.Width; x += GridXOffset)
            {
                gfx.DrawLine(pen, x, 0, x, rect.Height);
            }

            int GridYOffset = gridSize.Height * ZoomFactor;

            for (int y = GridYOffset; y < rect.Height; y += GridYOffset)
            {
                gfx.DrawLine(pen, 0, y, rect.Width, y);
            }
        }
    }
}