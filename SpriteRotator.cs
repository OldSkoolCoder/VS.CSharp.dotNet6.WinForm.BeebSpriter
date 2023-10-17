using BeebSpriter.Controls;
using BeebSpriter.Internal;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeebSpriter
{
    public partial class SpriteRotator : Form
    {
        private const int ZOOM_INCREMENT = 1;
        private const int ZOOM_MIN_FACTOR = 4;
        private const int ZOOM_MAX_FACTOR = 20;

        public Bitmap Image => ImageBox.Image;

        public SpriteRotator(Sprite sprite, int pixelSizeX, int pixelSizeY)
        {
            InitializeComponent();

            BeebPalette palette = new(sprite.NumColours, sprite.Palette);
            
            ImageBox.CenterImage = true;
            ImageBox.ZoomFactor = 8;
            ImageBox.PixelAspectRatio = new Point(pixelSizeX, pixelSizeY);
            ImageBox.Image = sprite.ToImage(palette);
            ImageBox.ImageSize = new Size(sprite.Width, sprite.Height);
            ImageBox.Invalidate();
            
            ZoomToolStripStatusLabel.Text = string.Format("Zoom x{0}", ImageBox.ZoomFactor);
        }

        /// <summary>
        /// Form Resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpriteRotator_Resize(object sender, EventArgs e)
        {
            ImageBox.Invalidate();
        }

        /// <summary>
        /// Show / Hide Pixel Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowGrid_Click(object sender, EventArgs e)
        {
            ImageBox.ShowGrid = ShowGrid.Checked;
            ImageBox.Invalidate();
        }

        /// <summary>
        /// Zoom Out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOutoolStripButton_Click(object sender, EventArgs e)
        {
            if (ImageBox.ZoomFactor > ZOOM_MIN_FACTOR)
            {
                Zoom(-ZOOM_INCREMENT);
            }
        }

        /// <summary>
        /// Zoom In
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomInToolStripButton_Click(object sender, EventArgs e)
        {
            if (ImageBox.ZoomFactor < ZOOM_MAX_FACTOR)
            {
                Zoom(+ZOOM_INCREMENT);
            }
        }

        /// <summary>
        /// Zoom
        /// </summary>
        /// <param name="value"></param>
        private void Zoom(int value)
        {
            ImageBox.ZoomFactor += value;
            ImageBox.Invalidate();
            ZoomToolStripStatusLabel.Text = string.Format("Zoom x{0}", ImageBox.ZoomFactor);
        }

        /// <summary>
        /// Rotate image by set angle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angle_ValueChanged(object sender, EventArgs e)
        {
            ImageBox.RotateImage(Angle.Value);
        }

        /// <summary>
        /// OK button Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Cancel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}