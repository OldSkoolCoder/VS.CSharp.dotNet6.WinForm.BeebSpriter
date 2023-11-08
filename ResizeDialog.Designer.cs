namespace BeebSpriter
{
    partial class ResizeDialog
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            NumericHeight = new System.Windows.Forms.NumericUpDown();
            NumericWidth = new System.Windows.Forms.NumericUpDown();
            ButtonOK = new System.Windows.Forms.Button();
            ButtonCancel = new System.Windows.Forms.Button();
            ImageBox = new Controls.ImageBox();
            ComboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            CheckBox1 = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)NumericHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericWidth).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(236, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Height";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(240, 34);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Width";
            // 
            // NumericHeight
            // 
            NumericHeight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            NumericHeight.Location = new System.Drawing.Point(287, 60);
            NumericHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NumericHeight.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            NumericHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericHeight.Name = "NumericHeight";
            NumericHeight.Size = new System.Drawing.Size(75, 23);
            NumericHeight.TabIndex = 7;
            NumericHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericHeight.ValueChanged += NumericHeight_ValueChanged;
            // 
            // NumericWidth
            // 
            NumericWidth.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            NumericWidth.Location = new System.Drawing.Point(287, 32);
            NumericWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NumericWidth.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            NumericWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericWidth.Name = "NumericWidth";
            NumericWidth.Size = new System.Drawing.Size(75, 23);
            NumericWidth.TabIndex = 5;
            NumericWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericWidth.ValueChanged += NumericWidth_ValueChanged;
            // 
            // ButtonOK
            // 
            ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ButtonOK.Location = new System.Drawing.Point(287, 123);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new System.Drawing.Size(75, 23);
            ButtonOK.TabIndex = 11;
            ButtonOK.Text = "&OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ButtonCancel.Location = new System.Drawing.Point(368, 123);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new System.Drawing.Size(75, 23);
            ButtonCancel.TabIndex = 12;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ImageBox
            // 
            ImageBox.AutoScroll = true;
            ImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            ImageBox.CenterImage = false;
            ImageBox.Image = null;
            ImageBox.ImageSize = new System.Drawing.Size(0, 0);
            ImageBox.Location = new System.Drawing.Point(13, 12);
            ImageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ImageBox.Name = "ImageBox";
            ImageBox.OriginalImage = null;
            ImageBox.PixelAspectRatio = new System.Drawing.Point(1, 1);
            ImageBox.ShowGrid = true;
            ImageBox.Size = new System.Drawing.Size(156, 134);
            ImageBox.TabIndex = 13;
            ImageBox.ZoomFactor = 5;
            // 
            // ComboBox1
            // 
            ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new System.Drawing.Point(287, 88);
            ComboBox1.Margin = new System.Windows.Forms.Padding(1);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new System.Drawing.Size(156, 23);
            ComboBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(221, 91);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 15;
            label3.Text = "Resample";
            // 
            // CheckBox1
            // 
            CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckBox1.Location = new System.Drawing.Point(287, 13);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new System.Drawing.Size(15, 14);
            CheckBox1.TabIndex = 16;
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(177, 12);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 15);
            label4.TabIndex = 17;
            label4.Text = "Keep Aspect Ratio";
            // 
            // ResizeDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(451, 158);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(CheckBox1);
            Controls.Add(label3);
            Controls.Add(ComboBox1);
            Controls.Add(ImageBox);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumericHeight);
            Controls.Add(NumericWidth);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ResizeDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Resize sprite";
            ((System.ComponentModel.ISupportInitialize)NumericHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericHeight;
        private System.Windows.Forms.NumericUpDown NumericWidth;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private Controls.ImageBox ImageBox;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Label label4;
    }
}