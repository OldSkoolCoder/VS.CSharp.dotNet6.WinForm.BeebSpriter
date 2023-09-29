namespace BeebSpriter
{
    partial class SpriteEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipLeftrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipUpdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_modeDraw = new System.Windows.Forms.ToolStripButton();
            this.button_modeFill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_modeInsertRow = new System.Windows.Forms.ToolStripButton();
            this.button_modeDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.button_modeInsertColumn = new System.Windows.Forms.ToolStripButton();
            this.button_modeDeleteColumn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button_modeSelect = new System.Windows.Forms.ToolStripButton();
            this.button_modePaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.resizeIcon = new System.Windows.Forms.ToolStripButton();
            this.currentColour = new System.Windows.Forms.Panel();
            this.editorContainer = new System.Windows.Forms.Panel();
            this.button_colourTransparent = new System.Windows.Forms.Panel();
            this.button_colour0 = new System.Windows.Forms.Panel();
            this.button_colour1 = new System.Windows.Forms.Panel();
            this.button_colour3 = new System.Windows.Forms.Panel();
            this.button_colour2 = new System.Windows.Forms.Panel();
            this.button_colour7 = new System.Windows.Forms.Panel();
            this.button_colour6 = new System.Windows.Forms.Panel();
            this.button_colour5 = new System.Windows.Forms.Panel();
            this.button_colour4 = new System.Windows.Forms.Panel();
            this.button_colour15 = new System.Windows.Forms.Panel();
            this.button_colour11 = new System.Windows.Forms.Panel();
            this.button_colour14 = new System.Windows.Forms.Panel();
            this.button_colour10 = new System.Windows.Forms.Panel();
            this.button_colour13 = new System.Windows.Forms.Panel();
            this.button_colour9 = new System.Windows.Forms.Panel();
            this.button_colour12 = new System.Windows.Forms.Panel();
            this.button_colour8 = new System.Windows.Forms.Panel();
            this.horizontalBlockDividersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizNever = new System.Windows.Forms.ToolStripMenuItem();
            this.horizEvery1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horizEvery2 = new System.Windows.Forms.ToolStripMenuItem();
            this.horizEvery3 = new System.Windows.Forms.ToolStripMenuItem();
            this.horizEvery4 = new System.Windows.Forms.ToolStripMenuItem();
            this.showVerticalBlockDividersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertNever = new System.Windows.Forms.ToolStripMenuItem();
            this.vertEvery1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vertEvery2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vertEvery3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vertEvery4 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorPanel = new BeebSpriter.DoubleBufferedPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.editorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.clearSelectionToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearSelectionToolStripMenuItem
            // 
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            this.clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearSelectionToolStripMenuItem.Text = "Clear selection";
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipLeftrightToolStripMenuItem,
            this.flipUpdownToolStripMenuItem});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // flipLeftrightToolStripMenuItem
            // 
            this.flipLeftrightToolStripMenuItem.Name = "flipLeftrightToolStripMenuItem";
            this.flipLeftrightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.flipLeftrightToolStripMenuItem.Text = "Flip left-right";
            this.flipLeftrightToolStripMenuItem.Click += new System.EventHandler(this.flipLeftrightToolStripMenuItem_Click);
            // 
            // flipUpdownToolStripMenuItem
            // 
            this.flipUpdownToolStripMenuItem.Name = "flipUpdownToolStripMenuItem";
            this.flipUpdownToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.flipUpdownToolStripMenuItem.Text = "Flip up-down";
            this.flipUpdownToolStripMenuItem.Click += new System.EventHandler(this.flipUpdownToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGridLinesToolStripMenuItem,
            this.horizontalBlockDividersToolStripMenuItem,
            this.showVerticalBlockDividersToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showGridLinesToolStripMenuItem
            // 
            this.showGridLinesToolStripMenuItem.CheckOnClick = true;
            this.showGridLinesToolStripMenuItem.Name = "showGridLinesToolStripMenuItem";
            this.showGridLinesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.showGridLinesToolStripMenuItem.Text = "Show grid lines";
            this.showGridLinesToolStripMenuItem.Click += new System.EventHandler(this.showGridLinesToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem2.Text = "x4";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem3.Text = "x6";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem4.Text = "x8";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem5.Text = "x10";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_modeDraw,
            this.button_modeFill,
            this.toolStripSeparator1,
            this.button_modeInsertRow,
            this.button_modeDeleteRow,
            this.button_modeInsertColumn,
            this.button_modeDeleteColumn,
            this.toolStripSeparator2,
            this.button_modeSelect,
            this.button_modePaste,
            this.toolStripSeparator3,
            this.resizeIcon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_modeDraw
            // 
            this.button_modeDraw.AutoSize = false;
            this.button_modeDraw.Checked = true;
            this.button_modeDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.button_modeDraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modeDraw.Image = global::BeebSpriter.Properties.Resources.Pencil;
            this.button_modeDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modeDraw.Name = "button_modeDraw";
            this.button_modeDraw.Size = new System.Drawing.Size(24, 24);
            this.button_modeDraw.Text = "Draw";
            this.button_modeDraw.Click += new System.EventHandler(this.button_modeDraw_Click);
            // 
            // button_modeFill
            // 
            this.button_modeFill.AutoSize = false;
            this.button_modeFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modeFill.Image = global::BeebSpriter.Properties.Resources.Fill;
            this.button_modeFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modeFill.Name = "button_modeFill";
            this.button_modeFill.Size = new System.Drawing.Size(24, 24);
            this.button_modeFill.Text = "Fill";
            this.button_modeFill.Click += new System.EventHandler(this.button_modeFill_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // button_modeInsertRow
            // 
            this.button_modeInsertRow.AutoSize = false;
            this.button_modeInsertRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modeInsertRow.Image = global::BeebSpriter.Properties.Resources.Insert;
            this.button_modeInsertRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modeInsertRow.Name = "button_modeInsertRow";
            this.button_modeInsertRow.Size = new System.Drawing.Size(24, 24);
            this.button_modeInsertRow.Text = "Insert row";
            this.button_modeInsertRow.Click += new System.EventHandler(this.button_modeInsertRow_Click);
            // 
            // button_modeDeleteRow
            // 
            this.button_modeDeleteRow.AutoSize = false;
            this.button_modeDeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modeDeleteRow.Image = global::BeebSpriter.Properties.Resources.Delete;
            this.button_modeDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modeDeleteRow.Name = "button_modeDeleteRow";
            this.button_modeDeleteRow.Size = new System.Drawing.Size(24, 24);
            this.button_modeDeleteRow.Text = "Delete row";
            this.button_modeDeleteRow.Click += new System.EventHandler(this.button_modeDeleteRow_Click);
            // 
            // button_modeInsertColumn
            // 
            this.button_modeInsertColumn.AutoSize = false;
            this.button_modeInsertColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modeInsertColumn.Image = global::BeebSpriter.Properties.Resources.InsertColumn;
            this.button_modeInsertColumn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modeInsertColumn.Name = "button_modeInsertColumn";
            this.button_modeInsertColumn.Size = new System.Drawing.Size(24, 24);
            this.button_modeInsertColumn.Text = "Insert column";
            this.button_modeInsertColumn.Click += new System.EventHandler(this.button_modeInsertColumn_Click);
            // 
            // button_modeDeleteColumn
            // 
            this.button_modeDeleteColumn.AutoSize = false;
            this.button_modeDeleteColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modeDeleteColumn.Image = global::BeebSpriter.Properties.Resources.DeleteColumn;
            this.button_modeDeleteColumn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modeDeleteColumn.Name = "button_modeDeleteColumn";
            this.button_modeDeleteColumn.Size = new System.Drawing.Size(24, 24);
            this.button_modeDeleteColumn.Text = "Delete column";
            this.button_modeDeleteColumn.Click += new System.EventHandler(this.button_modeDeleteColumn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // button_modeSelect
            // 
            this.button_modeSelect.AutoSize = false;
            this.button_modeSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modeSelect.Image = global::BeebSpriter.Properties.Resources.Select;
            this.button_modeSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modeSelect.Name = "button_modeSelect";
            this.button_modeSelect.Size = new System.Drawing.Size(24, 24);
            this.button_modeSelect.Text = "Select";
            this.button_modeSelect.Click += new System.EventHandler(this.button_modeSelect_Click);
            // 
            // button_modePaste
            // 
            this.button_modePaste.AutoSize = false;
            this.button_modePaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_modePaste.Image = global::BeebSpriter.Properties.Resources.Paste;
            this.button_modePaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_modePaste.Name = "button_modePaste";
            this.button_modePaste.Size = new System.Drawing.Size(24, 24);
            this.button_modePaste.Text = "Paste";
            this.button_modePaste.Click += new System.EventHandler(this.button_modePaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // resizeIcon
            // 
            this.resizeIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resizeIcon.Image = global::BeebSpriter.Properties.Resources.Resize;
            this.resizeIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resizeIcon.Name = "resizeIcon";
            this.resizeIcon.Size = new System.Drawing.Size(24, 24);
            this.resizeIcon.Text = "Resize";
            this.resizeIcon.Click += new System.EventHandler(this.resizeIcon_Click);
            // 
            // currentColour
            // 
            this.currentColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentColour.Location = new System.Drawing.Point(12, 52);
            this.currentColour.Name = "currentColour";
            this.currentColour.Size = new System.Drawing.Size(55, 53);
            this.currentColour.TabIndex = 2;
            this.currentColour.Paint += new System.Windows.Forms.PaintEventHandler(this.currentColour_Paint);
            // 
            // editorContainer
            // 
            this.editorContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.editorContainer.AutoScroll = true;
            this.editorContainer.BackColor = System.Drawing.Color.Gray;
            this.editorContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editorContainer.Controls.Add(this.editorPanel);
            this.editorContainer.Location = new System.Drawing.Point(73, 52);
            this.editorContainer.Name = "editorContainer";
            this.editorContainer.Size = new System.Drawing.Size(378, 396);
            this.editorContainer.TabIndex = 3;
            this.editorContainer.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // button_colourTransparent
            // 
            this.button_colourTransparent.BackColor = System.Drawing.Color.Gray;
            this.button_colourTransparent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colourTransparent.Location = new System.Drawing.Point(12, 111);
            this.button_colourTransparent.Name = "button_colourTransparent";
            this.button_colourTransparent.Size = new System.Drawing.Size(23, 24);
            this.button_colourTransparent.TabIndex = 4;
            this.button_colourTransparent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colourTransparent_MouseClick);
            // 
            // button_colour0
            // 
            this.button_colour0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour0.Location = new System.Drawing.Point(12, 141);
            this.button_colour0.Name = "button_colour0";
            this.button_colour0.Size = new System.Drawing.Size(23, 24);
            this.button_colour0.TabIndex = 5;
            this.button_colour0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour0_MouseClick);
            this.button_colour0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour0_MouseDoubleClick);
            // 
            // button_colour1
            // 
            this.button_colour1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour1.Location = new System.Drawing.Point(41, 141);
            this.button_colour1.Name = "button_colour1";
            this.button_colour1.Size = new System.Drawing.Size(23, 24);
            this.button_colour1.TabIndex = 6;
            this.button_colour1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour1_MouseClick);
            this.button_colour1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour1_MouseDoubleClick);
            // 
            // button_colour3
            // 
            this.button_colour3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour3.Location = new System.Drawing.Point(41, 171);
            this.button_colour3.Name = "button_colour3";
            this.button_colour3.Size = new System.Drawing.Size(23, 24);
            this.button_colour3.TabIndex = 8;
            this.button_colour3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour3_MouseClick);
            this.button_colour3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour3_MouseDoubleClick);
            // 
            // button_colour2
            // 
            this.button_colour2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour2.Location = new System.Drawing.Point(12, 171);
            this.button_colour2.Name = "button_colour2";
            this.button_colour2.Size = new System.Drawing.Size(23, 24);
            this.button_colour2.TabIndex = 7;
            this.button_colour2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour2_MouseClick);
            this.button_colour2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour2_MouseDoubleClick);
            // 
            // button_colour7
            // 
            this.button_colour7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour7.Location = new System.Drawing.Point(41, 231);
            this.button_colour7.Name = "button_colour7";
            this.button_colour7.Size = new System.Drawing.Size(23, 24);
            this.button_colour7.TabIndex = 12;
            this.button_colour7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour7_MouseClick);
            this.button_colour7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour7_MouseDoubleClick);
            // 
            // button_colour6
            // 
            this.button_colour6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour6.Location = new System.Drawing.Point(12, 231);
            this.button_colour6.Name = "button_colour6";
            this.button_colour6.Size = new System.Drawing.Size(23, 24);
            this.button_colour6.TabIndex = 11;
            this.button_colour6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour6_MouseClick);
            this.button_colour6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour6_MouseDoubleClick);
            // 
            // button_colour5
            // 
            this.button_colour5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour5.Location = new System.Drawing.Point(41, 201);
            this.button_colour5.Name = "button_colour5";
            this.button_colour5.Size = new System.Drawing.Size(23, 24);
            this.button_colour5.TabIndex = 10;
            this.button_colour5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour5_MouseClick);
            this.button_colour5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour5_MouseDoubleClick);
            // 
            // button_colour4
            // 
            this.button_colour4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour4.Location = new System.Drawing.Point(12, 201);
            this.button_colour4.Name = "button_colour4";
            this.button_colour4.Size = new System.Drawing.Size(23, 24);
            this.button_colour4.TabIndex = 9;
            this.button_colour4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour4_MouseClick);
            this.button_colour4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour4_MouseDoubleClick);
            // 
            // button_colour15
            // 
            this.button_colour15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour15.Location = new System.Drawing.Point(41, 351);
            this.button_colour15.Name = "button_colour15";
            this.button_colour15.Size = new System.Drawing.Size(23, 24);
            this.button_colour15.TabIndex = 20;
            this.button_colour15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour15_MouseClick);
            this.button_colour15.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour15_MouseDoubleClick);
            // 
            // button_colour11
            // 
            this.button_colour11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour11.Location = new System.Drawing.Point(41, 291);
            this.button_colour11.Name = "button_colour11";
            this.button_colour11.Size = new System.Drawing.Size(23, 24);
            this.button_colour11.TabIndex = 16;
            this.button_colour11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour11_MouseClick);
            this.button_colour11.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour11_MouseDoubleClick);
            // 
            // button_colour14
            // 
            this.button_colour14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour14.Location = new System.Drawing.Point(12, 351);
            this.button_colour14.Name = "button_colour14";
            this.button_colour14.Size = new System.Drawing.Size(23, 24);
            this.button_colour14.TabIndex = 19;
            this.button_colour14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour14_MouseClick);
            this.button_colour14.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour14_MouseDoubleClick);
            // 
            // button_colour10
            // 
            this.button_colour10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour10.Location = new System.Drawing.Point(12, 291);
            this.button_colour10.Name = "button_colour10";
            this.button_colour10.Size = new System.Drawing.Size(23, 24);
            this.button_colour10.TabIndex = 15;
            this.button_colour10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour10_MouseClick);
            this.button_colour10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour10_MouseDoubleClick);
            // 
            // button_colour13
            // 
            this.button_colour13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour13.Location = new System.Drawing.Point(41, 321);
            this.button_colour13.Name = "button_colour13";
            this.button_colour13.Size = new System.Drawing.Size(23, 24);
            this.button_colour13.TabIndex = 18;
            this.button_colour13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour13_MouseClick);
            this.button_colour13.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour13_MouseDoubleClick);
            // 
            // button_colour9
            // 
            this.button_colour9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour9.Location = new System.Drawing.Point(41, 261);
            this.button_colour9.Name = "button_colour9";
            this.button_colour9.Size = new System.Drawing.Size(23, 24);
            this.button_colour9.TabIndex = 14;
            this.button_colour9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour9_MouseClick);
            this.button_colour9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour9_MouseDoubleClick);
            // 
            // button_colour12
            // 
            this.button_colour12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour12.Location = new System.Drawing.Point(12, 321);
            this.button_colour12.Name = "button_colour12";
            this.button_colour12.Size = new System.Drawing.Size(23, 24);
            this.button_colour12.TabIndex = 17;
            this.button_colour12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour12_MouseClick);
            this.button_colour12.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour12_MouseDoubleClick);
            // 
            // button_colour8
            // 
            this.button_colour8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_colour8.Location = new System.Drawing.Point(12, 261);
            this.button_colour8.Name = "button_colour8";
            this.button_colour8.Size = new System.Drawing.Size(23, 24);
            this.button_colour8.TabIndex = 13;
            this.button_colour8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_colour8_MouseClick);
            this.button_colour8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.button_colour8_MouseDoubleClick);
            // 
            // horizontalBlockDividersToolStripMenuItem
            // 
            this.horizontalBlockDividersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizNever,
            this.horizEvery1,
            this.horizEvery2,
            this.horizEvery3,
            this.horizEvery4});
            this.horizontalBlockDividersToolStripMenuItem.Name = "horizontalBlockDividersToolStripMenuItem";
            this.horizontalBlockDividersToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.horizontalBlockDividersToolStripMenuItem.Text = "Show horizontal block dividers";
            // 
            // horizNever
            // 
            this.horizNever.Checked = true;
            this.horizNever.CheckState = System.Windows.Forms.CheckState.Checked;
            this.horizNever.Name = "horizNever";
            this.horizNever.Size = new System.Drawing.Size(221, 22);
            this.horizNever.Text = "Never";
            this.horizNever.Click += new System.EventHandler(this.horizNever_Click);
            // 
            // horizEvery1
            // 
            this.horizEvery1.Name = "horizEvery1";
            this.horizEvery1.Size = new System.Drawing.Size(221, 22);
            this.horizEvery1.Text = "Every character block";
            this.horizEvery1.Click += new System.EventHandler(this.horizEvery1_Click);
            // 
            // horizEvery2
            // 
            this.horizEvery2.Name = "horizEvery2";
            this.horizEvery2.Size = new System.Drawing.Size(221, 22);
            this.horizEvery2.Text = "Every two character blocks";
            this.horizEvery2.Click += new System.EventHandler(this.horizEvery2_Click);
            // 
            // horizEvery3
            // 
            this.horizEvery3.Name = "horizEvery3";
            this.horizEvery3.Size = new System.Drawing.Size(221, 22);
            this.horizEvery3.Text = "Every three character blocks";
            this.horizEvery3.Click += new System.EventHandler(this.horizEvery3_Click);
            // 
            // horizEvery4
            // 
            this.horizEvery4.Name = "horizEvery4";
            this.horizEvery4.Size = new System.Drawing.Size(221, 22);
            this.horizEvery4.Text = "Every four character blocks";
            this.horizEvery4.Click += new System.EventHandler(this.horizEvery4_Click);
            // 
            // showVerticalBlockDividersToolStripMenuItem
            // 
            this.showVerticalBlockDividersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vertNever,
            this.vertEvery1,
            this.vertEvery2,
            this.vertEvery3,
            this.vertEvery4});
            this.showVerticalBlockDividersToolStripMenuItem.Name = "showVerticalBlockDividersToolStripMenuItem";
            this.showVerticalBlockDividersToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.showVerticalBlockDividersToolStripMenuItem.Text = "Show vertical block dividers";
            // 
            // vertNever
            // 
            this.vertNever.Checked = true;
            this.vertNever.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vertNever.Name = "vertNever";
            this.vertNever.Size = new System.Drawing.Size(212, 22);
            this.vertNever.Text = "Never";
            this.vertNever.Click += new System.EventHandler(this.vertNever_Click);
            // 
            // vertEvery1
            // 
            this.vertEvery1.Name = "vertEvery1";
            this.vertEvery1.Size = new System.Drawing.Size(212, 22);
            this.vertEvery1.Text = "Every character row";
            this.vertEvery1.Click += new System.EventHandler(this.vertEvery1_Click);
            // 
            // vertEvery2
            // 
            this.vertEvery2.Name = "vertEvery2";
            this.vertEvery2.Size = new System.Drawing.Size(212, 22);
            this.vertEvery2.Text = "Every two character rows";
            this.vertEvery2.Click += new System.EventHandler(this.vertEvery2_Click);
            // 
            // vertEvery3
            // 
            this.vertEvery3.Name = "vertEvery3";
            this.vertEvery3.Size = new System.Drawing.Size(212, 22);
            this.vertEvery3.Text = "Every three character rows";
            this.vertEvery3.Click += new System.EventHandler(this.vertEvery3_Click);
            // 
            // vertEvery4
            // 
            this.vertEvery4.Name = "vertEvery4";
            this.vertEvery4.Size = new System.Drawing.Size(212, 22);
            this.vertEvery4.Text = "Every four character rows";
            this.vertEvery4.Click += new System.EventHandler(this.vertEvery4_Click);
            // 
            // editorPanel
            // 
            this.editorPanel.Location = new System.Drawing.Point(0, 0);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(342, 361);
            this.editorPanel.TabIndex = 0;
            this.editorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.doubleBufferedPanel1_Paint);
            this.editorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseDown);
            this.editorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseMove);
            this.editorPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseUp);
            // 
            // SpriteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 460);
            this.Controls.Add(this.button_colour15);
            this.Controls.Add(this.button_colour11);
            this.Controls.Add(this.button_colour14);
            this.Controls.Add(this.button_colour10);
            this.Controls.Add(this.button_colour13);
            this.Controls.Add(this.button_colour9);
            this.Controls.Add(this.button_colour12);
            this.Controls.Add(this.button_colour8);
            this.Controls.Add(this.button_colour7);
            this.Controls.Add(this.button_colour3);
            this.Controls.Add(this.button_colour6);
            this.Controls.Add(this.button_colour2);
            this.Controls.Add(this.button_colour5);
            this.Controls.Add(this.button_colour1);
            this.Controls.Add(this.button_colour4);
            this.Controls.Add(this.button_colour0);
            this.Controls.Add(this.button_colourTransparent);
            this.Controls.Add(this.editorContainer);
            this.Controls.Add(this.currentColour);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpriteEditor";
            this.Text = "SpriteEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpriteEditor_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.editorContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel currentColour;
        private System.Windows.Forms.Panel editorContainer;
        private DoubleBufferedPanel editorPanel;
        private System.Windows.Forms.Panel button_colourTransparent;
        private System.Windows.Forms.Panel button_colour0;
        private System.Windows.Forms.Panel button_colour1;
        private System.Windows.Forms.Panel button_colour3;
        private System.Windows.Forms.Panel button_colour2;
        private System.Windows.Forms.Panel button_colour7;
        private System.Windows.Forms.Panel button_colour6;
        private System.Windows.Forms.Panel button_colour5;
        private System.Windows.Forms.Panel button_colour4;
        private System.Windows.Forms.Panel button_colour15;
        private System.Windows.Forms.Panel button_colour11;
        private System.Windows.Forms.Panel button_colour14;
        private System.Windows.Forms.Panel button_colour10;
        private System.Windows.Forms.Panel button_colour13;
        private System.Windows.Forms.Panel button_colour9;
        private System.Windows.Forms.Panel button_colour12;
        private System.Windows.Forms.Panel button_colour8;
        private System.Windows.Forms.ToolStripButton button_modeDraw;
        private System.Windows.Forms.ToolStripButton button_modeFill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button_modeInsertRow;
        private System.Windows.Forms.ToolStripButton button_modeDeleteRow;
        private System.Windows.Forms.ToolStripButton button_modeInsertColumn;
        private System.Windows.Forms.ToolStripButton button_modeDeleteColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton button_modeSelect;
        private System.Windows.Forms.ToolStripButton button_modePaste;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipLeftrightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipUpdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton resizeIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem horizontalBlockDividersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizNever;
        private System.Windows.Forms.ToolStripMenuItem horizEvery1;
        private System.Windows.Forms.ToolStripMenuItem horizEvery2;
        private System.Windows.Forms.ToolStripMenuItem horizEvery3;
        private System.Windows.Forms.ToolStripMenuItem horizEvery4;
        private System.Windows.Forms.ToolStripMenuItem showVerticalBlockDividersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertNever;
        private System.Windows.Forms.ToolStripMenuItem vertEvery1;
        private System.Windows.Forms.ToolStripMenuItem vertEvery2;
        private System.Windows.Forms.ToolStripMenuItem vertEvery3;
        private System.Windows.Forms.ToolStripMenuItem vertEvery4;
    }
}