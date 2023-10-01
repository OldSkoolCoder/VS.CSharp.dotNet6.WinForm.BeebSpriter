using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BeebSpriter.Enum;

namespace BeebSpriter
{
    public partial class AnimationPreview : Form
    {
        // List of Sprites To Animate
        private BindingList<Sprite> spriteList = new BindingList<Sprite>();

        //private bool isPlaying = false;
        private int currentFrame = 0;
        private int animationDirection = 1;
        private Timer timer = new Timer();

        public AnimationPreview()
        {
            // Constructor for the Windows Form, this is run First.

            // Configure form
            InitializeComponent();          // Auto Generated Code#

            // Change the background colour of the Sprite Displaying Panel
            ApplyBackgroundColour();

            // Settings the active Item in the Play Mode to Index 0
            lbMode.SelectedIndex = 0;

            // Binding the Timer Tick event to the Function
            timer.Tick += new EventHandler(timer_Tick);

            // Set the data source for the sprite list
            lbSpriteList.DataSource = spriteList;

            // Initialise the Zoom Control
            setZoomLevel();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            switch (lbMode.SelectedIndex)
            {
                case (int)AnimationMode.Cyclic:
                    currentFrame++;
                    if (currentFrame >= spriteList.Count)
                    {
                        currentFrame = 0;
                    }
                    break;

                case (int)AnimationMode.YoYo:
                    currentFrame += animationDirection;
                    if (currentFrame >= spriteList.Count)
                    {
                        animationDirection = -1;
                        currentFrame = spriteList.Count - 1;
                    }
                    if (currentFrame < 0)
                    {
                        animationDirection = 1;
                        currentFrame = 0;
                    }
                    break;

                case (int)AnimationMode.OneShot:
                    if (currentFrame < spriteList.Count - 1)
                    {
                        currentFrame++;
                    }
                    break;
            }

            RefreshAnimation();
        }

        // Garbage Collecting, when Form Closes
        private void AnimationPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpriteSheetForm.Instance.CloseAnimationPreview();
        }

        // Applying the default background colour to Sprite Panel
        public void ApplyBackgroundColour()
        {
            previewPanel.BackColor = SpriteSheetForm.Instance.GetBackgroundColour();
        }

        public void Add(Sprite sprite)
        {
            spriteList.Add(sprite);
        }

        public void Remove(Sprite sprite)
        {
            spriteList.Remove(sprite);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbSpriteList.SelectedIndex;

            if (index != -1 && index < lbSpriteList.Items.Count)
            {
                spriteList.RemoveAt(index);
            }
        }

        private void btnSpriteMoveUp_Click(object sender, EventArgs e)
        {
            int index = lbSpriteList.SelectedIndex;

            if (index > 0 && index < lbSpriteList.Items.Count)
            {
                Sprite thisItem = spriteList[index];
                spriteList.RemoveAt(index);
                spriteList.Insert(index - 1, thisItem);
                lbSpriteList.SelectedIndex = index - 1;
            }
        }

        
        private void btnSpriteMoveDown_Click(object sender, EventArgs e)
        {
            int index = lbSpriteList.SelectedIndex;

            if (index < lbSpriteList.Items.Count - 1)
            {
                Sprite thisItem = spriteList[index];
                spriteList.RemoveAt(index);
                spriteList.Insert(index + 1, thisItem);
                lbSpriteList.SelectedIndex = index + 1;
            }
        }

        private void previewPanel_Paint(object sender, PaintEventArgs e)
        {
            // This code is lifted straight out of the Paint code for the SpritePanel.
            // This is just horrible; ideally there should be some generic way to do this in both
            // places, but I'm adding this quickly, so... whatever.

            //if (isPlaying && spriteList.Count > 0)
            //if (timer.Enabled && spriteList.Count > 0)
            if (spriteList.Count > 0)
            {
                Sprite sprite = spriteList[currentFrame];

                SpriteSheet spriteSheet = SpriteSheetForm.Instance.SpriteSheet;
                //int spriteDisplayWidth = sprite.Width * spriteSheet.XScale;
                //int spriteDisplayHeight = sprite.Height * spriteSheet.YScale;

                int spriteDisplayWidth = sprite.Width * (spriteSheet.XScale * tbZoom.Value);
                int spriteDisplayHeight = sprite.Height * (spriteSheet.YScale * tbZoom.Value);

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
                    dc.DrawImage(bmp, new Rectangle((previewPanel.ClientSize.Width - spriteDisplayWidth) / 2,
                                                    (previewPanel.ClientSize.Height - spriteDisplayHeight) / 2,
                                                    spriteDisplayWidth,
                                                    spriteDisplayHeight));
                    dc.PixelOffsetMode = oldPixelOffsetMode;
                    dc.InterpolationMode = oldInterpolationMode;
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //if (!isPlaying && lbSpriteList.Items.Count > 0)
            if (!timer.Enabled && lbSpriteList.Items.Count > 0)
            {
                //isPlaying = true;
                currentFrame = lbSpriteList.SelectedIndex;
                RefreshAnimation();
                timer.Interval = tbSpeed.Value * 30;
                timer.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopAnimation();
        }

        private void RefreshAnimation()
        {
            if (lbSpriteList.Items.Count != 0)
            {
                lbSpriteList.SelectedIndex = currentFrame;
                previewPanel.Invalidate();
            }
            else
            {
                stopAnimation();
            }
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            //if (isPlaying)
            if (timer.Enabled)
            {
                timer.Interval = tbSpeed.Value * 30;
            }
        }

        private void tbZoom_Scroll(object sender, EventArgs e)
        {
            setZoomLevel();
            RefreshAnimation();
        }

        private void setZoomLevel()
        {
            lblZoom.Text = "x " + tbZoom.Value.ToString();
        }

        private void stopAnimation()
        {
            //if (isPlaying)
            if (timer.Enabled)
            {
                //isPlaying = false;
                timer.Stop();
                previewPanel.Invalidate();
            }
        }

        private void lbSpriteList_Click(object sender, EventArgs e)
        {
            PreviewSprite(lbSpriteList.SelectedIndex);
        }

        private void AnimationPreview_ResizeEnd(object sender, EventArgs e)
        {
            PreviewSprite(lbSpriteList.SelectedIndex);
        }

        private void PreviewSprite(int spriteNumber)
        {
            currentFrame = spriteNumber;
            previewPanel.Invalidate();
        }
    }
}
