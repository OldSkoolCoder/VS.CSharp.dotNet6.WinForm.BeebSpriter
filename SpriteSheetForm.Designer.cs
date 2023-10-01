namespace BeebSpriter
{
    partial class SpriteSheetForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteSheetForm));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mode0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mode1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mode4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mode5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportToBeebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            RecentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            transparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            magentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            animationPreviewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editDefaultPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            contextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            newSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            spriteContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            addCopyOfThisSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            addToAnimationPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addAllSpritesToAnimationPreviewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            exportFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            menuStrip1.SuspendLayout();
            contextMenu.SuspendLayout();
            spriteContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(405, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveasToolStripMenuItem, toolStripMenuItem4, exportSettingsToolStripMenuItem, exportToBeebToolStripMenuItem, toolStripMenuItem1, RecentFilesToolStripMenuItem, toolStripMenuItem3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mode0ToolStripMenuItem, mode1ToolStripMenuItem, mode2ToolStripMenuItem, mode4ToolStripMenuItem, mode5ToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            newToolStripMenuItem.Text = "&New sprite sheet";
            // 
            // mode0ToolStripMenuItem
            // 
            mode0ToolStripMenuItem.Name = "mode0ToolStripMenuItem";
            mode0ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            mode0ToolStripMenuItem.Text = "Mode 0";
            mode0ToolStripMenuItem.Click += mode0ToolStripMenuItem_Click;
            // 
            // mode1ToolStripMenuItem
            // 
            mode1ToolStripMenuItem.Name = "mode1ToolStripMenuItem";
            mode1ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            mode1ToolStripMenuItem.Text = "Mode 1";
            mode1ToolStripMenuItem.Click += mode1ToolStripMenuItem_Click;
            // 
            // mode2ToolStripMenuItem
            // 
            mode2ToolStripMenuItem.Name = "mode2ToolStripMenuItem";
            mode2ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            mode2ToolStripMenuItem.Text = "Mode 2";
            mode2ToolStripMenuItem.Click += mode2ToolStripMenuItem_Click;
            // 
            // mode4ToolStripMenuItem
            // 
            mode4ToolStripMenuItem.Name = "mode4ToolStripMenuItem";
            mode4ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            mode4ToolStripMenuItem.Text = "Mode 4";
            mode4ToolStripMenuItem.Click += mode4ToolStripMenuItem_Click;
            // 
            // mode5ToolStripMenuItem
            // 
            mode5ToolStripMenuItem.Name = "mode5ToolStripMenuItem";
            mode5ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            mode5ToolStripMenuItem.Text = "Mode 5";
            mode5ToolStripMenuItem.Click += mode5ToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveasToolStripMenuItem
            // 
            saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            saveasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            saveasToolStripMenuItem.Text = "Save &as...";
            saveasToolStripMenuItem.Click += saveasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(197, 6);
            // 
            // exportSettingsToolStripMenuItem
            // 
            exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            exportSettingsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            exportSettingsToolStripMenuItem.Text = "Export settings...";
            exportSettingsToolStripMenuItem.Click += exportSettingsToolStripMenuItem_Click;
            // 
            // exportToBeebToolStripMenuItem
            // 
            exportToBeebToolStripMenuItem.Name = "exportToBeebToolStripMenuItem";
            exportToBeebToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E;
            exportToBeebToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            exportToBeebToolStripMenuItem.Text = "&Export to Beeb...";
            exportToBeebToolStripMenuItem.Click += exportToBeebToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // RecentFilesToolStripMenuItem
            // 
            RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem";
            RecentFilesToolStripMenuItem.Size = new System.Drawing.Size(398, 44);
            RecentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(395, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { backgroundColourToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // backgroundColourToolStripMenuItem
            // 
            backgroundColourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { transparentToolStripMenuItem, blackToolStripMenuItem, redToolStripMenuItem, greenToolStripMenuItem, yellowToolStripMenuItem, blueToolStripMenuItem, magentaToolStripMenuItem, cyanToolStripMenuItem, whiteToolStripMenuItem });
            backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            backgroundColourToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            backgroundColourToolStripMenuItem.Text = "Background colour";
            // 
            // transparentToolStripMenuItem
            // 
            transparentToolStripMenuItem.Checked = true;
            transparentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            transparentToolStripMenuItem.Name = "transparentToolStripMenuItem";
            transparentToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            transparentToolStripMenuItem.Text = "Transparent";
            transparentToolStripMenuItem.Click += transparentToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // yellowToolStripMenuItem
            // 
            yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            yellowToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            yellowToolStripMenuItem.Text = "Yellow";
            yellowToolStripMenuItem.Click += yellowToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // magentaToolStripMenuItem
            // 
            magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            magentaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            magentaToolStripMenuItem.Text = "Magenta";
            magentaToolStripMenuItem.Click += magentaToolStripMenuItem_Click;
            // 
            // cyanToolStripMenuItem
            // 
            cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            cyanToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            cyanToolStripMenuItem.Text = "Cyan";
            cyanToolStripMenuItem.Click += cyanToolStripMenuItem_Click;
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { animationPreviewerToolStripMenuItem, editDefaultPaletteToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // animationPreviewerToolStripMenuItem
            // 
            animationPreviewerToolStripMenuItem.Name = "animationPreviewerToolStripMenuItem";
            animationPreviewerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            animationPreviewerToolStripMenuItem.Text = "Animation previewer...";
            animationPreviewerToolStripMenuItem.Click += animationPreviewerToolStripMenuItem_Click;
            // 
            // editDefaultPaletteToolStripMenuItem
            // 
            editDefaultPaletteToolStripMenuItem.Name = "editDefaultPaletteToolStripMenuItem";
            editDefaultPaletteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            editDefaultPaletteToolStripMenuItem.Text = "Edit default palette...";
            editDefaultPaletteToolStripMenuItem.Click += editDefaultPaletteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            flowLayoutPanel1.ContextMenuStrip = contextMenu;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(405, 455);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            flowLayoutPanel1.DragOver += flowLayoutPanel1_DragOver;
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newSpriteToolStripMenuItem });
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new System.Drawing.Size(140, 26);
            // 
            // newSpriteToolStripMenuItem
            // 
            newSpriteToolStripMenuItem.Name = "newSpriteToolStripMenuItem";
            newSpriteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            newSpriteToolStripMenuItem.Text = "New sprite...";
            newSpriteToolStripMenuItem.Click += newSpriteToolStripMenuItem_Click;
            // 
            // spriteContextMenu
            // 
            spriteContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            spriteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { addCopyOfThisSpriteToolStripMenuItem, renameToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2, addToAnimationPreviewToolStripMenuItem, addAllSpritesToAnimationPreviewWindowToolStripMenuItem });
            spriteContextMenu.Name = "spriteContextMenu";
            spriteContextMenu.Size = new System.Drawing.Size(266, 142);
            // 
            // addCopyOfThisSpriteToolStripMenuItem
            // 
            addCopyOfThisSpriteToolStripMenuItem.Name = "addCopyOfThisSpriteToolStripMenuItem";
            addCopyOfThisSpriteToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            addCopyOfThisSpriteToolStripMenuItem.Text = "Make copy...";
            addCopyOfThisSpriteToolStripMenuItem.Click += addCopyOfThisSpriteToolStripMenuItem_Click;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            renameToolStripMenuItem.Text = "Rename...";
            renameToolStripMenuItem.Click += renameToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(262, 6);
            // 
            // addToAnimationPreviewToolStripMenuItem
            // 
            addToAnimationPreviewToolStripMenuItem.Name = "addToAnimationPreviewToolStripMenuItem";
            addToAnimationPreviewToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            addToAnimationPreviewToolStripMenuItem.Text = "Add to animation preview";
            addToAnimationPreviewToolStripMenuItem.Click += addToAnimationPreviewToolStripMenuItem_Click;
            // 
            // addAllSpritesToAnimationPreviewWindowToolStripMenuItem
            // 
            addAllSpritesToAnimationPreviewWindowToolStripMenuItem.Name = "addAllSpritesToAnimationPreviewWindowToolStripMenuItem";
            addAllSpritesToAnimationPreviewWindowToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            addAllSpritesToAnimationPreviewWindowToolStripMenuItem.Text = "Add all sprites to Animation Preview";
            addAllSpritesToAnimationPreviewWindowToolStripMenuItem.Click += addAllSpritesToAnimationPreviewWindowToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "bspr";
            openFileDialog1.Filter = "BeebSpriter files|*.bspr";
            openFileDialog1.Title = "Open file";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "bspr";
            saveFileDialog1.Filter = "BeebSpriter files|*.bspr";
            saveFileDialog1.Title = "Save file";
            // 
            // exportFileDialog1
            // 
            exportFileDialog1.DefaultExt = "bin";
            exportFileDialog1.Filter = "BBC Micro Binary File|*.bin";
            exportFileDialog1.Title = "Export to Beeb format";
            // 
            // SpriteSheetForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(405, 479);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SpriteSheetForm";
            Text = "Form1";
            FormClosing += SpriteSheetForm_FormClosing;
            Load += SpriteSheetForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenu.ResumeLayout(false);
            spriteContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem exportToBeebToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem newSpriteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip spriteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addCopyOfThisSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationPreviewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToAnimationPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDefaultPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exportSettingsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem RecentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addAllSpritesToAnimationPreviewWindowToolStripMenuItem;
    }
}

