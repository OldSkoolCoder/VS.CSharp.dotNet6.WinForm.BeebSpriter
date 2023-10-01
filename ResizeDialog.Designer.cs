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
            cancelButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            numericHeight = new System.Windows.Forms.NumericUpDown();
            numericWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWidth).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(112, 77);
            cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(86, 32);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Location = new System.Drawing.Point(14, 77);
            okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(86, 32);
            okButton.TabIndex = 8;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 40);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Height";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Width";
            // 
            // numericHeight
            // 
            numericHeight.Location = new System.Drawing.Point(62, 38);
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
            numericWidth.Location = new System.Drawing.Point(62, 8);
            numericWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericWidth.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            numericWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericWidth.Name = "numericWidth";
            numericWidth.Size = new System.Drawing.Size(75, 23);
            numericWidth.TabIndex = 5;
            numericWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ResizeDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new System.Drawing.Size(224, 136);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericHeight);
            Controls.Add(numericWidth);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ResizeDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Resize sprite";
            ((System.ComponentModel.ISupportInitialize)numericHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
    }
}