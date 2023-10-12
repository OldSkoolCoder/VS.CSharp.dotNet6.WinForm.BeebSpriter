using BeebSpriter.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static BeebSpriter.BeebPalette;

namespace BeebSpriter
{
    public partial class SpriteEditor : Form
    {
        /// <summary>
        /// Amount to increment / decrement the zoom level
        /// </summary>
        private const int ZOOM_INCREMENT = 1;

        /// <summary>
        /// Minimum Zoom manification
        /// </summary>
        private const int ZOOM_MIN_FACTOR = 4;

        /// <summary>
        /// Maximum Zoom manification
        /// </summary>
        private const int ZOOM_MAX_FACTOR = 20;

        /// <summary>
        /// Zoom Level property
        /// </summary>
        public int ZoomLevel { get; set; }

        /// <summary>
        ///  Reference to the sprite panel we correspond to
        /// </summary>
        private SpritePanel spritePanel;

        /// <summary>
        ///  Reference to the actual sprite data we correspond to
        /// </summary>
        private Sprite sprite;

        /// <summary>
        ///  Overall zoom factor (alterable from menu)
        /// </summary>
        private int zoom;

        private int horizontalBlockDividers;
        private int verticalBlockDividers;

        /// <summary>
        ///  Pixel size multiplier in X
        /// </summary>
        private int pixelSizeX;

        /// <summary>
        ///  Pixel size multiplier in Y
        /// </summary>
        private int pixelSizeY;

        /// <summary>
        ///  Zoom factor in x direction, taking into account pixel size and editor zoom
        /// </summary>
        private int xzoom;

        /// <summary>
        ///  Zoom factor in y direction, taking into account pixel size and editor zoom
        /// </summary>
        private int yzoom;

        /// <summary>
        ///  Current draw colour (when LH mouse pressed) - a colour index from 0...MaxColours-1, not the actual colour
        /// </summary>
        private int drawColour;

        /// <summary>
        ///  Current erase colour (when RH mouse pressed) - a colour index from 0...MaxColours-1, not the actual colour
        /// </summary>
        private int eraseColour;

        /// <summary>
        ///  List of possible editing modes
        /// </summary>
        enum Mode
        {
            Draw,
            Fill,
            InsertRow,
            DeleteRow,
            InsertColumn,
            DeleteColumn,
            Select,
            Paste
        };

        /// <summary>
        ///  Current editing mode
        /// </summary>
        private Mode editMode = Mode.Draw;

        /// <summary>
        ///  Used to keep track of mouse drags
        /// </summary>
        private bool isMouseHeld = false;

        /// <summary>
        ///  Used to interpolate a line between MouseMove events (if the mouse is moved quickly)
        /// </summary>
        private Point lastMousePos;

        /// <summary>
        ///  True if there is an area selected (it means selectionOrigin and selectionEnd are valid)
        /// </summary>
        private bool isSelection = false;

        /// <summary>
        ///  The origin of the selected rectangle, i.e. the initial point that was clicked
        /// </summary>
        private Point selectionOrigin;

        /// <summary>
        ///  The current end point of the selection; this may be still getting updated if the drag is
        ///  continuing, else it's the final position
        /// </summary>
        private Point selectionEnd;

        /// <summary>
        ///  This is a hack because I don't really know how you're supposed to handle auto-scrolling
        ///  at the edges of a panel. I use this to prevent recursive MouseMove events (further
        ///  explanation in the event handler itself).
        /// </summary>
        private bool ignoreNextMouseMoveEvent = false;

        /// <summary>
        ///  True if we should render a zoomed up version of the clipboard sprite underneath the mouse cursor
        ///  (because we are in paste mode)
        /// </summary>
        private bool renderPastePreview = false;

        /// <summary>
        ///  The x position of the top left of the clipboard sprite
        /// </summary>
        private int pasteX;

        /// <summary>
        ///  The y position of the top left of the clipboard sprite
        /// </summary>
        private int pasteY;

        /// <summary>
        ///  Array of Panels, one for each colour index, so I can refer to a Panel by its index
        /// </summary>
        private Panel[] colourPanels;

        struct Snapshot
        {
            public int width;
            public int height;
            public byte[] bitmap;
        }

        /// <summary>
        ///  This is for the undo/redo buffer.
        ///  A circular stack is one whose oldest elements are dropped forever when it runs out of space
        /// </summary>
        private CircularStack<Snapshot> undoBuffer = new CircularStack<Snapshot>(64);
        private CircularStack<Snapshot> redoBuffer = new CircularStack<Snapshot>(64);

        private ResizeDialog resizeDialog = new ResizeDialog();

        private Timer timer = new Timer();

        /// <summary>
        ///  Constructor for the SpriteEditor form
        /// </summary>
        /// <param name="spritePanel">The SpritePanel it refers to</param>
        public SpriteEditor(SpritePanel spritePanel)
        {
            SpriteSheet spriteSheet = SpriteSheetForm.Instance.SpriteSheet;

            this.spritePanel = spritePanel;
            this.sprite = spritePanel.Sprite;
            this.pixelSizeX = spriteSheet.XScale;
            this.pixelSizeY = spriteSheet.YScale;
            this.zoom = spriteSheet.DefaultZoom;
            this.horizontalBlockDividers = spriteSheet.HorizontalBlockDividers;
            this.verticalBlockDividers = spriteSheet.VerticalBlockDividers;

            this.timer.Interval = 465;
            // Binding the Timer Tick event to the Function
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            // Configure form + controls
            InitializeComponent();

            ZoomLevel = 8;
            ZoomToolStripStatusLabel.Text = String.Format("Zoom x {0}", ZoomLevel.ToString());

            ApplyZoomToForm();
            ApplyHorizontalBlockDividersToForm();
            ApplyVerticalBlockDividersToForm();

            ShowGrid.Checked = spriteSheet.DefaultShowGridLines;
          
            if (sprite.Name != "")
            {
                this.Text = sprite.Name;
            }
            else
            {
                this.Text = "<Unnamed sprite>";
            }

            // Make an array to look up colour panels by index
            colourPanels = new Panel[16]
            {
                button_colour0,
                button_colour1,
                button_colour2,
                button_colour3,
                button_colour4,
                button_colour5,
                button_colour6,
                button_colour7,
                button_colour8,
                button_colour9,
                button_colour10,
                button_colour11,
                button_colour12,
                button_colour13,
                button_colour14,
                button_colour15
            };

            // Configure colour panels according to how many colours are in this mode
            this.eraseColour = 0;
            switch (spriteSheet.NumColours)
            {
                case 2:
                    for (int i = 2; i < 16; i++)
                    {
                        colourPanels[i].Hide();
                    }
                    this.drawColour = 1;
                    break;

                case 4:
                    for (int i = 4; i < 16; i++)
                    {
                        colourPanels[i].Hide();
                    }
                    this.drawColour = 3;
                    break;

                case 16:
                    this.drawColour = 7;
                    break;

                default:
                    throw new Exception("Unexpected number of colours (" + spriteSheet.NumColours + ")");
            }

            // Set palettes
            for (int i = 0; i < spriteSheet.NumColours; i++)
            {
                colourPanels[i].BackColor = BeebPalette.GetWindowsColour(sprite.Palette[i]);
            }

            currentColour.Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (sprite.Palette.Length > 7)
            {
                for (int index = 8; index < 16; index++)
                {
                    sprite.Palette[index] = BeebPalette.GetFlashingColour(sprite.Palette[index]);
                    colourPanels[index].BackColor = BeebPalette.GetWindowsColour(sprite.Palette[index]); ;
                }
                currentColour.Invalidate();
                editorPanel.Invalidate();
                spritePanel.Panel.Invalidate();
            }
        }


        /// <summary>
        ///  Just before the form is closed, NULL its reference in the SpritePanel that spawned it,
        ///  so the GC is free to delete it when it wants
        /// </summary>
        private void SpriteEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            spritePanel.ForgetEditorForm();
        }


        /// <summary>
        ///  Called when the panel is resized
        /// </summary>
        private void panel2_Resize(object sender, EventArgs e)
        {
            RepositionZoomedSprite();
        }




        #region Zoom

        /// <summary>
        ///  The zoomed sprite is always centred in the middle of the resizeable editing panel,
        ///  and is implemented as a child panel.
        ///  The routine positions it correctly (centred, or at 0,0 if it is larger than its parent)
        /// </summary>
        private void RepositionZoomedSprite()
        {
            int x = Math.Max(0, (editorContainer.ClientSize.Width - sprite.Width * xzoom) / 2);
            int y = Math.Max(0, (editorContainer.ClientSize.Height - sprite.Height * yzoom) / 2);
            editorPanel.Location = new Point(x, y);
        }


        /// <summary>
        ///  Applies the current value of this.zoom to various controls in the form,
        ///  and refreshes it.
        /// </summary>
        private void ApplyZoomToForm()
        {
            SpriteSheet spriteSheet = SpriteSheetForm.Instance.SpriteSheet;
            this.xzoom = spriteSheet.XScale * ZoomLevel;
            this.yzoom = spriteSheet.YScale * ZoomLevel;

            editorPanel.Size = new Size(sprite.Width * xzoom + 1, sprite.Height * yzoom + 1);
            RepositionZoomedSprite();
            editorPanel.Invalidate();
        }



        #endregion


        #region Character block dividers

        /// <summary>
        ///  Applies the current value of horizontalBlockDividers to the menu items in the form,
        ///  and refreshes the editor window.
        /// </summary>
        private void ApplyHorizontalBlockDividersToForm()
        {
            horizNever.Checked = false;
            horizEvery1.Checked = false;
            horizEvery2.Checked = false;
            horizEvery3.Checked = false;
            horizEvery4.Checked = false;

            if (horizontalBlockDividers == 0)
            {
                horizNever.Checked = true;
            }
            else if (horizontalBlockDividers == 1)
            {
                horizEvery1.Checked = true;
            }
            else if (horizontalBlockDividers == 2)
            {
                horizEvery2.Checked = true;
            }
            else if (horizontalBlockDividers == 3)
            {
                horizEvery3.Checked = true;
            }
            else if (horizontalBlockDividers == 4)
            {
                horizEvery4.Checked = true;
            }

            editorPanel.Invalidate();
        }


        /// <summary>
        ///  Applies the current value of verticalBlockDividers to the menu items in the form,
        ///  and refreshes the editor window.
        /// </summary>
        private void ApplyVerticalBlockDividersToForm()
        {
            vertNever.Checked = false;
            vertEvery1.Checked = false;
            vertEvery2.Checked = false;
            vertEvery3.Checked = false;
            vertEvery4.Checked = false;

            if (verticalBlockDividers == 0)
            {
                vertNever.Checked = true;
            }
            else if (verticalBlockDividers == 1)
            {
                vertEvery1.Checked = true;
            }
            else if (verticalBlockDividers == 2)
            {
                vertEvery2.Checked = true;
            }
            else if (verticalBlockDividers == 3)
            {
                vertEvery3.Checked = true;
            }
            else if (verticalBlockDividers == 4)
            {
                vertEvery4.Checked = true;
            }

            editorPanel.Invalidate();
        }

        private void horizNever_Click(object sender, EventArgs e)
        {
            SetHorizontalBlockDividers(0);
        }

        private void horizEvery1_Click(object sender, EventArgs e)
        {
            SetHorizontalBlockDividers(1);
        }

        private void horizEvery2_Click(object sender, EventArgs e)
        {
            SetHorizontalBlockDividers(2);
        }

        private void horizEvery3_Click(object sender, EventArgs e)
        {
            SetHorizontalBlockDividers(3);
        }

        private void horizEvery4_Click(object sender, EventArgs e)
        {
            SetHorizontalBlockDividers(4);
        }

        private void SetHorizontalBlockDividers(int value)
        {
            this.horizontalBlockDividers = value;
            SpriteSheetForm.Instance.SpriteSheet.HorizontalBlockDividers = value;
            ApplyHorizontalBlockDividersToForm();
        }

        private void vertNever_Click(object sender, EventArgs e)
        {
            SetVerticalBlockDividers(0);
        }

        private void vertEvery1_Click(object sender, EventArgs e)
        {
            SetVerticalBlockDividers(1);
        }

        private void vertEvery2_Click(object sender, EventArgs e)
        {
            SetVerticalBlockDividers(2);
        }

        private void vertEvery3_Click(object sender, EventArgs e)
        {
            SetVerticalBlockDividers(3);
        }

        private void vertEvery4_Click(object sender, EventArgs e)
        {
            SetVerticalBlockDividers(4);
        }

        private void SetVerticalBlockDividers(int value)
        {
            this.verticalBlockDividers = value;
            SpriteSheetForm.Instance.SpriteSheet.VerticalBlockDividers = value;
            ApplyVerticalBlockDividersToForm();
        }

        #endregion


        /// <summary>
        ///  Draws the zoomed sprite
        /// </summary>
        private void doubleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics dc = e.Graphics;

            // cache some brush types, one for each colour
            SolidBrush[] brushes = new SolidBrush[sprite.Palette.Length];
            for (int i = 0; i < sprite.Palette.Length; i++)
            {
                brushes[i] = new SolidBrush(BeebPalette.GetWindowsColour(sprite.Palette[i]));
            }
            SolidBrush transparentBrush = new SolidBrush(Color.Gray);

            // Work out the sprite pixel bounds of the area we need to repaint
            int left = Math.Max(0, e.ClipRectangle.Left / xzoom);
            int right = Math.Min(sprite.Width - 1, e.ClipRectangle.Right / xzoom);
            int top = Math.Max(0, e.ClipRectangle.Top / yzoom);
            int bottom = Math.Min(sprite.Height - 1, e.ClipRectangle.Bottom / yzoom);

            byte[] clipboard = SpriteSheetForm.Instance.Clipboard;
            int clipboardWidth = SpriteSheetForm.Instance.ClipboardWidth;
            int clipboardHeight = SpriteSheetForm.Instance.ClipboardHeight;

            // Draw zoomed up sprite, pixel by pixel
            for (int y = top; y <= bottom; y++)
            {
                for (int x = left; x <= right; x++)
                {
                    byte pixel;

                    if (renderPastePreview &&
                        x - pasteX >= 0 && x - pasteX < clipboardWidth &&
                        y - pasteY >= 0 && y - pasteY < clipboardHeight &&
                        clipboard[x - pasteX + (y - pasteY) * clipboardWidth] != 255)
                    {
                        // take a pixel from the paste preview
                        pixel = clipboard[x - pasteX + (y - pasteY) * clipboardWidth];
                    }
                    else
                    {
                        // take a pixel from the actual bitmap
                        pixel = sprite.Bitmap[x + y * sprite.Width];
                    }

                    if (pixel == 255)
                    {
                        dc.FillRectangle(transparentBrush,
                                         x * xzoom,
                                         y * yzoom,
                                         xzoom,
                                         yzoom);
                    }
                    else
                    {
                        dc.FillRectangle(brushes[pixel],
                                         x * xzoom,
                                         y * yzoom,
                                         xzoom,
                                         yzoom);
                    }
                }
            }

            // Draw the grid
            if (ShowGrid.Checked)
            {
                Pen gridPen = new Pen(Color.DarkSlateGray);
                Pen dividerPen = new Pen(Color.DarkSlateGray, 3.0f);
                int pixelsPerByte = SpriteSheetForm.Instance.SpriteSheet.PixelsPerByte;

                for (int x = left; x <= right + 1; x++)
                {
                    if (horizontalBlockDividers > 0 &&
                        x > 0 && x < sprite.Width &&
                        x % (pixelsPerByte * horizontalBlockDividers) == 0)
                    {
                        dc.DrawLine(dividerPen,
                                    x * xzoom, 0,
                                    x * xzoom, sprite.Height * yzoom);
                    }
                    else
                    {
                        dc.DrawLine(gridPen,
                                    x * xzoom, 0,
                                    x * xzoom, sprite.Height * yzoom);
                    }
                }

                for (int y = top; y <= bottom + 1; y++)
                {
                    if (verticalBlockDividers > 0 &&
                        y > 0 && y < sprite.Height &&
                        y % (8 * verticalBlockDividers) == 0)
                    {
                        dc.DrawLine(dividerPen,
                                    0, y * yzoom,
                                    sprite.Width * xzoom, y * yzoom);
                    }
                    else
                    {
                        dc.DrawLine(gridPen,
                                    0, y * yzoom,
                                    sprite.Width * xzoom, y * yzoom);
                    }
                }
            }

            // Draw the selected rectangle
            if (isSelection)
            {
                Point topLeft = new Point((Math.Min(selectionOrigin.X, selectionEnd.X) / xzoom) * xzoom,
                                          (Math.Min(selectionOrigin.Y, selectionEnd.Y) / yzoom) * yzoom);

                Point bottomRight = new Point((Math.Max(selectionOrigin.X, selectionEnd.X) / xzoom + 1) * xzoom - 1,
                                              (Math.Max(selectionOrigin.Y, selectionEnd.Y) / yzoom + 1) * yzoom - 1);

                Size size = new Size(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);

                Rectangle rect = new Rectangle(topLeft, size);

                dc.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.SlateGray)),
                                 rect);

                dc.DrawRectangle(new Pen(Color.LightGray, 3),
                                 rect);
            }

        }



        #region Colour/palette selection

        /// <summary>
        ///  Common method which handles a colour panel being clicked
        /// </summary>
        private void ChangeColour(int index, MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:

                    drawColour = index;
                    break;

                case MouseButtons.Right:

                    eraseColour = index;
                    break;
            }

            // Force current colour panel to be redrawn
            currentColour.Invalidate();
        }

        private void button_colourTransparent_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(255, e.Button);
        }

        private void button_colour0_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(0, e.Button);
        }

        private void button_colour1_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(1, e.Button);
        }

        private void button_colour2_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(2, e.Button);
        }

        private void button_colour3_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(3, e.Button);
        }

        private void button_colour4_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(4, e.Button);
        }

        private void button_colour5_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(5, e.Button);
        }

        private void button_colour6_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(6, e.Button);
        }

        private void button_colour7_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(7, e.Button);
        }

        private void button_colour8_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(8, e.Button);
        }

        private void button_colour9_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(9, e.Button);
        }

        private void button_colour10_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(10, e.Button);
        }

        private void button_colour11_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(11, e.Button);
        }

        private void button_colour12_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(12, e.Button);
        }

        private void button_colour13_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(13, e.Button);
        }

        private void button_colour14_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(14, e.Button);
        }

        private void button_colour15_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeColour(15, e.Button);
        }

        /// <summary>
        ///  Common method which handles palette changes for all 4 colours
        /// </summary>
        private void ChangePalette(int index, MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:

                    sprite.Palette[index] = BeebPalette.GetNextColour(sprite.Palette[index]);
                    break;

                case MouseButtons.Right:

                    sprite.Palette[index] = BeebPalette.GetPreviousColour(sprite.Palette[index]);
                    break;
            }

            colourPanels[index].BackColor = BeebPalette.GetWindowsColour(sprite.Palette[index]);
            currentColour.Invalidate();
            editorPanel.Invalidate();
            spritePanel.Panel.Invalidate();
        }

        private void button_colour0_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(0, e.Button);
        }

        private void button_colour1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(1, e.Button);
        }

        private void button_colour2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(2, e.Button);
        }

        private void button_colour3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(3, e.Button);
        }

        private void button_colour4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(4, e.Button);
        }

        private void button_colour5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(5, e.Button);
        }

        private void button_colour6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(6, e.Button);
        }

        private void button_colour7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(7, e.Button);
        }

        private void button_colour8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(8, e.Button);
        }

        private void button_colour9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(9, e.Button);
        }

        private void button_colour10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(10, e.Button);
        }

        private void button_colour11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(11, e.Button);
        }

        private void button_colour12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(12, e.Button);
        }

        private void button_colour13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(13, e.Button);
        }

        private void button_colour14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(14, e.Button);
        }

        private void button_colour15_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangePalette(15, e.Button);
        }

        /// <summary>
        ///  Paint method for the panel which shows the currently selected colours
        ///  (draw and erase)
        /// </summary>
        private void currentColour_Paint(object sender, PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            Panel panel = sender as Panel;

            Point topLeft = new Point(0, 0);
            Point topRight = new Point(panel.ClientSize.Width, 0);
            Point botLeft = new Point(0, panel.ClientSize.Width);
            Point botRight = new Point(panel.ClientSize.Width, panel.ClientSize.Width);

            Color draw = (drawColour == 255) ? Color.Gray : BeebPalette.GetWindowsColour(sprite.Palette[drawColour]);
            Color erase = (eraseColour == 255) ? Color.Gray : BeebPalette.GetWindowsColour(sprite.Palette[eraseColour]);

            SolidBrush drawBrush = new SolidBrush(draw);
            SolidBrush eraseBrush = new SolidBrush(erase);

            dc.FillPolygon(drawBrush, new Point[] { topLeft, topRight, botLeft });
            dc.FillPolygon(eraseBrush, new Point[] { botLeft, topRight, botRight });
        }

        #endregion


        #region Editing implementation

        /// <summary>
        ///  Event called when the mouse is pressed over the editing window
        /// </summary>
        private void doubleBufferedPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;

            switch (editMode)
            {
                case Mode.Draw:

                    AddHistory();
                    isMouseHeld = true;
                    lastMousePos = e.Location;
                    DoDraw(panel, e);
                    SpriteSheetForm.Instance.IsUnsaved = true;
                    break;

                case Mode.Fill:

                    AddHistory();
                    DoFill(panel, e);
                    SpriteSheetForm.Instance.IsUnsaved = true;
                    break;

                case Mode.InsertRow:

                    AddHistory();
                    DoInsertRow(panel, e);
                    SpriteSheetForm.Instance.IsUnsaved = true;
                    break;

                case Mode.DeleteRow:

                    AddHistory();
                    DoDeleteRow(panel, e);
                    SpriteSheetForm.Instance.IsUnsaved = true;
                    break;

                case Mode.InsertColumn:

                    AddHistory();
                    DoInsertColumn(panel, e);
                    SpriteSheetForm.Instance.IsUnsaved = true;
                    break;

                case Mode.DeleteColumn:

                    AddHistory();
                    DoDeleteColumn(panel, e);
                    SpriteSheetForm.Instance.IsUnsaved = true;
                    break;

                case Mode.Select:

                    if (e.Button == MouseButtons.Left)
                    {
                        isSelection = true;
                        selectionOrigin = e.Location;
                        selectionEnd = e.Location;
                    }
                    break;

                case Mode.Paste:

                    if (e.Button == MouseButtons.Left)
                    {
                        if (SpriteSheetForm.Instance.Clipboard != null)
                        {
                            AddHistory();
                            DoPaste(panel, e);
                            SpriteSheetForm.Instance.IsUnsaved = true;
                        }
                    }
                    break;
            }

        }

        /// <summary>
        ///  Event called when the mouse is moved over the editing window.
        ///  We use this to check for mouse pressed and held, or dragged.
        /// </summary>
        private void doubleBufferedPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;

            switch (editMode)
            {
                case Mode.Draw:

                    if (isMouseHeld)
                    {
                        DoDraw(panel, e);
                        lastMousePos = e.Location;
                    }
                    break;

                case Mode.Select:

                    if (e.Button == MouseButtons.Left)
                    {
                        // This is a horrible hack, because I don't know how to do this properly.
                        // I want the container panel to automatically scroll when the selection box
                        // is dragged off the top or bottom (whilst dragging, out-of-range coordinates
                        // can be obtained, but no automatic scrolling is done).
                        // The problem is that setting the container's AutoScrollPosition seems to
                        // force a MouseMove event again (as effectively the pointer *has* changed
                        // position relative to the panel).  This causes infinite-ish recursion, with
                        // the effect that it scrolls right to the top almost immediately, without even
                        // getting a chance to repaint the window.  So this is so that the MouseMove
                        // event which gets generated is thrown away.
                        if (ignoreNextMouseMoveEvent)
                        {
                            ignoreNextMouseMoveEvent = false;
                            return;
                        }

                        int x = e.Location.X + panel.Location.X;
                        if (x < 0)
                        {
                            editorContainer.AutoScrollPosition = new Point(x - editorContainer.AutoScrollPosition.X,
                                                                           -editorContainer.AutoScrollPosition.Y);
                            ignoreNextMouseMoveEvent = true;
                        }
                        else if (x >= editorContainer.ClientSize.Width)
                        {
                            editorContainer.AutoScrollPosition = new Point(x - editorContainer.ClientSize.Width - editorContainer.AutoScrollPosition.X,
                                                                           -editorContainer.AutoScrollPosition.Y);
                            ignoreNextMouseMoveEvent = true;
                        }

                        int y = e.Location.Y + panel.Location.Y;
                        if (y < 0)
                        {
                            editorContainer.AutoScrollPosition = new Point(-editorContainer.AutoScrollPosition.X,
                                                                           y - editorContainer.AutoScrollPosition.Y);
                            ignoreNextMouseMoveEvent = true;
                        }
                        else if (y >= editorContainer.ClientSize.Height)
                        {
                            editorContainer.AutoScrollPosition = new Point(-editorContainer.AutoScrollPosition.X,
                                                                           y - editorContainer.ClientSize.Height - editorContainer.AutoScrollPosition.Y);
                            ignoreNextMouseMoveEvent = true;
                        }

                        selectionEnd = e.Location;
                        panel.Invalidate();
                    }
                    break;

                case Mode.Paste:

                    if (SpriteSheetForm.Instance.Clipboard != null)
                    {
                        // Plot a preview of the graphics to be pasted over the top of the editing window
                        pasteX = e.Location.X / xzoom;
                        pasteY = e.Location.Y / yzoom;
                        if (pasteX >= 0 && pasteX < sprite.Width &&
                            pasteY >= 0 && pasteY < sprite.Height)
                        {
                            renderPastePreview = true;
                            // TODO: I'm being lazy here. I should only invalidate the portion which has changed,
                            // i.e. the union of the previous and the current bounding rectangle.
                            editorPanel.Invalidate();
                        }

                    }
                    break;
            }
        }

        /// <summary>
        ///  Event called when the mouse is released over the editing window,
        ///  so we can forget about drags.
        /// </summary>
        private void doubleBufferedPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseHeld = false;
        }


        /// <summary>
        ///  Bresenham line implementation
        /// </summary>
        /// <param name="sx">start point of line, x</param>
        /// <param name="sy">start point of line, y</param>
        /// <param name="ex">end point of line, x</param>
        /// <param name="ey">end point of line, y</param>
        /// <returns>List of Points in the line</returns>
        private List<Point> GetPointsOfLine(int sx, int sy, int ex, int ey)
        {
            List<Point> list = new List<Point>();

            // Always go from lower to higher x position
            if (ex < sx)
            {
                // swap start and end points to force that sx < ex
                int temp = ex; ex = sx; sx = temp;
                temp = ey; ey = sy; sy = temp;
            }

            // Always add the initial point to the list
            list.Add(new Point(sx, sy));

            int dx = ex - sx;
            int dy = Math.Abs(ey - sy);
            int diry = Math.Sign(ey - sy);

            if (dx > dy)
            {
                // This is the case of a 'shallow' line, i.e. y doesn't change as often as x
                int s = dx / 2;
                while (sx != ex)
                {
                    sx++;
                    s += dy;
                    if (s >= dx) { s -= dx; sy += diry; }
                    list.Add(new Point(sx, sy));
                }
            }
            else
            {
                // This is the case of a 'steep' line, i.e. x doesn't change as often as y
                int s = dy / 2;
                while (sy != ey)
                {
                    sy += diry;
                    s += dx;
                    if (s >= dy) { s -= dy; sx++; }
                    list.Add(new Point(sx, sy));
                }
            }

            return list;
        }


        /// <summary>
        ///  Called in draw mode to set pixels in the sprite.
        ///  A line is interpolated between the last known mouse position and the one passed in.
        /// </summary>
        /// <param name="panel">Reference to the editor panel</param>
        /// <param name="e">Details of the current mouse click</param>
        private void DoDraw(Panel panel, MouseEventArgs e)
        {
            // Get sprite pixel from mouse coordinate
            int startx = lastMousePos.X / xzoom;
            int starty = lastMousePos.Y / yzoom;
            int endx = e.X / xzoom;
            int endy = e.Y / yzoom;

            byte colour = (e.Button == MouseButtons.Right) ? (byte)eraseColour : (byte)drawColour;

            //// Set pixels in a line between the old and new positions
            //for (int i = 1; i <= 8; i++)
            //{
            //    int x = startx + ((endx - startx) * i + 4) / 8;
            //    int y = starty + ((endy - starty) * i + 4) / 8;
            //    if (x >= 0 && x < sprite.Width && y >= 0 && y < sprite.Height)
            //    {
            //        sprite.Bitmap[x + y * sprite.Width] = colour;
            //    }
            //}

            List<Point> linePoints = GetPointsOfLine(startx, starty, endx, endy);
            foreach (Point p in linePoints)
            {
                if (p.X >= 0 && p.X < sprite.Width && p.Y >= 0 && p.Y < sprite.Height)
                {
                    sprite.Bitmap[p.X + p.Y * sprite.Width] = colour;
                }
            }

            // And force a redraw of the appropriate parts of the editor panel and the preview image
            int left = Math.Min(startx, endx);
            int right = Math.Max(startx, endx) + 1;
            int top = Math.Min(starty, endy);
            int bottom = Math.Max(starty, endy) + 1;

            panel.Invalidate(new Rectangle(left * xzoom,
                                           top * yzoom,
                                           (right - left) * xzoom,
                                           (bottom - top) * yzoom));

            spritePanel.Panel.Invalidate(new Rectangle((left - 1) * pixelSizeX,
                                                       (top - 1) * pixelSizeY,
                                                       (right - left + 2) * pixelSizeX,
                                                       (bottom - top + 2) * pixelSizeY));
        }


        /// <summary>
        ///  Called to do a flood fill
        /// </summary>
        /// <param name="panel">Reference to the editor panel</param>
        /// <param name="e">Current mouse click details</param>
        private void DoFill(Panel panel, MouseEventArgs e)
        {
            // Get sprite pixel coordinates from mouse coordinates
            int x = e.X / xzoom;
            int y = e.Y / yzoom;

            byte colour = (e.Button == MouseButtons.Right) ? (byte)eraseColour : (byte)drawColour;

            // Do the flood fill (recursive method)
            if (x >= 0 && x < sprite.Width && y >= 0 && y < sprite.Height)
            {
                ProcessFill(x, y, colour);
            }

            // And redraw the entire sprites
            panel.Invalidate();
            spritePanel.Panel.Invalidate();
        }


        /// <summary>
        ///  Recursive method which does the flood fill.
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        /// <param name="colour">colour</param>
        private void ProcessFill(int x, int y, byte colour)
        {
            // record which colour it is that we're flood filling over
            byte thisPixel = sprite.Bitmap[x + y * sprite.Width];

            // if the start position is equal to the current colour, we have nothing to do
            if (thisPixel == colour)
            {
                return;
            }

            // look left and right to find the limits of the flood fill for this row
            int leftmost = x;
            int rightmost = x;

            while (leftmost > 0 &&
                   sprite.Bitmap[leftmost - 1 + y * sprite.Width] == thisPixel)
            {
                leftmost--;
            }

            while (rightmost < sprite.Width - 1 &&
                   sprite.Bitmap[rightmost + 1 + y * sprite.Width] == thisPixel)
            {
                rightmost++;
            }

            // and fill in the row
            for (int i = leftmost; i <= rightmost; i++)
            {
                sprite.Bitmap[i + y * sprite.Width] = colour;
            }

            // now for the row above and the row below...
            for (int dir = -1; dir <= 1; dir += 2)
            {
                // ...if we are still within the sprite bounds
                if (y + dir >= 0 && y + dir < sprite.Height)
                {
                    // scan along between the limits of the row we just filled
                    for (x = leftmost; x <= rightmost; x++)
                    {
                        // if we find a pixel we need to fill into...
                        if (sprite.Bitmap[x + (y + dir) * sprite.Width] == thisPixel)
                        {
                            // ...find the end of this section...
                            int thisx = x;
                            while (x < rightmost &&
                                   sprite.Bitmap[x + 1 + (y + dir) * sprite.Width] == thisPixel)
                            {
                                x++;
                            }
                            /// ...and recursively call the fill algorithm
                            ProcessFill(thisx, y + dir, colour);
                        }
                    }
                }
            }
        }


        /// <summary>
        ///  Called when in insert mode to insert a row into the bimap
        /// </summary>
        private void DoInsertRow(Panel panel, MouseEventArgs e)
        {
            int y = e.Y / yzoom;
            if (y < 0 || y >= sprite.Height)
            {
                return;
            }

            // Shunt everything forwards a row in the bitmap
            for (int yy = sprite.Height - 2; yy >= y; yy--)
            {
                for (int x = 0; x < sprite.Width; x++)
                {
                    sprite.Bitmap[x + (yy + 1) * sprite.Width] = sprite.Bitmap[x + yy * sprite.Width];
                }
            }

            // and clear the row we just made
            for (int x = 0; x < sprite.Width; x++)
            {
                sprite.Bitmap[x + y * sprite.Width] = (byte)eraseColour;
            }

            // force redraw
            panel.Invalidate();
            spritePanel.Panel.Invalidate();
        }


        /// <summary>
        ///  Called when in delete mode to delete the clicked row
        /// </summary>
        private void DoDeleteRow(Panel panel, MouseEventArgs e)
        {
            int y = e.Y / yzoom;
            if (y < 0 || y >= sprite.Height)
            {
                return;
            }

            // Shunt everything back a row
            for (int yy = y + 1; yy < sprite.Height; yy++)
            {
                for (int x = 0; x < sprite.Width; x++)
                {
                    sprite.Bitmap[x + (yy - 1) * sprite.Width] = sprite.Bitmap[x + yy * sprite.Width];
                }
            }

            // Clear the last row
            for (int x = 0; x < sprite.Width; x++)
            {
                sprite.Bitmap[x + (sprite.Height - 1) * sprite.Width] = (byte)eraseColour;
            }

            // force redraw
            panel.Invalidate();
            spritePanel.Panel.Invalidate();
        }


        /// <summary>
        ///  Called when in insert mode to insert a column into the bimap
        /// </summary>
        private void DoInsertColumn(Panel panel, MouseEventArgs e)
        {
            int x = e.X / xzoom;
            if (x < 0 || x >= sprite.Width)
            {
                return;
            }

            // Shunt everything forwards a column in the bitmap
            for (int xx = sprite.Width - 2; xx >= x; xx--)
            {
                for (int y = 0; y < sprite.Height; y++)
                {
                    sprite.Bitmap[(xx + 1) + y * sprite.Width] = sprite.Bitmap[xx + y * sprite.Width];
                }
            }

            // and clear the row we just made
            for (int y = 0; y < sprite.Height; y++)
            {
                sprite.Bitmap[x + y * sprite.Width] = (byte)eraseColour;
            }

            // force redraw
            panel.Invalidate();
            spritePanel.Panel.Invalidate();
        }


        /// <summary>
        ///  Called when in delete mode to delete the clicked column
        /// </summary>
        private void DoDeleteColumn(Panel panel, MouseEventArgs e)
        {
            int x = e.X / xzoom;
            if (x < 0 || x >= sprite.Width)
            {
                return;
            }

            // Shunt everything back a row
            for (int xx = x + 1; xx < sprite.Width; xx++)
            {
                for (int y = 0; y < sprite.Height; y++)
                {
                    sprite.Bitmap[(xx - 1) + y * sprite.Width] = sprite.Bitmap[xx + y * sprite.Width];
                }
            }

            // Clear the last row
            for (int y = 0; y < sprite.Height; y++)
            {
                sprite.Bitmap[(sprite.Width) - 1 + y * sprite.Width] = (byte)eraseColour;
            }

            // force redraw
            panel.Invalidate();
            spritePanel.Panel.Invalidate();
        }


        /// <summary>
        ///  Copies the contents of the clipboard to the location specified in the MouseEventArgs
        /// </summary>
        private void DoPaste(Panel panel, MouseEventArgs e)
        {
            pasteX = e.Location.X / xzoom;
            pasteY = e.Location.Y / yzoom;

            int clipboardWidth = SpriteSheetForm.Instance.ClipboardWidth;
            int clipboardHeight = SpriteSheetForm.Instance.ClipboardHeight;
            byte[] clipboard = SpriteSheetForm.Instance.Clipboard;

            int i = 0;
            for (int y = 0; y < clipboardHeight; y++)
            {
                for (int x = 0; x < clipboardWidth; x++)
                {
                    int xx = pasteX + x;
                    int yy = pasteY + y;
                    if (xx >= 0 && xx < sprite.Width &&
                        yy >= 0 && yy < sprite.Height &&
                        clipboard[i] != 255)
                    {
                        sprite.Bitmap[xx + yy * sprite.Width] = clipboard[i];
                    }
                    i++;
                }
            }

            panel.Invalidate();
            spritePanel.Panel.Invalidate();
        }

        #endregion


        #region Edit mode selection

        /// <summary>
        ///  Method which sets a new edit mode, highlights only the current edit mode button,
        ///  and unhighlights the rest
        /// </summary>
        /// <param name="button">Button to be highlighted</param>
        private void SetNewEditMode(ToolStripButton button, Mode mode)
        {
            // If we have changed from select or paste mode, first redraw the editor panel
            // to get rid of any rectangle or paste preview artifacts
            if (editMode == Mode.Select || editMode == Mode.Paste)
            {
                editorPanel.Invalidate();
            }

            button_modeDraw.Checked = false;
            button_modeFill.Checked = false;
            button_modeInsertColumn.Checked = false;
            button_modeDeleteColumn.Checked = false;
            button_modeInsertRow.Checked = false;
            button_modeDeleteRow.Checked = false;
            button_modeSelect.Checked = false;
            button_modePaste.Checked = false;

            button.Checked = true;

            // Changing edit mode always clears the selection
            isSelection = false;

            // Changing edit mode always clears paste preview
            renderPastePreview = false;

            // Set new edit mode
            editMode = mode;
        }


        private void button_modeDraw_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.Draw);
        }

        private void button_modeFill_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.Fill);
        }

        private void button_modeInsertRow_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.InsertRow);
        }

        private void button_modeDeleteRow_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.DeleteRow);
        }

        private void button_modeInsertColumn_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.InsertColumn);
        }

        private void button_modeDeleteColumn_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.DeleteColumn);
        }

        private void button_modeSelect_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.Select);
        }

        private void button_modePaste_Click(object sender, EventArgs e)
        {
            SetNewEditMode(sender as ToolStripButton, Mode.Paste);
        }


        /// <summary>
        ///  The resize doesn't work like a normal edit mode; instead it launches a dialog box
        ///  to prompt the user to enter the new size.
        /// </summary>
        private void resizeIcon_Click(object sender, EventArgs e)
        {
            resizeDialog.SpriteWidth = sprite.Width;
            resizeDialog.SpriteHeight = sprite.Height;
            if (resizeDialog.ShowDialog(this) == DialogResult.OK)
            {
                AddHistory();

                int newWidth = resizeDialog.SpriteWidth;
                int newHeight = resizeDialog.SpriteHeight;

                byte[] newBitmap = new byte[newWidth * newHeight];

                for (int y = 0; y < newHeight; y++)
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        if (x < sprite.Width && y < sprite.Height)
                        {
                            newBitmap[x + y * newWidth] = sprite.Bitmap[x + y * sprite.Width];
                        }
                        else
                        {
                            newBitmap[x + y * newWidth] = (byte)eraseColour;
                        }
                    }
                }

                sprite.Bitmap = newBitmap;
                sprite.Width = newWidth;
                sprite.Height = newHeight;

                spritePanel.ResizePanel();
                ApplyZoomToForm();
            }
        }


        #endregion


        #region Select functionality

        /// <summary>
        ///  Called when Select All is clicked
        /// </summary>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNewEditMode(button_modeSelect, Mode.Select);
            isSelection = true;
            selectionOrigin = new Point(xzoom / 2, yzoom / 2);
            selectionEnd = new Point(sprite.Width * xzoom - xzoom / 2, sprite.Height * yzoom - yzoom / 2);
            editorPanel.Invalidate();
        }


        /// <summary>
        ///  Called when Clear Selection is clicked
        /// </summary>
        private void clearSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSelection = false;
            editorPanel.Invalidate();
        }


        /// <summary>
        ///  Returns the sprite pixel bounds of the selected area
        /// </summary>
        private void GetSelectionBounds(out int startx, out int starty, out int endx, out int endy)
        {
            startx = Math.Max(0, Math.Min(selectionOrigin.X, selectionEnd.X) / xzoom);
            starty = Math.Max(0, Math.Min(selectionOrigin.Y, selectionEnd.Y) / yzoom);
            endx = Math.Min(sprite.Width - 1, Math.Max(selectionOrigin.X, selectionEnd.X) / xzoom);
            endy = Math.Min(sprite.Height - 1, Math.Max(selectionOrigin.Y, selectionEnd.Y) / yzoom);
        }


        /// <summary>
        ///  Helper method which puts the selected area into the clipboard
        /// </summary>
        private void AddToClipboard()
        {
            if (isSelection)
            {
                int startx, starty, endx, endy;
                GetSelectionBounds(out startx, out starty, out endx, out endy);

                int clipboardWidth = endx - startx + 1;
                int clipboardHeight = endy - starty + 1;

                byte[] clipboard = new byte[clipboardWidth * clipboardHeight];

                int i = 0;
                for (int y = starty; y <= endy; y++)
                {
                    for (int x = startx; x <= endx; x++)
                    {
                        clipboard[i] = sprite.Bitmap[x + sprite.Width * y];
                        i++;
                    }
                }

                SpriteSheetForm.Instance.Clipboard = clipboard;
                SpriteSheetForm.Instance.ClipboardWidth = clipboardWidth;
                SpriteSheetForm.Instance.ClipboardHeight = clipboardHeight;
            }
        }


        /// <summary>
        ///  Called when 'Cut' is clicked on the Edit menu
        /// </summary>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelection)
            {
                AddToClipboard();
                AddHistory();

                int startx, starty, endx, endy;
                GetSelectionBounds(out startx, out starty, out endx, out endy);

                for (int y = starty; y <= endy; y++)
                {
                    for (int x = startx; x <= endx; x++)
                    {
                        sprite.Bitmap[x + sprite.Width * y] = (byte)eraseColour;
                    }
                }

                editorPanel.Invalidate();
                spritePanel.Panel.Invalidate();
                SpriteSheetForm.Instance.IsUnsaved = true;
            }
        }


        /// <summary>
        ///  Called when 'Copy' is clicked on the Edit menu
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToClipboard();
        }


        /// <summary>
        ///  Called when 'Paste' is clicked on the Edit menu
        /// </summary>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNewEditMode(button_modePaste, Mode.Paste);
        }


        /// <summary>
        ///  Flips the selected area left-right
        /// </summary>
        private void flipLeftrightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelection)
            {
                int startx, starty, endx, endy;
                GetSelectionBounds(out startx, out starty, out endx, out endy);

                AddHistory();

                for (int y = starty; y <= endy; y++)
                {
                    for (int x = 0; x < (endx - startx + 1) / 2; x++)
                    {
                        byte temp = sprite.Bitmap[startx + x + y * sprite.Width];
                        sprite.Bitmap[startx + x + y * sprite.Width] = sprite.Bitmap[endx - x + y * sprite.Width];
                        sprite.Bitmap[endx - x + y * sprite.Width] = temp;
                    }
                }

                SpriteSheetForm.Instance.IsUnsaved = true;

                editorPanel.Invalidate();
                spritePanel.Panel.Invalidate();
            }

        }


        /// <summary>
        ///  Flips the selected area up-down
        /// </summary>
        private void flipUpdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelection)
            {
                int startx, starty, endx, endy;
                GetSelectionBounds(out startx, out starty, out endx, out endy);

                AddHistory();

                for (int x = startx; x <= endx; x++)
                {
                    for (int y = 0; y < (endy - starty + 1) / 2; y++)
                    {
                        byte temp = sprite.Bitmap[x + (starty + y) * sprite.Width];
                        sprite.Bitmap[x + (starty + y) * sprite.Width] = sprite.Bitmap[x + (endy - y) * sprite.Width];
                        sprite.Bitmap[x + (endy - y) * sprite.Width] = temp;
                    }
                }

                SpriteSheetForm.Instance.IsUnsaved = true;

                editorPanel.Invalidate();
                spritePanel.Panel.Invalidate();
            }
        }

        #endregion


        #region Undo/redo

        private void AddHistory()
        {
            redoBuffer.Clear();
            Snapshot snapshot = new Snapshot();
            snapshot.width = sprite.Width;
            snapshot.height = sprite.Height;
            snapshot.bitmap = (byte[])sprite.Bitmap.Clone();
            undoBuffer.Push(snapshot);
        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoBuffer.Count > 0)
            {
                Snapshot currentState = new Snapshot();
                currentState.width = sprite.Width;
                currentState.height = sprite.Height;
                currentState.bitmap = (byte[])sprite.Bitmap.Clone();
                redoBuffer.Push(currentState);

                Snapshot oldState = undoBuffer.Pop();

                sprite.Bitmap = oldState.bitmap;

                if (oldState.width != sprite.Width || oldState.height != sprite.Height)
                {
                    // do a resize here
                    sprite.Width = oldState.width;
                    sprite.Height = oldState.height;
                    spritePanel.ResizePanel();
                    ApplyZoomToForm();
                }

                editorPanel.Invalidate();
                spritePanel.Panel.Invalidate();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redoBuffer.Count > 0)
            {
                Snapshot currentState = new Snapshot();
                currentState.width = sprite.Width;
                currentState.height = sprite.Height;
                currentState.bitmap = (byte[])sprite.Bitmap.Clone();
                undoBuffer.Push(currentState);

                Snapshot oldState = redoBuffer.Pop();

                sprite.Bitmap = oldState.bitmap;

                if (oldState.width != sprite.Width || oldState.height != sprite.Height)
                {
                    // do a resize here
                    sprite.Width = oldState.width;
                    sprite.Height = oldState.height;
                    spritePanel.ResizePanel();
                    ApplyZoomToForm();
                }

                editorPanel.Invalidate();
                spritePanel.Panel.Invalidate();
            }
        }


        #endregion

        private void tsmiRotateClockwise_Click(object sender, EventArgs e)
        {
            AddHistory();

            sprite.rotateClockWise();
            ApplyZoomToForm();
            editorPanel.Invalidate();
            spritePanel.Panel.Invalidate();
        }

        private void tsmiRotateAntiClockwise_Click(object sender, EventArgs e)
        {
            AddHistory();

            sprite.rotateAntiClockWise();
            ApplyZoomToForm();
            editorPanel.Invalidate();
            spritePanel.Panel.Invalidate();
        }

        /// <summary>
        /// Shift sprite left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShiftLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift(ShiftType.ShiftLeft);
        }

        /// <summary>
        /// Shift sprite right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShiftRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift(ShiftType.ShiftRight);
        }

        /// <summary>
        /// Shift sprite up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShiftUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift(ShiftType.ShiftUp);
        }

        /// <summary>
        /// Shift sprite down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShiftDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift(ShiftType.ShiftDown);
        }

        /// <summary>
        /// Shift sprite in a particular direction
        /// </summary>
        /// <param name="shift"></param>
        public void Shift(ShiftType shift)
        {
            AddHistory();

            switch (shift)
            {
                case ShiftType.ShiftLeft:
                    sprite.ShiftLeft();
                    break;

                case ShiftType.ShiftRight:
                    sprite.ShiftRight();
                    break;

                case ShiftType.ShiftUp:
                    sprite.ShiftUp();
                    break;

                case ShiftType.ShiftDown:
                    sprite.ShiftDown();
                    break;

                default: throw new Exception("Unknown shift.");
            }

            SpriteSheetForm.Instance.IsUnsaved = true;

            editorPanel.Invalidate();
            spritePanel.Panel.Invalidate();

        }

        /// <summary>
        /// Replace one sprite colour with another colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplaceColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceColour replaceColour = new(sprite);

            if (replaceColour.ShowDialog(this) == DialogResult.OK)
            {
                AddHistory();

                sprite.ReplaceColours(replaceColour.OldColour, replaceColour.NewColour);

                SpriteSheetForm.Instance.IsUnsaved = true;

                editorPanel.Invalidate();
                spritePanel.Panel.Invalidate();
            }

        }

        /// <summary>
        /// Make sprite colours negative
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NegativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHistory();
            sprite.Negative(sprite.NumColours);

            SpriteSheetForm.Instance.IsUnsaved = true;

            editorPanel.Invalidate();
            spritePanel.Panel.Invalidate();
        }

        private void SpriteEditor_ResizeEnd(object sender, EventArgs e)
        {
            ApplyZoomToForm();
        }

        /// <summary>
        /// Show / Hide Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowGrid_Click(object sender, EventArgs e)
        {
            SpriteSheetForm.Instance.SpriteSheet.DefaultShowGridLines = ShowGrid.Checked;
            editorPanel.Invalidate();
        }

        /// <summary>
        /// Zoom out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOut_Click(object sender, EventArgs e)
        {
            if (ZoomLevel > ZOOM_MIN_FACTOR)
            {
                Zoom(-ZOOM_INCREMENT);
            }
        }

        /// <summary>
        /// Zoom in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomIn_Click(object sender, EventArgs e)
        {
            if (ZoomLevel < ZOOM_MAX_FACTOR)
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
            ZoomLevel += value;
            ZoomToolStripStatusLabel.Text = String.Format("Zoom x {0}", ZoomLevel.ToString());

            SpriteSheetForm.Instance.SpriteSheet.DefaultZoom = ZoomLevel;
            ApplyZoomToForm();
        }

    }
}
