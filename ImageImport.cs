using BeebSpriter.Controls;
using BeebSpriter.Enum;
using BeebSpriter.Internal;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static BeebSpriter.BeebPalette;

namespace BeebSpriter
{
    public partial class ImageImport : Form
    {
        private const int MAX_COLOURS = 16;

        private const int ZOOM_INCREMENT = 1;
        private const int ZOOM_MIN_FACTOR = 1;
        private const int ZOOM_MAX_FACTOR = 20;

        /// <summary>
        /// Acorn Mode
        /// </summary>
        public int Mode { get; set; }

        public SpriteObjectList SpriteImages => Canvas.SpriteObjectList;

        /// <summary>
        /// Acorn Palette
        /// </summary>
        public BeebPalette Palette { get; set; }

        public ImageImport()
        {
            InitializeComponent();

            UpdateMainMenu();

            ZoomToolStripStatusLabel.Text = string.Format("Zoom x{0}", Canvas.ZoomFactor);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageImport_Load(object sender, EventArgs e)
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
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripButton_Click(object sender, EventArgs e)
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
                Canvas.Load(openFileDialog.FileName);
                MessageToolStripStatusLabel.Text = string.Format("Image Size: {0}x{1} pixels", Canvas.Image.Width, Canvas.Image.Height);

                Canvas.SpriteObjectList.SelectAll();
                Canvas.SpriteObjectList.DeleteSelectedItems();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGrid_Click(object sender, EventArgs e)
        {
            Canvas.ShowGrid = ButtonGrid.Checked;
            Canvas.Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOutoolStripButton_Click(object sender, EventArgs e)
        {
            if (Canvas.ZoomFactor > ZOOM_MIN_FACTOR)
            {
                Zoom(-ZOOM_INCREMENT);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomInToolStripButton_Click(object sender, EventArgs e)
        {
            if (Canvas.ZoomFactor < ZOOM_MAX_FACTOR)
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
            Canvas.ZoomFactor += value;
            Canvas.Invalidate();
            ZoomToolStripStatusLabel.Text = string.Format("Zoom x{0}", Canvas.ZoomFactor);
        }

        /// <summary>
        ///
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
                    Canvas.Image = Canvas.OriginalImage;
                    Canvas.Animate(true);
                    break;

                case 1: Mode = 0; ConvertMode(2); break;
                case 2: Mode = 1; ConvertMode(4); break;
                case 3: Mode = 2; ConvertMode(16); break;
                case 4: Mode = 4; ConvertMode(2); break;
                case 5: Mode = 5; ConvertMode(4); break;
                default: throw new NotImplementedException();
            }

            // Doesn't work properly yet so keep at 1:1
            Canvas.PixelAspectRatio = new Point(xs, ys);

            Canvas.Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.AlignSprites(AlignType.Left);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CentresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.AlignSprites(AlignType.Centre);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.AlignSprites(AlignType.Right);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.AlignSprites(AlignType.Top);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiddlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.AlignSprites(AlignType.Middle);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BottomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.AlignSprites(AlignType.Bottom);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.ReSizeSelectedItems(ResizeType.Width);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.ReSizeSelectedItems(ResizeType.Height);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.ReSizeSelectedItems(ResizeType.Both);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeEqualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.SpaceOutSelectedItems(SpaceOutType.Horizontal);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeEqualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Canvas.SpaceOutSelectedItems(SpaceOutType.Vertical);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.CutSelectedItems();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.CopySelectedItems();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.PasteSelectedItems();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.DeleteSelectedItems();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.SelectAll();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_SpriteClicked(object sender, ActiveSpriteEventArgs e)
        {
            UpdateMainMenu();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_SpritesCreated(object sender, SelectedSpritesEventArgs e)
        {
            UpdateMainMenu();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_SpritesDeleted(object sender, SelectedSpritesEventArgs e)
        {
            UpdateMainMenu();
        }

        /// <summary>
        ///
        /// </summary>
        private void UpdateMainMenu()
        {
            CutToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanCut;
            CopyToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanCopy;
            PasteToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanPaste;
            DeleteToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanDelete;
            SelectAllToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanSelectAll;

            LeftsToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanAlign;
            CentresToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanAlign;
            RightsToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanAlign;
            TopsToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanAlign;
            MiddlesToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanAlign;
            BottomsToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanAlign;

            WidthToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanResize;
            HeightToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanResize;
            BothToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanResize;

            MakeHorizontalEqualToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanSpaceOut;
            MakeVerticalEqualToolStripMenuItem1.Enabled = Canvas.SpriteObjectList.CanSpaceOut;

            BringToFrontToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanBringToFront;
            SendToBackToolStripMenuItem.Enabled = Canvas.SpriteObjectList.CanSendToBack;
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
                int[] colCount = Canvas.OriginalImage.CountPalette(Palette);

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

            Canvas.Image = Canvas.OriginalImage.ToAcornFormat(Palette);
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
                Bitmap = Canvas.Image.ExtractSprite(Palette, rect)
            };

            return sprite;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            // Remove any invalid sprites
            Rectangle rect = new(0, 0, Canvas.Image.Width, Canvas.Image.Height);
            Canvas.SpriteObjectList.RemoveInvalidItems(rect);

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