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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            flipLeftrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            flipUpdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            ShiftLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ShiftRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ShiftUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ShiftDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showGridLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            horizontalBlockDividersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            horizNever = new System.Windows.Forms.ToolStripMenuItem();
            horizEvery1 = new System.Windows.Forms.ToolStripMenuItem();
            horizEvery2 = new System.Windows.Forms.ToolStripMenuItem();
            horizEvery3 = new System.Windows.Forms.ToolStripMenuItem();
            horizEvery4 = new System.Windows.Forms.ToolStripMenuItem();
            showVerticalBlockDividersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vertNever = new System.Windows.Forms.ToolStripMenuItem();
            vertEvery1 = new System.Windows.Forms.ToolStripMenuItem();
            vertEvery2 = new System.Windows.Forms.ToolStripMenuItem();
            vertEvery3 = new System.Windows.Forms.ToolStripMenuItem();
            vertEvery4 = new System.Windows.Forms.ToolStripMenuItem();
            zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            button_modeDraw = new System.Windows.Forms.ToolStripButton();
            button_modeFill = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            button_modeInsertRow = new System.Windows.Forms.ToolStripButton();
            button_modeDeleteRow = new System.Windows.Forms.ToolStripButton();
            button_modeInsertColumn = new System.Windows.Forms.ToolStripButton();
            button_modeDeleteColumn = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            button_modeSelect = new System.Windows.Forms.ToolStripButton();
            button_modePaste = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            resizeIcon = new System.Windows.Forms.ToolStripButton();
            currentColour = new System.Windows.Forms.Panel();
            editorContainer = new System.Windows.Forms.Panel();
            editorPanel = new DoubleBufferedPanel();
            button_colourTransparent = new System.Windows.Forms.Panel();
            button_colour0 = new System.Windows.Forms.Panel();
            button_colour1 = new System.Windows.Forms.Panel();
            button_colour3 = new System.Windows.Forms.Panel();
            button_colour2 = new System.Windows.Forms.Panel();
            button_colour7 = new System.Windows.Forms.Panel();
            button_colour6 = new System.Windows.Forms.Panel();
            button_colour5 = new System.Windows.Forms.Panel();
            button_colour4 = new System.Windows.Forms.Panel();
            button_colour15 = new System.Windows.Forms.Panel();
            button_colour11 = new System.Windows.Forms.Panel();
            button_colour14 = new System.Windows.Forms.Panel();
            button_colour10 = new System.Windows.Forms.Panel();
            button_colour13 = new System.Windows.Forms.Panel();
            button_colour9 = new System.Windows.Forms.Panel();
            button_colour12 = new System.Windows.Forms.Panel();
            button_colour8 = new System.Windows.Forms.Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            editorContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(540, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectAllToolStripMenuItem, clearSelectionToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectionToolStripMenuItem, toolStripMenuItem1, undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // clearSelectionToolStripMenuItem
            // 
            clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            clearSelectionToolStripMenuItem.Text = "Clear selection";
            clearSelectionToolStripMenuItem.Click += clearSelectionToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // selectionToolStripMenuItem
            // 
            selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { flipLeftrightToolStripMenuItem, flipUpdownToolStripMenuItem, toolStripMenuItem6, ShiftLeftToolStripMenuItem, ShiftRightToolStripMenuItem, ShiftUpToolStripMenuItem, ShiftDownToolStripMenuItem });
            selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            selectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            selectionToolStripMenuItem.Text = "Selection";
            // 
            // flipLeftrightToolStripMenuItem
            // 
            flipLeftrightToolStripMenuItem.Name = "flipLeftrightToolStripMenuItem";
            flipLeftrightToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            flipLeftrightToolStripMenuItem.Text = "Flip left-right";
            flipLeftrightToolStripMenuItem.Click += flipLeftrightToolStripMenuItem_Click;
            // 
            // flipUpdownToolStripMenuItem
            // 
            flipUpdownToolStripMenuItem.Name = "flipUpdownToolStripMenuItem";
            flipUpdownToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            flipUpdownToolStripMenuItem.Text = "Flip up-down";
            flipUpdownToolStripMenuItem.Click += flipUpdownToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new System.Drawing.Size(217, 6);
            // 
            // ShiftLeftToolStripMenuItem
            // 
            ShiftLeftToolStripMenuItem.Image = Properties.Resources.ShiftLeft;
            ShiftLeftToolStripMenuItem.Name = "ShiftLeftToolStripMenuItem";
            ShiftLeftToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left;
            ShiftLeftToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            ShiftLeftToolStripMenuItem.Text = "Shift Left";
            ShiftLeftToolStripMenuItem.Click += ShiftLeftToolStripMenuItem_Click;
            // 
            // ShiftRightToolStripMenuItem
            // 
            ShiftRightToolStripMenuItem.Image = Properties.Resources.ShiftRight;
            ShiftRightToolStripMenuItem.Name = "ShiftRightToolStripMenuItem";
            ShiftRightToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right;
            ShiftRightToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            ShiftRightToolStripMenuItem.Text = "Shift Right";
            ShiftRightToolStripMenuItem.Click += ShiftRightToolStripMenuItem_Click;
            // 
            // ShiftUpToolStripMenuItem
            // 
            ShiftUpToolStripMenuItem.Image = Properties.Resources.ShiftUp;
            ShiftUpToolStripMenuItem.Name = "ShiftUpToolStripMenuItem";
            ShiftUpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up;
            ShiftUpToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            ShiftUpToolStripMenuItem.Text = "Shift Up";
            ShiftUpToolStripMenuItem.Click += ShiftUpToolStripMenuItem_Click;
            // 
            // ShiftDownToolStripMenuItem
            // 
            ShiftDownToolStripMenuItem.Image = Properties.Resources.ShiftDown;
            ShiftDownToolStripMenuItem.Name = "ShiftDownToolStripMenuItem";
            ShiftDownToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down;
            ShiftDownToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            ShiftDownToolStripMenuItem.Text = "Shift Down";
            ShiftDownToolStripMenuItem.Click += ShiftDownToolStripMenuItem_Click;
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRotateClockwise,
            this.tsmiRotateAntiClockwise});
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transformToolStripMenuItem.Text = "Transform";
            // 
            // tsmiRotateClockwise
            // 
            this.tsmiRotateClockwise.Name = "tsmiRotateClockwise";
            this.tsmiRotateClockwise.Size = new System.Drawing.Size(186, 22);
            this.tsmiRotateClockwise.Text = "Rotate Clockwise";
            this.tsmiRotateClockwise.Click += new System.EventHandler(this.tsmiRotateClockwise_Click);
            // 
            // tsmiRotateAntiClockwise
            // 
            this.tsmiRotateAntiClockwise.Name = "tsmiRotateAntiClockwise";
            this.tsmiRotateAntiClockwise.Size = new System.Drawing.Size(186, 22);
            this.tsmiRotateAntiClockwise.Text = "Rotate AntiClockwise";
            this.tsmiRotateAntiClockwise.Click += new System.EventHandler(this.tsmiRotateAntiClockwise_Click);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { showGridLinesToolStripMenuItem, horizontalBlockDividersToolStripMenuItem, showVerticalBlockDividersToolStripMenuItem, zoomToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // showGridLinesToolStripMenuItem
            // 
            showGridLinesToolStripMenuItem.CheckOnClick = true;
            showGridLinesToolStripMenuItem.Name = "showGridLinesToolStripMenuItem";
            showGridLinesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            showGridLinesToolStripMenuItem.Text = "Show grid lines";
            showGridLinesToolStripMenuItem.Click += showGridLinesToolStripMenuItem_Click;
            // 
            // horizontalBlockDividersToolStripMenuItem
            // 
            horizontalBlockDividersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { horizNever, horizEvery1, horizEvery2, horizEvery3, horizEvery4 });
            horizontalBlockDividersToolStripMenuItem.Name = "horizontalBlockDividersToolStripMenuItem";
            horizontalBlockDividersToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            horizontalBlockDividersToolStripMenuItem.Text = "Show horizontal block dividers";
            // 
            // horizNever
            // 
            horizNever.Checked = true;
            horizNever.CheckState = System.Windows.Forms.CheckState.Checked;
            horizNever.Name = "horizNever";
            horizNever.Size = new System.Drawing.Size(221, 22);
            horizNever.Text = "Never";
            horizNever.Click += horizNever_Click;
            // 
            // horizEvery1
            // 
            horizEvery1.Name = "horizEvery1";
            horizEvery1.Size = new System.Drawing.Size(221, 22);
            horizEvery1.Text = "Every character block";
            horizEvery1.Click += horizEvery1_Click;
            // 
            // horizEvery2
            // 
            horizEvery2.Name = "horizEvery2";
            horizEvery2.Size = new System.Drawing.Size(221, 22);
            horizEvery2.Text = "Every two character blocks";
            horizEvery2.Click += horizEvery2_Click;
            // 
            // horizEvery3
            // 
            horizEvery3.Name = "horizEvery3";
            horizEvery3.Size = new System.Drawing.Size(221, 22);
            horizEvery3.Text = "Every three character blocks";
            horizEvery3.Click += horizEvery3_Click;
            // 
            // horizEvery4
            // 
            horizEvery4.Name = "horizEvery4";
            horizEvery4.Size = new System.Drawing.Size(221, 22);
            horizEvery4.Text = "Every four character blocks";
            horizEvery4.Click += horizEvery4_Click;
            // 
            // showVerticalBlockDividersToolStripMenuItem
            // 
            showVerticalBlockDividersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { vertNever, vertEvery1, vertEvery2, vertEvery3, vertEvery4 });
            showVerticalBlockDividersToolStripMenuItem.Name = "showVerticalBlockDividersToolStripMenuItem";
            showVerticalBlockDividersToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            showVerticalBlockDividersToolStripMenuItem.Text = "Show vertical block dividers";
            // 
            // vertNever
            // 
            vertNever.Checked = true;
            vertNever.CheckState = System.Windows.Forms.CheckState.Checked;
            vertNever.Name = "vertNever";
            vertNever.Size = new System.Drawing.Size(212, 22);
            vertNever.Text = "Never";
            vertNever.Click += vertNever_Click;
            // 
            // vertEvery1
            // 
            vertEvery1.Name = "vertEvery1";
            vertEvery1.Size = new System.Drawing.Size(212, 22);
            vertEvery1.Text = "Every character row";
            vertEvery1.Click += vertEvery1_Click;
            // 
            // vertEvery2
            // 
            vertEvery2.Name = "vertEvery2";
            vertEvery2.Size = new System.Drawing.Size(212, 22);
            vertEvery2.Text = "Every two character rows";
            vertEvery2.Click += vertEvery2_Click;
            // 
            // vertEvery3
            // 
            vertEvery3.Name = "vertEvery3";
            vertEvery3.Size = new System.Drawing.Size(212, 22);
            vertEvery3.Text = "Every three character rows";
            vertEvery3.Click += vertEvery3_Click;
            // 
            // vertEvery4
            // 
            vertEvery4.Name = "vertEvery4";
            vertEvery4.Size = new System.Drawing.Size(212, 22);
            vertEvery4.Text = "Every four character rows";
            vertEvery4.Click += vertEvery4_Click;
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
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            toolStripMenuItem2.Text = "x4";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            toolStripMenuItem3.Text = "x6";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
            toolStripMenuItem4.Text = "x8";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new System.Drawing.Size(92, 22);
            toolStripMenuItem5.Text = "x10";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { button_modeDraw, button_modeFill, toolStripSeparator1, button_modeInsertRow, button_modeDeleteRow, button_modeInsertColumn, button_modeDeleteColumn, toolStripSeparator2, button_modeSelect, button_modePaste, toolStripSeparator3, resizeIcon });
            toolStrip1.Location = new System.Drawing.Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(540, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // button_modeDraw
            // 
            button_modeDraw.AutoSize = false;
            button_modeDraw.Checked = true;
            button_modeDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            button_modeDraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modeDraw.Image = Properties.Resources.Pencil;
            button_modeDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modeDraw.Name = "button_modeDraw";
            button_modeDraw.Size = new System.Drawing.Size(24, 24);
            button_modeDraw.Text = "Draw";
            button_modeDraw.Click += button_modeDraw_Click;
            // 
            // button_modeFill
            // 
            button_modeFill.AutoSize = false;
            button_modeFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modeFill.Image = Properties.Resources.Fill;
            button_modeFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modeFill.Name = "button_modeFill";
            button_modeFill.Size = new System.Drawing.Size(24, 24);
            button_modeFill.Text = "Fill";
            button_modeFill.Click += button_modeFill_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // button_modeInsertRow
            // 
            button_modeInsertRow.AutoSize = false;
            button_modeInsertRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modeInsertRow.Image = Properties.Resources.Insert;
            button_modeInsertRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modeInsertRow.Name = "button_modeInsertRow";
            button_modeInsertRow.Size = new System.Drawing.Size(24, 24);
            button_modeInsertRow.Text = "Insert row";
            button_modeInsertRow.Click += button_modeInsertRow_Click;
            // 
            // button_modeDeleteRow
            // 
            button_modeDeleteRow.AutoSize = false;
            button_modeDeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modeDeleteRow.Image = Properties.Resources.Delete;
            button_modeDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modeDeleteRow.Name = "button_modeDeleteRow";
            button_modeDeleteRow.Size = new System.Drawing.Size(24, 24);
            button_modeDeleteRow.Text = "Delete row";
            button_modeDeleteRow.Click += button_modeDeleteRow_Click;
            // 
            // button_modeInsertColumn
            // 
            button_modeInsertColumn.AutoSize = false;
            button_modeInsertColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modeInsertColumn.Image = Properties.Resources.InsertColumn;
            button_modeInsertColumn.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modeInsertColumn.Name = "button_modeInsertColumn";
            button_modeInsertColumn.Size = new System.Drawing.Size(24, 24);
            button_modeInsertColumn.Text = "Insert column";
            button_modeInsertColumn.Click += button_modeInsertColumn_Click;
            // 
            // button_modeDeleteColumn
            // 
            button_modeDeleteColumn.AutoSize = false;
            button_modeDeleteColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modeDeleteColumn.Image = Properties.Resources.DeleteColumn;
            button_modeDeleteColumn.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modeDeleteColumn.Name = "button_modeDeleteColumn";
            button_modeDeleteColumn.Size = new System.Drawing.Size(24, 24);
            button_modeDeleteColumn.Text = "Delete column";
            button_modeDeleteColumn.Click += button_modeDeleteColumn_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // button_modeSelect
            // 
            button_modeSelect.AutoSize = false;
            button_modeSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modeSelect.Image = Properties.Resources.Select;
            button_modeSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modeSelect.Name = "button_modeSelect";
            button_modeSelect.Size = new System.Drawing.Size(24, 24);
            button_modeSelect.Text = "Select";
            button_modeSelect.Click += button_modeSelect_Click;
            // 
            // button_modePaste
            // 
            button_modePaste.AutoSize = false;
            button_modePaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_modePaste.Image = Properties.Resources.Paste;
            button_modePaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_modePaste.Name = "button_modePaste";
            button_modePaste.Size = new System.Drawing.Size(24, 24);
            button_modePaste.Text = "Paste";
            button_modePaste.Click += button_modePaste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // resizeIcon
            // 
            resizeIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resizeIcon.Image = Properties.Resources.Resize;
            resizeIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            resizeIcon.Name = "resizeIcon";
            resizeIcon.Size = new System.Drawing.Size(24, 24);
            resizeIcon.Text = "Resize";
            resizeIcon.Click += resizeIcon_Click;
            // 
            // currentColour
            // 
            currentColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            currentColour.Location = new System.Drawing.Point(14, 60);
            currentColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            currentColour.Name = "currentColour";
            currentColour.Size = new System.Drawing.Size(63, 61);
            currentColour.TabIndex = 2;
            currentColour.Paint += currentColour_Paint;
            // 
            // editorContainer
            // 
            editorContainer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            editorContainer.AutoScroll = true;
            editorContainer.BackColor = System.Drawing.Color.Gray;
            editorContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            editorContainer.Controls.Add(editorPanel);
            editorContainer.Location = new System.Drawing.Point(85, 60);
            editorContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            editorContainer.Name = "editorContainer";
            editorContainer.Size = new System.Drawing.Size(440, 456);
            editorContainer.TabIndex = 3;
            editorContainer.Resize += panel2_Resize;
            // 
            // editorPanel
            // 
            editorPanel.Location = new System.Drawing.Point(0, 0);
            editorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            editorPanel.Name = "editorPanel";
            editorPanel.Size = new System.Drawing.Size(399, 417);
            editorPanel.TabIndex = 0;
            editorPanel.Paint += doubleBufferedPanel1_Paint;
            editorPanel.MouseDown += doubleBufferedPanel1_MouseDown;
            editorPanel.MouseMove += doubleBufferedPanel1_MouseMove;
            editorPanel.MouseUp += doubleBufferedPanel1_MouseUp;
            // 
            // editorPanel
            // 
            this.editorPanel.Location = new System.Drawing.Point(0, 0);
            this.editorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(399, 417);
            this.editorPanel.TabIndex = 0;
            this.editorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.doubleBufferedPanel1_Paint);
            this.editorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseDown);
            this.editorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseMove);
            this.editorPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseUp);
            // 
            // button_colourTransparent
            // 
            button_colourTransparent.BackColor = System.Drawing.Color.Gray;
            button_colourTransparent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colourTransparent.Location = new System.Drawing.Point(14, 128);
            button_colourTransparent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colourTransparent.Name = "button_colourTransparent";
            button_colourTransparent.Size = new System.Drawing.Size(26, 27);
            button_colourTransparent.TabIndex = 4;
            button_colourTransparent.MouseClick += button_colourTransparent_MouseClick;
            // 
            // button_colour0
            // 
            button_colour0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour0.Location = new System.Drawing.Point(14, 163);
            button_colour0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour0.Name = "button_colour0";
            button_colour0.Size = new System.Drawing.Size(26, 27);
            button_colour0.TabIndex = 5;
            button_colour0.MouseClick += button_colour0_MouseClick;
            button_colour0.MouseDoubleClick += button_colour0_MouseDoubleClick;
            // 
            // button_colour1
            // 
            button_colour1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour1.Location = new System.Drawing.Point(48, 163);
            button_colour1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour1.Name = "button_colour1";
            button_colour1.Size = new System.Drawing.Size(26, 27);
            button_colour1.TabIndex = 6;
            button_colour1.MouseClick += button_colour1_MouseClick;
            button_colour1.MouseDoubleClick += button_colour1_MouseDoubleClick;
            // 
            // button_colour3
            // 
            button_colour3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour3.Location = new System.Drawing.Point(48, 197);
            button_colour3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour3.Name = "button_colour3";
            button_colour3.Size = new System.Drawing.Size(26, 27);
            button_colour3.TabIndex = 8;
            button_colour3.MouseClick += button_colour3_MouseClick;
            button_colour3.MouseDoubleClick += button_colour3_MouseDoubleClick;
            // 
            // button_colour2
            // 
            button_colour2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour2.Location = new System.Drawing.Point(14, 197);
            button_colour2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour2.Name = "button_colour2";
            button_colour2.Size = new System.Drawing.Size(26, 27);
            button_colour2.TabIndex = 7;
            button_colour2.MouseClick += button_colour2_MouseClick;
            button_colour2.MouseDoubleClick += button_colour2_MouseDoubleClick;
            // 
            // button_colour7
            // 
            button_colour7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour7.Location = new System.Drawing.Point(48, 267);
            button_colour7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour7.Name = "button_colour7";
            button_colour7.Size = new System.Drawing.Size(26, 27);
            button_colour7.TabIndex = 12;
            button_colour7.MouseClick += button_colour7_MouseClick;
            button_colour7.MouseDoubleClick += button_colour7_MouseDoubleClick;
            // 
            // button_colour6
            // 
            button_colour6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour6.Location = new System.Drawing.Point(14, 267);
            button_colour6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour6.Name = "button_colour6";
            button_colour6.Size = new System.Drawing.Size(26, 27);
            button_colour6.TabIndex = 11;
            button_colour6.MouseClick += button_colour6_MouseClick;
            button_colour6.MouseDoubleClick += button_colour6_MouseDoubleClick;
            // 
            // button_colour5
            // 
            button_colour5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour5.Location = new System.Drawing.Point(48, 232);
            button_colour5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour5.Name = "button_colour5";
            button_colour5.Size = new System.Drawing.Size(26, 27);
            button_colour5.TabIndex = 10;
            button_colour5.MouseClick += button_colour5_MouseClick;
            button_colour5.MouseDoubleClick += button_colour5_MouseDoubleClick;
            // 
            // button_colour4
            // 
            button_colour4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour4.Location = new System.Drawing.Point(14, 232);
            button_colour4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour4.Name = "button_colour4";
            button_colour4.Size = new System.Drawing.Size(26, 27);
            button_colour4.TabIndex = 9;
            button_colour4.MouseClick += button_colour4_MouseClick;
            button_colour4.MouseDoubleClick += button_colour4_MouseDoubleClick;
            // 
            // button_colour15
            // 
            button_colour15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour15.Location = new System.Drawing.Point(48, 405);
            button_colour15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour15.Name = "button_colour15";
            button_colour15.Size = new System.Drawing.Size(26, 27);
            button_colour15.TabIndex = 20;
            button_colour15.MouseClick += button_colour15_MouseClick;
            button_colour15.MouseDoubleClick += button_colour15_MouseDoubleClick;
            // 
            // button_colour11
            // 
            button_colour11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour11.Location = new System.Drawing.Point(48, 336);
            button_colour11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour11.Name = "button_colour11";
            button_colour11.Size = new System.Drawing.Size(26, 27);
            button_colour11.TabIndex = 16;
            button_colour11.MouseClick += button_colour11_MouseClick;
            button_colour11.MouseDoubleClick += button_colour11_MouseDoubleClick;
            // 
            // button_colour14
            // 
            button_colour14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour14.Location = new System.Drawing.Point(14, 405);
            button_colour14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour14.Name = "button_colour14";
            button_colour14.Size = new System.Drawing.Size(26, 27);
            button_colour14.TabIndex = 19;
            button_colour14.MouseClick += button_colour14_MouseClick;
            button_colour14.MouseDoubleClick += button_colour14_MouseDoubleClick;
            // 
            // button_colour10
            // 
            button_colour10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour10.Location = new System.Drawing.Point(14, 336);
            button_colour10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour10.Name = "button_colour10";
            button_colour10.Size = new System.Drawing.Size(26, 27);
            button_colour10.TabIndex = 15;
            button_colour10.MouseClick += button_colour10_MouseClick;
            button_colour10.MouseDoubleClick += button_colour10_MouseDoubleClick;
            // 
            // button_colour13
            // 
            button_colour13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour13.Location = new System.Drawing.Point(48, 370);
            button_colour13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour13.Name = "button_colour13";
            button_colour13.Size = new System.Drawing.Size(26, 27);
            button_colour13.TabIndex = 18;
            button_colour13.MouseClick += button_colour13_MouseClick;
            button_colour13.MouseDoubleClick += button_colour13_MouseDoubleClick;
            // 
            // button_colour9
            // 
            button_colour9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour9.Location = new System.Drawing.Point(48, 301);
            button_colour9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour9.Name = "button_colour9";
            button_colour9.Size = new System.Drawing.Size(26, 27);
            button_colour9.TabIndex = 14;
            button_colour9.MouseClick += button_colour9_MouseClick;
            button_colour9.MouseDoubleClick += button_colour9_MouseDoubleClick;
            // 
            // button_colour12
            // 
            button_colour12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour12.Location = new System.Drawing.Point(14, 370);
            button_colour12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour12.Name = "button_colour12";
            button_colour12.Size = new System.Drawing.Size(26, 27);
            button_colour12.TabIndex = 17;
            button_colour12.MouseClick += button_colour12_MouseClick;
            button_colour12.MouseDoubleClick += button_colour12_MouseDoubleClick;
            // 
            // button_colour8
            // 
            button_colour8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            button_colour8.Location = new System.Drawing.Point(14, 301);
            button_colour8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_colour8.Name = "button_colour8";
            button_colour8.Size = new System.Drawing.Size(26, 27);
            button_colour8.TabIndex = 13;
            button_colour8.MouseClick += button_colour8_MouseClick;
            button_colour8.MouseDoubleClick += button_colour8_MouseDoubleClick;
            // 
            // SpriteEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(540, 531);
            Controls.Add(button_colour15);
            Controls.Add(button_colour11);
            Controls.Add(button_colour14);
            Controls.Add(button_colour10);
            Controls.Add(button_colour13);
            Controls.Add(button_colour9);
            Controls.Add(button_colour12);
            Controls.Add(button_colour8);
            Controls.Add(button_colour7);
            Controls.Add(button_colour3);
            Controls.Add(button_colour6);
            Controls.Add(button_colour2);
            Controls.Add(button_colour5);
            Controls.Add(button_colour1);
            Controls.Add(button_colour4);
            Controls.Add(button_colour0);
            Controls.Add(button_colourTransparent);
            Controls.Add(editorContainer);
            Controls.Add(currentColour);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SpriteEditor";
            Text = "SpriteEditor";
            FormClosing += SpriteEditor_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            editorContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateClockwise;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateAntiClockwise;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ShiftLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShiftRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShiftUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShiftDownToolStripMenuItem;
    }
}