using BeebSpriter.Internal;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeebSpriter
{
    public partial class CanvasSizeDialog : Form
    {
        public int NewWidth { get; set; }
        public int NewHeight { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sprite"></param>
        public CanvasSizeDialog(Sprite sprite)
        {
            InitializeComponent();

            numericWidth.Value = sprite.Width;
            numericHeight.Value = sprite.Height;

            BeebPalette palette = new(sprite.NumColours, sprite.Palette);

            ImageBox.CenterImage = true;
            ImageBox.ShowGrid = false;
            ImageBox.Image = sprite.ToImage(palette);
            ImageBox.ImageSize = new Size(sprite.Width, sprite.Height);
            ImageBox.Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            NewWidth = numericWidth.Value.ToInteger();
            NewHeight = numericHeight.Value.ToInteger();

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///
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