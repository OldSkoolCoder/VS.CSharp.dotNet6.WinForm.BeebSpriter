using BeebSpriter.Internal;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BeebSpriter
{
    public partial class ResizeDialog : Form
    {
        private bool valueChangedFlag = false;
        public Bitmap Image => ImageBox.Image;
        public Sprite Sprite { get; set; }
        public int NewWidth { get; set; }
        public int NewHeight { get; set; }

        public InterpolationMode Mode { get; set; }

        public ResizeDialog(Sprite sprite)
        {
            InitializeComponent();

            Sprite = sprite;

            NumericWidth.Value = sprite.Width;
            NumericHeight.Value = sprite.Height;

            BeebPalette palette = new(sprite.NumColours, sprite.Palette);

            ImageBox.CenterImage = true;
            ImageBox.ShowGrid = false;
            ImageBox.Image = sprite.ToImage(palette);
            ImageBox.ImageSize = new Size(sprite.Width, sprite.Height);
            ImageBox.Invalidate();

            ComboBox1.Items.Clear();

            foreach (var itm in System.Enum.GetValues(typeof(InterpolationMode)))
            {
                ComboBox1.Items.Add(itm.ToDescription());
            }

            ComboBox1.SelectedIndex = 5;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            NewWidth = (int)NumericWidth.Value;
            NewHeight = (int)NumericHeight.Value;
            Mode = (InterpolationMode)ComboBox1.SelectedIndex;

            ImageBox.Image = ImageBox.Image.ResizeImage(NewWidth, NewHeight, Mode);

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///
        /// </summary>er"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericWidth_ValueChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked && valueChangedFlag == false)
            {
                valueChangedFlag = true;
                decimal ratio = NumericWidth.Value / Sprite.Width;
                NumericHeight.Value = Sprite.Width * ratio;
            }
            else
            {
                valueChangedFlag = false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericHeight_ValueChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked && valueChangedFlag == false)
            {
                valueChangedFlag = true;
                decimal ratio = NumericHeight.Value / Sprite.Width;
                NumericWidth.Value = Sprite.Height * ratio;
            }
            else
            {
                valueChangedFlag = false;
            }
        }
    }
}