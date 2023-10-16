using BeebSpriter.Controls;

namespace BeebSpriter
{
    partial class ImportImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportImage));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            MessageToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ZoomToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ButtonGrid = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ZoomOutoolStripButton = new System.Windows.Forms.ToolStripButton();
            ZoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ImageBox = new ImageBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ButtonCancel = new System.Windows.Forms.Button();
            ButtonGenerate = new System.Windows.Forms.Button();
            ComboBoxGfxMode = new System.Windows.Forms.ComboBox();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MessageToolStripStatusLabel, ZoomToolStripStatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 508);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 34, 0);
            statusStrip1.Size = new System.Drawing.Size(770, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // MessageToolStripStatusLabel
            // 
            MessageToolStripStatusLabel.Name = "MessageToolStripStatusLabel";
            MessageToolStripStatusLabel.Size = new System.Drawing.Size(695, 17);
            MessageToolStripStatusLabel.Spring = true;
            MessageToolStripStatusLabel.Text = "Ready";
            MessageToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ZoomToolStripStatusLabel
            // 
            ZoomToolStripStatusLabel.Name = "ZoomToolStripStatusLabel";
            ZoomToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            ZoomToolStripStatusLabel.Text = "Zoom";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(770, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            openToolStripMenuItem.Text = "&Open Image";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenToolStripButton, toolStripSeparator1, ButtonGrid, toolStripSeparator2, ZoomOutoolStripButton, ZoomInToolStripButton, toolStripSeparator3 });
            toolStrip1.Location = new System.Drawing.Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            toolStrip1.Size = new System.Drawing.Size(770, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // OpenToolStripButton
            // 
            OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            OpenToolStripButton.Image = (System.Drawing.Image)resources.GetObject("OpenToolStripButton.Image");
            OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            OpenToolStripButton.Name = "OpenToolStripButton";
            OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            OpenToolStripButton.Text = "&Open";
            OpenToolStripButton.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ButtonGrid
            // 
            ButtonGrid.Checked = true;
            ButtonGrid.CheckOnClick = true;
            ButtonGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            ButtonGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonGrid.Image = (System.Drawing.Image)resources.GetObject("ButtonGrid.Image");
            ButtonGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonGrid.Name = "ButtonGrid";
            ButtonGrid.Size = new System.Drawing.Size(23, 22);
            ButtonGrid.Text = "Show Grid";
            ButtonGrid.Click += ButtonGrid_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ZoomOutoolStripButton
            // 
            ZoomOutoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ZoomOutoolStripButton.Image = (System.Drawing.Image)resources.GetObject("ZoomOutoolStripButton.Image");
            ZoomOutoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ZoomOutoolStripButton.Name = "ZoomOutoolStripButton";
            ZoomOutoolStripButton.Size = new System.Drawing.Size(23, 22);
            ZoomOutoolStripButton.Text = "Zoom Out";
            ZoomOutoolStripButton.Click += ZoomOutoolStripButton_Click;
            // 
            // ZoomInToolStripButton
            // 
            ZoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ZoomInToolStripButton.Image = (System.Drawing.Image)resources.GetObject("ZoomInToolStripButton.Image");
            ZoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ZoomInToolStripButton.Name = "ZoomInToolStripButton";
            ZoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
            ZoomInToolStripButton.Text = "Zoom In";
            ZoomInToolStripButton.Click += ZoomInToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ImageBox
            // 
            ImageBox.AutoScroll = true;
            ImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ImageBox.Image = null;
            ImageBox.ImageSize = new System.Drawing.Size(0, 0);
            ImageBox.Location = new System.Drawing.Point(0, 49);
            ImageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ImageBox.Name = "ImageBox";
            ImageBox.OriginalImage = null;
            ImageBox.ShowGrid = true;
            ImageBox.Size = new System.Drawing.Size(770, 430);
            ImageBox.TabIndex = 8;
            ImageBox.ZoomFactor = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(ButtonCancel);
            flowLayoutPanel1.Controls.Add(ButtonGenerate);
            flowLayoutPanel1.Controls.Add(ComboBoxGfxMode);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 479);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(770, 29);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new System.Drawing.Point(692, 3);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new System.Drawing.Size(75, 23);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.Location = new System.Drawing.Point(611, 3);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            ButtonGenerate.TabIndex = 0;
            ButtonGenerate.Text = "&Generate";
            ButtonGenerate.UseVisualStyleBackColor = true;
            ButtonGenerate.Click += ButtonGenerate_Click;
            // 
            // ComboBoxGfxMode
            // 
            ComboBoxGfxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboBoxGfxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ComboBoxGfxMode.FormattingEnabled = true;
            ComboBoxGfxMode.Location = new System.Drawing.Point(292, 3);
            ComboBoxGfxMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ComboBoxGfxMode.Name = "ComboBoxGfxMode";
            ComboBoxGfxMode.Size = new System.Drawing.Size(312, 21);
            ComboBoxGfxMode.TabIndex = 2;
            ComboBoxGfxMode.SelectedIndexChanged += ComboBoxGfxMode_SelectedIndexChanged;
            // 
            // ImportImage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(770, 530);
            Controls.Add(ImageBox);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            Name = "ImportImage";
            Text = "Import Image";
            Load += ImportImage_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ZoomToolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ZoomOutoolStripButton;
        private System.Windows.Forms.ToolStripButton ZoomInToolStripButton;
        private Controls.ImageBox ImageBox;
        private System.Windows.Forms.ToolStripButton ButtonGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.ComboBox ComboBoxGfxMode;
    }
}