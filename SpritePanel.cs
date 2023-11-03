using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BeebSpriter
{
    public class SpritePanel : Panel
    {
        const int minWidth = 64;
        const int textLabelHeight = 22;

        private Sprite sprite;
        private Label label;
        private DoubleBufferedPanel panel;
        private SpriteEditor editorForm;

        private int spriteDisplayWidth;
        private int spriteDisplayHeight;

        private int mouseX = 0;
        private int mouseY = 0;
        private bool isDragging = false;

        public Sprite Sprite
        {
            get { return this.sprite; }
        }

        public Label Label
        {
            get { return this.label; }
        }

        public DoubleBufferedPanel Panel
        {
            get { return this.panel; }
        }

        public SpriteEditor EditorForm
        {
            get { return this.editorForm; }
        }

        public SpritePanel(Sprite sprite)
        {
            this.sprite = sprite;

            label = new Label();
            panel = new DoubleBufferedPanel();

            this.Location = new Point(0, 0);
            this.Margin = new Padding(5);
            this.MouseClick += new MouseEventHandler(SpritePanel_Click);
            this.MouseDown += new MouseEventHandler(SpritePanel_MouseDown);
            this.MouseMove += new MouseEventHandler(SpritePanel_MouseMove);
            this.MouseUp += new MouseEventHandler(SpritePanel_MouseUp);
            this.MouseDoubleClick += new MouseEventHandler(SpritePanel_MouseDoubleClick);

            panel.MouseClick += new MouseEventHandler(SpritePanel_Click);
            panel.MouseDown += new MouseEventHandler(SpritePanel_MouseDown);
            panel.MouseMove += new MouseEventHandler(SpritePanel_MouseMove);
            panel.MouseUp += new MouseEventHandler(SpritePanel_MouseUp);
            panel.MouseDoubleClick += new MouseEventHandler(SpritePanel_MouseDoubleClick);
            panel.Paint += new PaintEventHandler(panel_Paint);

            label.Text = sprite.Name;
            label.TextAlign = ContentAlignment.TopCenter;
            label.ForeColor = SpriteSheetForm.Instance.ChooseBestTextColour();
            label.MouseClick += new MouseEventHandler(SpritePanel_Click);
            label.MouseDown += new MouseEventHandler(SpritePanel_MouseDown);
            label.MouseMove += new MouseEventHandler(SpritePanel_MouseMove);
            label.MouseUp += new MouseEventHandler(SpritePanel_MouseUp);
            label.MouseDoubleClick += new MouseEventHandler(SpritePanel_MouseDoubleClick);

            ResizePanel();

            this.SuspendLayout();
            this.Controls.Add(panel);
            this.Controls.Add(label);
            this.ResumeLayout();
        }

        public void ResizePanel(int ?scalingfactor=1)
        {
            SpriteSheet spriteSheet = SpriteSheetForm.Instance.SpriteSheet;
            spriteDisplayWidth = sprite.Width * spriteSheet.XScale * (int)scalingfactor;
            spriteDisplayHeight = sprite.Height * spriteSheet.YScale * (int)scalingfactor;

            int textWidth;
            using (Graphics g = CreateGraphics())
            {
                textWidth = (int)Math.Ceiling(g.MeasureString(sprite.Name, label.Font).Width);
            }

            int panelWidth = Math.Max(minWidth, Math.Max(spriteDisplayWidth, textWidth));
            int panelHeight = spriteDisplayHeight + textLabelHeight;
            this.Size = new Size(panelWidth, panelHeight);

            panel.Location = new Point((panelWidth - spriteDisplayWidth) / 2, 0);
            panel.Size = new Size(spriteDisplayWidth, spriteDisplayHeight);

            label.Location = new Point(0, spriteDisplayHeight + 4);
            label.Size = new Size(panelWidth, textLabelHeight);
        }

        public void ForgetEditorForm()
        {
            this.editorForm = null;
        }


        void SpritePanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDragging = false;
        }

        void SpritePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.isDragging)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int dx = this.mouseX - e.X;
                    int dy = this.mouseY - e.Y;
                    if (dx * dx + dy * dy > 16)
                    {
                        DoDragDrop(this, DragDropEffects.All);
                        this.isDragging = true;
                        return;
                    }
                }
            }
        }

        void SpritePanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Focus();
            this.mouseX = e.X;
            this.mouseY = e.Y;
            this.isDragging = false;
        }

        void SpritePanel_Click(object sender, MouseEventArgs e)
        {
            this.Focus();
        }

        void SpritePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (editorForm == null)
            {
                editorForm = new SpriteEditor(this);

                //Form myForm = new MyForm();
                //myForm.FormClosed += (s, args) => myForm.Dispose();
                //myForm.Show();


                editorForm.Show(SpriteSheetForm.Instance);
            }
            else
            {
                editorForm.Focus();
            }
        }

        void panel_Paint(object sender, PaintEventArgs e)
        {
            // Create a bitmap dynamically each time we paint, because .NET is tricky with Bitmap
            // objects (they cannot be modified or replaced very easily)
            using (Bitmap bmp = new Bitmap(sprite.Width, sprite.Height, PixelFormat.Format8bppIndexed))
            {
                // Copy the sprite definition into the Bitmap using safe code
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, sprite.Width, sprite.Height),
                                                  ImageLockMode.WriteOnly,
                                                  PixelFormat.Format8bppIndexed);

                if (bmpData.Stride != sprite.Width)
                {
                    for (int n = 0; n < sprite.Height; n++)
                    {
                        Marshal.Copy(sprite.Bitmap, n * sprite.Width, bmpData.Scan0 + n * bmpData.Stride, sprite.Width);
                    }
                }
                else
                {
                    Marshal.Copy(sprite.Bitmap, 0, bmpData.Scan0, sprite.Width * sprite.Height);
                }
                bmp.UnlockBits(bmpData);

                // Set up the first four palette entries of the Bitmap
                ColorPalette palette = bmp.Palette;
                for (int n = 0; n < sprite.Palette.Length; n++)
                {
                    palette.Entries[n] = BeebPalette.GetWindowsColour(sprite.Palette[n]);
                }
                palette.Entries[255] = SpriteSheetForm.Instance.GetBackgroundColour();
                bmp.Palette = palette;

                // ...and draw it (with texel interpolation turned off)
                Panel panel = sender as Panel;
                Graphics dc = e.Graphics;

                InterpolationMode oldInterpolationMode = dc.InterpolationMode;
                PixelOffsetMode oldPixelOffsetMode = dc.PixelOffsetMode;
                dc.InterpolationMode = InterpolationMode.NearestNeighbor;
                dc.PixelOffsetMode = PixelOffsetMode.Half;
                dc.DrawImage(bmp, new Rectangle(0, 0, spriteDisplayWidth, spriteDisplayHeight));
                dc.PixelOffsetMode = oldPixelOffsetMode;
                dc.InterpolationMode = oldInterpolationMode;
            }
        }


    }
}
