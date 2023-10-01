using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using BeebSpriter.Internal;
using System.Security.Policy;

namespace BeebSpriter
{
    public partial class SpriteSheetForm : Form
    {
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

        #endregion


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
        #endregion


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

        #endregion


        #region Form management

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpriteSheetForm_Load(object sender, EventArgs e)
        {
            RecentFiles = new RecentFilesList(RecentFilesToolStripMenuItem, OpenSprites);
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
            saveToolStripMenuItem.Enabled = false;
            saveasToolStripMenuItem.Enabled = false;
            exportSettingsToolStripMenuItem.Enabled = false;
            exportToBeebToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
            toolsToolStripMenuItem.Enabled = false;
        }


        /// <summary>
        ///  Configures child controls to show everything, activate all the menu options, etc
        /// </summary>
        private void SetAsOpened()
        {
            flowLayoutPanel1.Show();
            saveToolStripMenuItem.Enabled = true;
            saveasToolStripMenuItem.Enabled = true;
            exportSettingsToolStripMenuItem.Enabled = true;
            exportToBeebToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;
            toolsToolStripMenuItem.Enabled = true;

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

        #endregion


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

        #endregion


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

        #endregion


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
                spritePanel.ResizePanel(tbZoomLevel.Value);

                IsUnsaved = true;
            }
        }

        #endregion


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

        #endregion


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

            foreach (Sprite sprite in this.spriteSheet.SpriteList)
            {

                animationPreview.Add(sprite);
            }

        }
        #endregion


        #region About dialog

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }

        #endregion


        #region Export related methods

        private void exportToBeebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!spriteSheet.HasSetExportSettings)
            {
                new Export().ShowDialog(this);
            }

            if (exportFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Export();
            }
        }

        private void exportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Export().ShowDialog(this);
        }


        struct Symbol
        {
            public Symbol(string name, int value) { this.name = name; this.value = value; }
            public string name;
            public int value;
        };

        void Export()
        {
            List<Symbol> symbols = new List<Symbol>();

            try
            {
                using (FileStream fs = new FileStream(exportFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    int offset = 0;

                    for (int pass = 0; pass < (spriteSheet.ShouldExportSeparateMask ? 2 : 1); pass++)
                    {
                        foreach (Sprite s in spriteSheet.SpriteList)
                        {
                            int size;
                            ExportSprite(fs, s, pass == 1, out size);

                            if (s.Name != "")
                            {
                                string mangledName = s.Name.Replace(' ', '_');
                                if (pass == 1)
                                {
                                    mangledName += "_mask";
                                }
                                symbols.Add(new Symbol(mangledName + "_offset", offset));
                                symbols.Add(new Symbol(mangledName + "_size", size));
                                symbols.Add(new Symbol(mangledName + "_width", s.Width / SpriteSheet.PixelsPerByte));
                                symbols.Add(new Symbol(mangledName + "_height", s.Height));
                            }
                            offset += size;
                        }
                    }
                }

                if (spriteSheet.ShouldGenerateHeader)
                {
                    using (StreamWriter sw = new StreamWriter(exportFileDialog1.FileName + ".info"))
                    {
                        foreach (Symbol sym in symbols)
                        {
                            string command = spriteSheet.AssemblerSyntax.Replace("{n}", sym.name).Replace("{v}", sym.value.ToString("X"));
                            sw.WriteLine(command);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        void ExportSprite(FileStream fs, Sprite sprite, bool generateMask, out int size)
        {
            // Read constants from sprite sheet
            int pixelsPerByte = spriteSheet.PixelsPerByte;
            int subSpriteWidth = spriteSheet.SubSpriteWidth;
            int subSpriteHeight = spriteSheet.SubSpriteHeight;

            int numPiecesAcross = 1;
            int numPiecesDown = 1;
            int pieceBlocksAcross = (sprite.Width + pixelsPerByte - 1) / pixelsPerByte;
            int pieceHeight = sprite.Height;

            if (spriteSheet.ShouldBreakSprites)
            {
                numPiecesAcross = (pieceBlocksAcross + subSpriteWidth - 1) / subSpriteWidth;
                numPiecesDown = (sprite.Height + subSpriteHeight * 8 - 1) / (subSpriteHeight * 8);
                pieceBlocksAcross = subSpriteWidth;
                pieceHeight = subSpriteHeight * 8;
            }

            size = 0;

            for (int piecey = 0; piecey < numPiecesDown; piecey++)
            {
                for (int piecex = 0; piecex < numPiecesAcross; piecex++)
                {
                    switch (spriteSheet.SpriteLayout)
                    {
                        case SpriteSheet.SpriteDataLayout.RowMajor:

                            for (int y = 0; y < pieceHeight; y += 8)
                            {
                                for (int x = 0; x < pieceBlocksAcross; x++)
                                {
                                    for (int l = 0; l < 8; l++)
                                    {
                                        byte beeb = 0;

                                        for (int p = 0; p < pixelsPerByte; p++)
                                        {
                                            int xx = (piecex * pieceBlocksAcross + x) * pixelsPerByte + p;
                                            int yy = piecey * pieceHeight + y + l;
                                            byte pixel = GetPixel(sprite, xx, yy, generateMask);
                                            beeb |= (byte)(GetBeebColour(pixel) << (pixelsPerByte - 1 - p));
                                        }

                                        fs.WriteByte(beeb);
                                        size++;
                                    }
                                }
                            }

                            break;

                        case SpriteSheet.SpriteDataLayout.ColumnMajor:

                            for (int x = 0; x < pieceBlocksAcross; x++)
                            {
                                for (int y = 0; y < pieceHeight; y++)
                                {
                                    byte beeb = 0;

                                    for (int p = 0; p < pixelsPerByte; p++)
                                    {
                                        int xx = (piecex * pieceBlocksAcross + x) * pixelsPerByte + p;
                                        int yy = piecey * pieceHeight + y;
                                        byte pixel = GetPixel(sprite, xx, yy, generateMask);
                                        beeb |= (byte)(GetBeebColour(pixel) << (pixelsPerByte - 1 - p));
                                    }

                                    fs.WriteByte(beeb);
                                    size++;
                                }
                            }

                            break;

                        case SpriteSheet.SpriteDataLayout.Linear:

                            for (int y = 0; y < pieceHeight; y++)
                            {
                                for (int x = 0; x < pieceBlocksAcross; x++)
                                {
                                    byte beeb = 0;

                                    for (int p = 0; p < pixelsPerByte; p++)
                                    {
                                        int xx = (piecex * pieceBlocksAcross + x) * pixelsPerByte + p;
                                        int yy = piecey * pieceHeight + y;
                                        byte pixel = GetPixel(sprite, xx, yy, generateMask);
                                        beeb |= (byte)(GetBeebColour(pixel) << (pixelsPerByte - 1 - p));
                                    }

                                    fs.WriteByte(beeb);
                                    size++;
                                }
                            }

                            break;
                    }

                }
            }
        }


        byte GetPixel(Sprite sprite, int x, int y, bool generateMask)
        {
            byte pixel = 255;

            if (x >= 0 && x < sprite.Width && y >= 0 && y < sprite.Height)
            {
                pixel = sprite.Bitmap[x + y * sprite.Width];
            }

            if (generateMask)
            {
                return (byte)((pixel == 255) ? spriteSheet.NumColours - 1 : 0);
            }
            else
            {
                return (byte)((pixel == 255) ? 0 : pixel);
            }
        }


        byte GetBeebColour(byte colour)
        {
            byte beebByte = 0;
            for (int i = 0; i < spriteSheet.BitsPerPixel; i++)
            {
                if ((colour & (1 << i)) != 0)
                {
                    beebByte |= (byte)(1 << (i * spriteSheet.PixelsPerByte));
                }
            }

            return beebByte;
        }

        #endregion


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

        private void tbZoomLevel_ValueChanged(object sender, EventArgs e)
        {
            foreach (SpritePanel sp in flowLayoutPanel1.Controls)
            {
                sp.ResizePanel(tbZoomLevel.Value);
                sp.Panel.Invalidate();
            }

            lblZoomLevel.Text = "x " + tbZoomLevel.Value.ToString();
        }

        private void SpriteSheetForm_Load(object sender, EventArgs e)
        {
            lblZoomLevel.Text = "x " + tbZoomLevel.Value.ToString();
        }
    }
}
