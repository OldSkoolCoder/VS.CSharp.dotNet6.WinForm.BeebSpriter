namespace BeebSpriter
{
    partial class CanvasSizeDialog
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
            numericHeight = new System.Windows.Forms.NumericUpDown();
            numericWidth = new System.Windows.Forms.NumericUpDown();
            ImageBox = new Controls.ImageBox();
            ButtonCancel = new System.Windows.Forms.Button();
            ButtonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWidth).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(211, 94);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Height";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(215, 64);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Width";
            // 
            // numericHeight
            // 
            numericHeight.Location = new System.Drawing.Point(263, 92);
            numericHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericHeight.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            numericHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericHeight.Name = "numericHeight";
            numericHeight.Size = new System.Drawing.Size(75, 23);
            numericHeight.TabIndex = 7;
            numericHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericWidth
            // 
            numericWidth.Location = new System.Drawing.Point(263, 62);
            numericWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericWidth.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            numericWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericWidth.Name = "numericWidth";
            numericWidth.Size = new System.Drawing.Size(75, 23);
            numericWidth.TabIndex = 5;
            numericWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ImageBox
            // 
            ImageBox.AutoScroll = true;
            ImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            ImageBox.CenterImage = false;
            ImageBox.Image = null;
            ImageBox.ImageSize = new System.Drawing.Size(0, 0);
            ImageBox.Location = new System.Drawing.Point(29, 32);
            ImageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ImageBox.Name = "ImageBox";
            ImageBox.OriginalImage = null;
            ImageBox.PixelAspectRatio = new System.Drawing.Point(1, 1);
            ImageBox.ShowGrid = true;
            ImageBox.Size = new System.Drawing.Size(143, 107);
            ImageBox.TabIndex = 16;
            ImageBox.ZoomFactor = 5;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ButtonCancel.Location = new System.Drawing.Point(297, 151);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new System.Drawing.Size(75, 23);
            ButtonCancel.TabIndex = 15;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOK
            // 
            ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ButtonOK.Location = new System.Drawing.Point(216, 151);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new System.Drawing.Size(75, 23);
            ButtonOK.TabIndex = 14;
            ButtonOK.Text = "&OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // CanvasResizeDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 186);
            ControlBox = false;
            Controls.Add(ImageBox);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericHeight);
            Controls.Add(numericWidth);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CanvasResizeDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Canvas Size";
            ((System.ComponentModel.ISupportInitialize)numericHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private Controls.ImageBox ImageBox;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
    }
}