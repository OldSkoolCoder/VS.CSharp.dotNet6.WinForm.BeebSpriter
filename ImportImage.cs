using BeebSpriter.Controls;
using BeebSpriter.Enum;
using BeebSpriter.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static BeebSpriter.BeebPalette;

namespace BeebSpriter
{
    public partial class ImportImage : Form
    {
        private const int MAX_COLOURS = 16;

        private const int ZOOM_INCREMENT = 1;
        private const int ZOOM_MIN_FACTOR = 1;
        private const int ZOOM_MAX_FACTOR = 20;

        /// <summary>
        /// Acorn Mode
        /// </summary>
        public int Mode { get; set; }

        /// <summary>
        /// Gets the number of sprites selected
        /// </summary>
        public List<Rectangle> SpriteList => ImageBox.SpriteList;

        /// <summary>
        /// Get the image
        /// </summary>
        public Bitmap Image => ImageBox.Image;

        /// <summary>
        /// Acorn Palette
        /// </summary>
        public BeebPalette Palette { get; set; }

        /// <summary>
        ///
        /// </summary>
        public ImportImage()
        {
            InitializeComponent();

            ZoomToolStripStatusLabel.Text = string.Format("Zoom x{0}", ImageBox.ZoomFactor);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportImage_Load(object sender, EventArgs e)
        {
            ComboBoxGfxMode.Items.Clear();

            foreach (var itm in System.Enum.GetValues(typeof(GfxModeType)))
            {
                ComboBoxGfxMode.Items.Add(itm.ToDescription());
            }

            ComboBoxGfxMode.Items.Insert(0, "Original Image");

            ComboBoxGfxMode.SelectedIndex = 0;
        }

        /// <summary>
        /// open image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Open Image File",
                Filter = Helper.GetImageFilter(),
                DefaultExt = "png"
            };

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ImageBox.Load(openFileDialog.FileName);
                MessageToolStripStatusLabel.Text = string.Format("Image Size: {0}x{1} pixels", ImageBox.Image.Width, ImageBox.Image.Height);
            }
        }

        /// <summary>
        /// Toggle pixel grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGrid_Click(object sender, EventArgs e)
        {
            ImageBox.ShowGrid = ButtonGrid.Checked;
            ImageBox.Invalidate();
        }

        /// <summary>
        /// Zoom out
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
        /// Zoom in
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
        /// Change image to another mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxGfxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonGenerate.Enabled = true;

            int xs = 1, ys = 1;

            switch (ComboBoxGfxMode.SelectedIndex)
            {
                case 0:
                    ButtonGenerate.Enabled = false;
                    ImageBox.Image = ImageBox.OriginalImage;
                    break;

                case 1: Mode = 0; ConvertMode(2); break;
                case 2: Mode = 1; ConvertMode(4); break;
                case 3: Mode = 2; ConvertMode(16); break;
                case 4: Mode = 4; ConvertMode(2); break;
                case 5: Mode = 5; ConvertMode(4); break;
                default: throw new NotImplementedException();
            }

            // Doesn't work properly yet so keep at 1:1
            ImageBox.PixelAspectRatio = new Point(xs, ys);

            ImageBox.Invalidate();
        }

        /// <summary>
        /// Convert image to an Acorn mode
        /// </summary>
        /// <param name="numColours"></param>
        public void ConvertMode(int numColours)
        {
            Palette = new(MAX_COLOURS);

            // Need to create a new Acorn palette for maximum used colours
            if (numColours < MAX_COLOURS)
            {
                int[] colCount = ImageBox.OriginalImage.CountPalette(Palette);

                // Order indices
                var colOrder = Enumerable.Range(0, colCount.Length).OrderByDescending(i => colCount[i]).ToList();

                Palette = new(numColours);

                // Create new palette from colours
                for (int i = 0; i < numColours; i++)
                {
                    // Acorn Palette
                    Palette.BeebColours[i] = (Colour)colOrder[i];

                    Color col = BeebPalette.GetWindowsColour((Colour)colOrder[i]);

                    // Windows palette
                    Palette.WinColours[i] = col;
                }
            }

            ImageBox.Image = ImageBox.OriginalImage.ToAcornFormat(Palette);
        }

        /// <summary>
        /// Extract a single sprite from an image
        /// </summary>
        /// <param name="spriteName"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        public Sprite ExtractSprite(string spriteName, Rectangle rect)
        {
            Sprite sprite = new(spriteName, rect.Width, rect.Height, Palette.BeebColours)
            {
                Bitmap = Image.ExtractSprite(Palette, rect)
            };

            return sprite;
        }

        /// <summary>
        /// OK Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Cancel clicked
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