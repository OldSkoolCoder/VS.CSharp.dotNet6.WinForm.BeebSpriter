namespace BeebSpriter
{
    partial class SpriteRotator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteRotator));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            ShowGrid = new System.Windows.Forms.ToolStripButton();
            ZoomOutoolStripButton = new System.Windows.Forms.ToolStripButton();
            ZoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            MessageToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ZoomToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            Angle = new System.Windows.Forms.TrackBar();
            ImageBox = new Controls.ImageBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ButtonCancel = new System.Windows.Forms.Button();
            ButtonOK = new System.Windows.Forms.Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Angle).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ShowGrid, ZoomOutoolStripButton, ZoomInToolStripButton });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            toolStrip1.Size = new System.Drawing.Size(488, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // ShowGrid
            // 
            ShowGrid.Checked = true;
            ShowGrid.CheckOnClick = true;
            ShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            ShowGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ShowGrid.Image = (System.Drawing.Image)resources.GetObject("ShowGrid.Image");
            ShowGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            ShowGrid.Name = "ShowGrid";
            ShowGrid.Size = new System.Drawing.Size(23, 22);
            ShowGrid.Text = "toolStripButton1";
            ShowGrid.Click += ShowGrid_Click;
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MessageToolStripStatusLabel, ZoomToolStripStatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 399);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 34, 0);
            statusStrip1.Size = new System.Drawing.Size(488, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // MessageToolStripStatusLabel
            // 
            MessageToolStripStatusLabel.Name = "MessageToolStripStatusLabel";
            MessageToolStripStatusLabel.Size = new System.Drawing.Size(413, 17);
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
            // Angle
            // 
            Angle.Dock = System.Windows.Forms.DockStyle.Bottom;
            Angle.LargeChange = 10;
            Angle.Location = new System.Drawing.Point(0, 325);
            Angle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Angle.Maximum = 180;
            Angle.Minimum = -180;
            Angle.Name = "Angle";
            Angle.Size = new System.Drawing.Size(488, 45);
            Angle.TabIndex = 8;
            Angle.TickFrequency = 10;
            Angle.ValueChanged += Angle_ValueChanged;
            // 
            // ImageBox
            // 
            ImageBox.AutoScroll = true;
            ImageBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ImageBox.CenterImage = false;
            ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ImageBox.Image = null;
            ImageBox.ImageSize = new System.Drawing.Size(0, 0);
            ImageBox.Location = new System.Drawing.Point(0, 25);
            ImageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ImageBox.Name = "ImageBox";
            ImageBox.OriginalImage = null;
            ImageBox.PixelAspectRatio = new System.Drawing.Point(2, 2);
            ImageBox.ShowGrid = true;
            ImageBox.Size = new System.Drawing.Size(488, 300);
            ImageBox.TabIndex = 9;
            ImageBox.ZoomFactor = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(ButtonCancel);
            flowLayoutPanel1.Controls.Add(ButtonOK);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 370);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(488, 29);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new System.Drawing.Point(410, 3);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new System.Drawing.Size(75, 23);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new System.Drawing.Point(329, 3);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new System.Drawing.Size(75, 23);
            ButtonOK.TabIndex = 0;
            ButtonOK.Text = "&OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // SpriteRotator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(488, 421);
            Controls.Add(ImageBox);
            Controls.Add(Angle);
            Controls.Add(toolStrip1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "SpriteRotator";
            Text = "Sprite Rotator";
            Resize += SpriteRotator_Resize;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Angle).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ShowGrid;
        private System.Windows.Forms.ToolStripButton ZoomOutoolStripButton;
        private System.Windows.Forms.ToolStripButton ZoomInToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ZoomToolStripStatusLabel;
        private System.Windows.Forms.TrackBar Angle;
        private Controls.ImageBox ImageBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
    }
}