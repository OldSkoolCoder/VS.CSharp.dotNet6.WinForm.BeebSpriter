using BeebSpriter.Enum;
using BeebSpriter.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BeebSpriter
{
    public partial class SpriteSheetForm : Form
    {
        /// <summary>
        /// Amount to increment / decrement the zoom level
        /// </summary>
        private const int ZOOM_INCREMENT = 1;

        /// <summary>
        /// Minimum Zoom manification
        /// </summary>
        private const int ZOOM_MIN_FACTOR = 1;

        /// <summary>
        /// Maximum Zoom manification
        /// </summary>
        private const int ZOOM_MAX_FACTOR = 10;

        #region Members

        /// <summary>
        ///  This class is a singleton - here is a reference to the single instance
        /// </summary>
        private static SpriteSheetForm instance;

        /// <summary>
        ///  Instance of a "New sprite" dialog, opened every time a new sprite is created
        /// </summary>
        private NewSpriteDialog newSpriteDialog = new NewSpriteDialog();

        /// <summary>
        ///  Instance of a "Copy sprite" dialog, opened every time a sprite is copied
        /// </summary>
        private CopySpriteDialog copySpriteDialog = new CopySpriteDialog();

        /// <summary>
        ///  Instance of a "Rename sprite" dialog, opened every time a sprite is renamed
        /// </summary>
        private RenameSpriteDialog renameSpriteDialog = new RenameSpriteDialog();

        /// <summary>
        ///  The sprite sheet object contains the actual data which is saved
        /// </summary>
        private SpriteSheet spriteSheet;

        /// <summary>
        /// A list of recent files
        /// </summary>
        private RecentFilesList RecentFiles;

        /// <summary>
        ///  Used in the drag/drop functionality for reordering sprites
        /// </summary>
        private bool ignoreNextDragEvent = false;

        /// <summary>
        ///  Flag which specifies whether we need to save or not
        /// </summary>
        private bool isUnsaved = false;

        /// <summary>
        ///  The cut/copied region is stored here
        /// </summary>
        private byte[] clipboard;

        /// <summary>
        ///  Width of the data in the clipboard
        /// </summary>
        private int clipboardWidth;

        /// <summary>
        ///  Height of the data in the clipboard
        /// </summary>
        private int clipboardHeight;

        /// <summary>
        ///  Reference to the animation preview form, if active
        /// </summary>
        private AnimationPreview animationPreview;

        /// <summary>
        /// Zoom Level property
        /// </summary>
        public int ZoomLevel { get; set; }

        #endregion Members

        #region Properties

        /// <summary>
        ///  Gets the singleton instance of SpriteSheetForm
        /// </summary>
        public static SpriteSheetForm Instance
        {
            get { return instance; }
        }

        /// <summary>
        ///  Gets a reference to the actual sprite sheet data
        /// </summary>
        public SpriteSheet SpriteSheet
        {
            get { return spriteSheet; }
        }

        /// <summary>
        ///  Property which mirrors the isUnsaved member.
        ///  When set, it will update the text of the form title bar.
        /// </summary>
        public bool IsUnsaved
        {
            get { return isUnsaved; }
            set
            {
                bool oldState = isUnsaved;
                isUnsaved = value;
                if (oldState != isUnsaved)
                {
                    SetFormTitle();
                }
            }
        }

        /// <summary>
        ///  Public property for the clipboard bitmap
        /// </summary>
        public byte[] Clipboard
        {
            get { return clipboard; }
            set { clipboard = value; }
        }

        /// <summary>
        ///  Public property for the clipboard width
        /// </summary>
        public int ClipboardWidth
        {
            get { return clipboardWidth; }
            set { clipboardWidth = value; }
        }

        /// <summary>
        ///  Public property for the clipboard height
        /// </summary>
        public int ClipboardHeight
        {
            get { return clipboardHeight; }
            set { clipboardHeight = value; }
        }

        public string ProjectFilename
        {
            get
            {
                if (saveFileDialog1.FileName != "")
                {
                    return Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                }
                else
                {
                    return "NewProject";
                };
            }
        }

        #endregion Properties

        #region Constructor

        /// <summary>
        ///  Constructor
        /// </summary>
        public SpriteSheetForm()
        {
            // Store the single instance of the SpriteSheetForm

            if (instance == null)
            {
                instance = this;
            }
            else
            {
                throw new Exception("Cannot create more than one instance of SpriteSheetForm");
            }

            InitializeComponent();
            SetAsClosed();
        }

        #endregion Constructor

        #region Form management

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpriteSheetForm_Load(object sender, EventArgs e)
        {
            RecentFiles = new RecentFilesList(RecentFilesToolStripMenuItem, OpenSprites);

            ZoomLevel = 1;
            ZoomToolStripStatusLabel.Text = String.Format("Zoom x {0}", ZoomLevel.ToString());

            MyJSON myJSON = new();
            myJSON.LoadJson(RecentFiles);
        }

        /// <summary>
        /// Opens the sprite file from the recent list menu dropdown
        /// </summary>
        /// <param name="filename"></param>
        private void OpenSprites(string filename)
        {
            openFileDialog1.FileName = filename;
            Open();

            // Used for setting title and background colour etc.
            saveFileDialog1.FileName = openFileDialog1.FileName;
            SetAsOpened();
        }

        /// <summary>
        ///  Configures child controls to give the appearance that no document is open
        /// </summary>
        private void SetAsClosed()
        {
            // Set form title
            Text = "BeebSpriter";

            // Hide/disable controls
            flowLayoutPanel1.Hide();

            SetMenusToolbars(false);
        }

        /// <summary>
        ///  Configures child controls to show everything, activate all the menu options, etc
        /// </summary>
        private void SetAsOpened()
        {
            flowLayoutPanel1.Show();
            SetMenusToolbars(true);

            newSpriteDialog.MinSpriteWidth = spriteSheet.PixelsPerByte;
            newSpriteDialog.MaxSpriteWidth = 80 * spriteSheet.PixelsPerByte;
            newSpriteDialog.SpriteWidth = 8;
            newSpriteDialog.MinSpriteHeight = 1;
            newSpriteDialog.MaxSpriteHeight = 256;
            newSpriteDialog.SpriteHeight = 8;

            SetFormTitle();
            ApplyBackgroundColour();
        }

        /// <summary>
        /// Toggle menu items and toolbar icons
        /// </summary>
        /// <param name="value"></param>
        private void SetMenusToolbars(bool value)
        {
            saveToolStripMenuItem.Enabled = value;
            saveasToolStripMenuItem.Enabled = value;
            exportSettingsToolStripMenuItem.Enabled = value;
            exportToBeebToolStripMenuItem.Enabled = value;
            viewToolStripMenuItem.Enabled = value;

            animationPreviewerToolStripMenuItem.Enabled = value;
            editDefaultPaletteToolStripMenuItem.Enabled = value;
            ChangeGfxModeToolStripMenuItem1.Enabled = value;

            SaveToolStripButton.Enabled = value;
            SaveAsToolStripButton.Enabled = value;
            AnimationToolStripButton.Enabled = value;
            DefaultColourToolStripButton.Enabled = value;
            ZoomInToolStripButton.Enabled = value;
            ZoomOutoolStripButton.Enabled = value;
        }

        /// <summary>
        ///  Sets form title according to the currently loaded file, screen mode, and whether there
        ///  is outstanding unsaved work.
        /// </summary>
        private void SetFormTitle()
        {
            string title = "";

            if (isUnsaved)
            {
                title += "* ";
            }

            title += "BeebSpriter";

            if (spriteSheet != null)
            {
                title += " - Mode " + spriteSheet.Mode;
            }

            if (saveFileDialog1.FileName != "")
            {
                title += " [" + saveFileDialog1.FileName + "]";
            }

            Text = title;
        }

        #endregion Form management

        #region File handling

        /// <summary>
        ///  Called when a new Mode 0 sprite sheet is created
        /// </summary>
        private void mode0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSpriteSheet(0);
        }

        /// <summary>
        ///  Called when a new Mode 1 sprite sheet is created
        /// </summary>
        private void mode1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSpriteSheet(1);
        }

        /// <summary>
        ///  Called when a new Mode 2 sprite sheet is created
        /// </summary>
        private void mode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSpriteSheet(2);
        }

        /// <summary>
        ///  Called when a new Mode 4 sprite sheet is created
        /// </summary>
        private void mode4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSpriteSheet(4);
        }

        /// <summary>
        ///  Called when a new Mode 5 sprite sheet is created
        /// </summary>
        private void mode5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSpriteSheet(5);
        }

        /// <summary>
        ///  Common entry point for creating a new sprite sheet
        /// </summary>
        /// <param name="mode">Beeb screen mode to create sprite sheet for</param>
        private void NewSpriteSheet(int mode)
        {
            // First check whether the user wants to lose unsaved work.
            if (IsUnsaved)
            {
                DialogResult result = MessageBox.Show("You have unsaved work. Do you wish to save before creating a new file?",
                                                      "Warning",
                                                      MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    result = saveFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Save();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Clear the cached filename
            saveFileDialog1.FileName = "";
            IsUnsaved = false;

            flowLayoutPanel1.Controls.Clear();
            this.spriteSheet = new SpriteSheet(mode);
            SetAsOpened();
        }

        /// <summary>
        ///  Called when the user clicks "Open file..."
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // First check if the user wishes to save unsaved work
            if (IsUnsaved)
            {
                DialogResult result = MessageBox.Show("You have unsaved work. Do you wish to save before opening a new file?",
                                                      "Warning",
                                                      MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    result = saveFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Save();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Open();
                saveFileDialog1.FileName = openFileDialog1.FileName;
                SetAsOpened();

                RecentFiles.Add(saveFileDialog1.FileName);

                MyJSON jsonSave = new();
                jsonSave.Paths = RecentFiles.Files;
                jsonSave.SaveJson();
            }
        }

        /// <summary>
        ///  Actually opens the specified file
        /// </summary>
        private void Open()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SpriteSheet));
                using (StreamReader stream = new StreamReader(openFileDialog1.FileName))
                {
                    this.spriteSheet = (SpriteSheet)serializer.Deserialize(stream);
                }

                flowLayoutPanel1.Controls.Clear();
                foreach (Sprite s in this.spriteSheet.SpriteList)
                {
                    CreateSpritePanel(s);
                }
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(e.Message, "Error");
            }

            Cursor.Current = Cursors.Default;
            IsUnsaved = false;

            RecentFiles.Add(openFileDialog1.FileName);
        }

        /// <summary>
        ///  Called when the user clicks on "Save as..."
        /// </summary>
        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Save();
            }
        }

        /// <summary>
        ///  Called when the user clicks on "Save"
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName == "")
            {
                // If no filename is cached, ask the user for one
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsUnsaved)
            {
                DialogResult result = MessageBox.Show("You have unsaved work. Do you wish to save before exiting?",
                                                      "Warning",
                                                      MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    result = saveFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Save();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        ///  Actually saves to the specified file
        /// </summary>
        private void Save()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SpriteSheet));
                using (StreamWriter stream = new StreamWriter(saveFileDialog1.FileName))
                {
                    serializer.Serialize(stream, spriteSheet);
                }
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(e.Message, "Error");
            }
            Cursor.Current = Cursors.Default;
            IsUnsaved = false;
        }

        #endregion File handling

        #region Drag and Drop functionality

        /// <summary>
        ///  Event called when an object is dragged onto the sprite sheet
        /// </summary>
        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        ///  Event called when we are dragging an object on top of the sprite sheet.
        /// </summary>
        private void flowLayoutPanel1_DragOver(object sender, DragEventArgs e)
        {
            FlowLayoutPanel flp = sender as FlowLayoutPanel;
            Panel data = (SpritePanel)e.Data.GetData(typeof(SpritePanel));

            Point p = flp.PointToClient(new Point(e.X, e.Y));

            if (ignoreNextDragEvent)
            {
                // This is a hack to stop recursive events caused by the autoscroll yielding a new
                // DragOver condition.
                ignoreNextDragEvent = false;
                return;
            }
            else
            {
                // Auto-scroll up or down if we are dragging towards the edges
                if (p.Y < 24)
                {
                    flp.AutoScrollPosition = new Point(flp.AutoScrollPosition.X, -flp.AutoScrollPosition.Y - 8);
                    ignoreNextDragEvent = true;
                }
                else if (p.Y > flp.ClientSize.Height - 24)
                {
                    flp.AutoScrollPosition = new Point(flp.AutoScrollPosition.X, -flp.AutoScrollPosition.Y + 8);
                    ignoreNextDragEvent = true;
                }
            }

            Control item = flp.GetChildAtPoint(p);
            if (item != null)
            {
                int myIndex = flp.Controls.GetChildIndex(data, false);
                int theirIndex = flp.Controls.GetChildIndex(item, false);
                if (myIndex != theirIndex)
                {
                    flp.Controls.SetChildIndex(data, theirIndex);
                    flp.Invalidate();

                    List<Sprite> list = SpriteSheet.SpriteList;
                    Sprite mySprite = list[myIndex];
                    list.RemoveAt(myIndex);
                    list.Insert(theirIndex, mySprite);
                    IsUnsaved = true;
                }
            }
        }

        #endregion Drag and Drop functionality

        #region Sprite icon handling

        /// <summary>
        ///  This should be called as soon as a new Sprite object is created to attach a
        ///  graphical Windows control to it.
        /// </summary>
        public SpritePanel CreateSpritePanel(Sprite sprite)
        {
            SpritePanel spritePanel = new SpritePanel(sprite);
            sprite.SetSpritePanel(spritePanel);
            spritePanel.ContextMenuStrip = spriteContextMenu;

            flowLayoutPanel1.Controls.Add(spritePanel);
            spritePanel.ResizePanel(ZoomLevel);
            spritePanel.Panel.Invalidate();
            return spritePanel;
        }

        /// <summary>
        ///  This is called whenever 'New sprite' is selected from the context menu
        /// </summary>
        private void newSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newSpriteDialog.ShowDialog() == DialogResult.OK)
            {
                Sprite sprite = new Sprite(newSpriteDialog.SpriteName,
                                           newSpriteDialog.SpriteWidth,
                                           newSpriteDialog.SpriteHeight,
                                           SpriteSheet.DefaultPalette);

                // Very important to call this on a new Sprite
                // (it creates the graphical control which represents the sprite)
                CreateSpritePanel(sprite);

                // Add the sprite to the sprite sheet
                SpriteSheet.SpriteList.Add(sprite);

                IsUnsaved = true;
            }
        }

        /// <summary>
        ///  This is called whenever 'Delete' is selected from the sprite context menu
        /// </summary>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is the rather long-winded way to get the object which created the context menu
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            SpritePanel spritePanel = menu.SourceControl as SpritePanel;

            // If this sprite has an editor form open, forcibly close it and null its reference
            if (spritePanel.EditorForm != null)
            {
                spritePanel.EditorForm.Close();
                spritePanel.ForgetEditorForm();
            }

            // Remove the sprite from the animation preview if it's there
            if (animationPreview != null)
            {
                animationPreview.Remove(spritePanel.Sprite);
            }

            // Remove GUI control first of all
            flowLayoutPanel1.Controls.Remove(spritePanel);

            // Then remove Sprite object from the sprite sheet
            SpriteSheet.SpriteList.Remove(spritePanel.Sprite);

            // ...and finally kill the reference from the Sprite to the SpritePanel
            // (which hopefully should let the GC come along and clean everything up...)
            spritePanel.Sprite.SetSpritePanel(null);

            IsUnsaved = true;
        }

        /// <summary>
        ///  Called whenever 'Make copy...' is selected from the sprite context menu
        /// </summary>
        private void addCopyOfThisSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            SpritePanel spritePanel = menu.SourceControl as SpritePanel;

            copySpriteDialog.SpriteName = spritePanel.Sprite.Name;

            if (copySpriteDialog.ShowDialog() == DialogResult.OK)
            {
                Sprite sprite = new Sprite(copySpriteDialog.SpriteName,
                                           spritePanel.Sprite);

                // Create the graphical representation of the sprite
                CreateSpritePanel(sprite);

                // and add it into the sprite sheet
                SpriteSheet.SpriteList.Add(sprite);

                IsUnsaved = true;
            }
        }

        /// <summary>
        ///  Called whenever 'Rename' is selected from the sprite context menu
        /// </summary>
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            SpritePanel spritePanel = menu.SourceControl as SpritePanel;

            renameSpriteDialog.SpriteName = spritePanel.Sprite.Name;

            if (renameSpriteDialog.ShowDialog() == DialogResult.OK)
            {
                spritePanel.Sprite.Name = renameSpriteDialog.SpriteName;
                spritePanel.Label.Text = renameSpriteDialog.SpriteName;
                //spritePanel.ResizePanel(tbZoomLevel.Value);

                IsUnsaved = true;
            }
        }

        #endregion Sprite icon handling

        #region Background colour

        public Color GetBackgroundColour()
        {
            switch (spriteSheet.BackgroundColour)
            {
                case SpriteSheet.BackColour.Transparent:
                    return SystemColors.Control;

                case SpriteSheet.BackColour.Black:
                    return Color.FromArgb(0, 0, 0);

                case SpriteSheet.BackColour.Red:
                    return Color.FromArgb(255, 0, 0);

                case SpriteSheet.BackColour.Green:
                    return Color.FromArgb(0, 255, 0);

                case SpriteSheet.BackColour.Yellow:
                    return Color.FromArgb(255, 255, 0);

                case SpriteSheet.BackColour.Blue:
                    return Color.FromArgb(0, 0, 255);

                case SpriteSheet.BackColour.Magenta:
                    return Color.FromArgb(255, 0, 255);

                case SpriteSheet.BackColour.Cyan:
                    return Color.FromArgb(0, 255, 255);

                case SpriteSheet.BackColour.White:
                    return Color.FromArgb(255, 255, 255);

                default:
                    throw new Exception("Unexpected colour encountered");
            }
        }

        public Color ChooseBestTextColour()
        {
            switch (spriteSheet.BackgroundColour)
            {
                case SpriteSheet.BackColour.Black:
                case SpriteSheet.BackColour.Blue:
                    return Color.White;

                default:
                    return Color.Black;
            }
        }

        private void ApplyBackgroundColour()
        {
            // Uncheck all the menu items
            transparentToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            magentaToolStripMenuItem.Checked = false;
            cyanToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;

            // Set the background colour of the panel
            Color color = GetBackgroundColour();
            Color textColour = ChooseBestTextColour();
            flowLayoutPanel1.BackColor = color;

            // Change the text to a colour so that it's legible
            foreach (SpritePanel sp in flowLayoutPanel1.Controls)
            {
                sp.Label.ForeColor = textColour;
                sp.Panel.Invalidate();
            }

            // Change the animation preview background colour if the window is open
            if (animationPreview != null)
            {
                animationPreview.ApplyBackgroundColour();
            }

            // Tick the appropriate item in the menu
            switch (spriteSheet.BackgroundColour)
            {
                case SpriteSheet.BackColour.Transparent:
                    transparentToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.Black:
                    blackToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.Red:
                    redToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.Green:
                    greenToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.Yellow:
                    yellowToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.Blue:
                    blueToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.Magenta:
                    magentaToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.Cyan:
                    cyanToolStripMenuItem.Checked = true;
                    break;

                case SpriteSheet.BackColour.White:
                    whiteToolStripMenuItem.Checked = true;
                    break;
            }
        }

        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Transparent;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Black;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Red;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Green;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Yellow;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Blue;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Magenta;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.Cyan;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteSheet.BackgroundColour = SpriteSheet.BackColour.White;
            ApplyBackgroundColour();
            IsUnsaved = true;
        }

        #endregion Background colour

        #region Animation preview

        /// <summary>
        ///  Called when the user clicks Animation preview from the Tools menu
        /// </summary>
        private void animationPreviewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAnimationPreview();
        }

        /// <summary>
        ///  Opens the animation preview form
        /// </summary>
        public void OpenAnimationPreview()
        {
            if (animationPreview == null)
            {
                animationPreview = new AnimationPreview();
                animationPreview.Show();
                //addToAnimationPreviewToolStripMenuItem.Enabled = true;
            }
            else
            {
                animationPreview.Focus();
            }
        }

        public void CloseAnimationPreview()
        {
            animationPreview = null;
            //addToAnimationPreviewToolStripMenuItem.Enabled = false;
        }

        private void addToAnimationPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animationPreview == null)
            {
                OpenAnimationPreview();
                //addToAnimationPreviewToolStripMenuItem_Click(sender, e);
            }
            // This is the rather long-winded way to get the object which created the context menu
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            SpritePanel spritePanel = menu.SourceControl as SpritePanel;

            animationPreview.Add(spritePanel.Sprite);
        }

        private void addAllSpritesToAnimationPreviewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animationPreview == null)
            {
                OpenAnimationPreview();
                //addToAnimationPreviewToolStripMenuItem_Click(sender, e);
            }
            // This is the rather long-winded way to get the object which created the context menu
            //ToolStripItem menuItem = sender as ToolStripItem;
            //ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            //SpritePanel spritePanel = menu.SourceControl as SpritePanel;

            animationPreview.ClearAnimationList();
            foreach (Sprite sprite in this.spriteSheet.SpriteList)
            {
                animationPreview.Add(sprite);
            }
        }

        #endregion Animation preview

        #region About dialog

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }

        #endregion About dialog

        #region Export related methods

        private void exportToBeebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!spriteSheet.HasSetExportSettings)
            {
                new Export().ShowDialog(this);
            }

            if (exportFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Export();
                SpriteSheet.Export(exportFileDialog1.FileName);
            }
        }

        private void exportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Export().ShowDialog(this);
        }

        #endregion Export related methods

        private void editDefaultPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DefaultPalette().ShowDialog(this);
        }

        private void SpriteSheetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUnsaved)
            {
                DialogResult result = MessageBox.Show("You have unsaved work. Do you wish to save before closing?",
                                                      "Warning",
                                                      MessageBoxButtons.YesNoCancel);

                if (result != DialogResult.No)
                {
                    // Here's how we cancel the window closing
                    e.Cancel = true;

                    if (result == DialogResult.Yes)
                    {
                        // If we want to save, do it here
                        result = saveFileDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Save();
                        }
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOutoolStripButton_Click(object sender, EventArgs e)
        {
            if (ZoomLevel > ZOOM_MIN_FACTOR)
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
            if (ZoomLevel < ZOOM_MAX_FACTOR)
            {
                Zoom(+ZOOM_INCREMENT);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        private void Zoom(int value)
        {
            ZoomLevel += value;
            ZoomToolStripStatusLabel.Text = String.Format("Zoom x {0}", ZoomLevel.ToString());

            foreach (SpritePanel sp in flowLayoutPanel1.Controls)
            {
                sp.ResizePanel(ZoomLevel);
                sp.Panel.Invalidate();
            }
        }

        /// <summary>
        /// Change Gfx Mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeGfxModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGfxMode gfxMode = new((GfxModeType)spriteSheet.Mode);

            if (gfxMode.ShowDialog() == DialogResult.OK)
            {
                if (SpriteSheet.Mode != gfxMode.SelectedMode)
                {
                    spriteSheet.ChangeMode(gfxMode.SelectedMode);

                    // Refresh each sprite in the panel
                    foreach (SpritePanel sp in flowLayoutPanel1.Controls)
                    {
                        sp.Panel.Invalidate();
                    }

                    IsUnsaved = true;

                    SetFormTitle();
                }
            }
        }

        /// <summary>
        /// Import sprites from Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportImage importImage = new();

            if (importImage.ShowDialog() == DialogResult.OK)
            {
                if (spriteSheet != null && spriteSheet.Mode == importImage.Mode)
                {
                    DialogResult result = MessageBox.Show("Do you want to merge the new sprites?",
                                                      "Warning",
                                                      MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        NewSpriteSheet(importImage.Mode);
                    }
                }
                else
                {
                    NewSpriteSheet(importImage.Mode);
                }

                int index = 1;
                foreach (Rectangle rect in importImage.SpriteList)
                {
                    string spriteName = String.Format("Sprite_{0}", index);

                    Sprite sprite = importImage.ExtractSprite(spriteName, rect);

                    CreateSpritePanel(sprite);

                    SpriteSheet.SpriteList.Add(sprite);

                    index++;
                }

                IsUnsaved = true;
                SetAsOpened();
            }
        }

        private void tsmiAddToNewAnimationSet_Click(object sender, EventArgs e)
        {
            if (animationPreview == null)
            {
                OpenAnimationPreview();
                //addToAnimationPreviewToolStripMenuItem_Click(sender, e);
            }
            // This is the rather long-winded way to get the object which created the context menu
            //ToolStripItem menuItem = sender as ToolStripItem;
            //ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            //SpritePanel spritePanel = menu.SourceControl as SpritePanel;

            animationPreview.ClearAnimationList();

            // This is the rather long-winded way to get the object which created the context menu
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            SpritePanel spritePanel = menu.SourceControl as SpritePanel;

            animationPreview.Add(spritePanel.Sprite);
        }

        /// <summary>
        /// Import sprites from SpritePad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportSpritePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Open SpritePad File",
                Filter = "SpritePad C64 project files|*.spd",
                DefaultExt = "spd"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SpritePad spritePad = new();

                // Load the SpritePad data into the SpritePad class
                spritePad.Generate(openFileDialog.FileName);

                // Use Mode 2
                NewSpriteSheet(2);

                // Create Default 16 colour palette
                BeebPalette palette = new(16);

                // Convert the SpritePad data into BeebSpriter spritesheet
                for (int spriteNum = 0; spriteNum < spritePad.Data.Count; spriteNum++)
                {
                    string spriteName = String.Format("Sprite_{0}", spriteNum + 1);

                    // Generate the BeebSpriter sprites from the SpritePad data
                    Sprite sprite = new(spriteName, 12, 21, palette.BeebColours)
                    {
                        Bitmap = spritePad.ToBytes(spriteNum)
                    };

                    CreateSpritePanel(sprite);

                    SpriteSheet.SpriteList.Add(sprite);
                }

                // Add a RichTextBox to the form and un-comment the below function
                // to see the data from the SpritePad
                // Useful for debugging purposes
                // spritePad.ShowData(RichTextBox1);

                IsUnsaved = true;
                SetAsOpened();
            }
        }
    }
}