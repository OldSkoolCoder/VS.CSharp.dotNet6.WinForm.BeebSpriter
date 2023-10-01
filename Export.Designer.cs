namespace BeebSpriter
{
    partial class Export
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            spriteLayout3 = new System.Windows.Forms.RadioButton();
            spriteLayout2 = new System.Windows.Forms.RadioButton();
            spriteLayout1 = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            spriteSizeDownLabel = new System.Windows.Forms.Label();
            spriteSizeAcrossLabel = new System.Windows.Forms.Label();
            spriteSizeDown = new System.Windows.Forms.NumericUpDown();
            spriteSizeAcross = new System.Windows.Forms.NumericUpDown();
            spriteSize2 = new System.Windows.Forms.RadioButton();
            spriteSize1 = new System.Windows.Forms.RadioButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            headerLabel = new System.Windows.Forms.Label();
            headerTextBox = new System.Windows.Forms.TextBox();
            headerTickBox = new System.Windows.Forms.CheckBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            masking2 = new System.Windows.Forms.RadioButton();
            masking1 = new System.Windows.Forms.RadioButton();
            okButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spriteSizeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteSizeAcross).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(spriteLayout3);
            groupBox1.Controls.Add(spriteLayout2);
            groupBox1.Controls.Add(spriteLayout1);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(382, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sprite layout";
            // 
            // spriteLayout3
            // 
            spriteLayout3.AutoSize = true;
            spriteLayout3.Location = new System.Drawing.Point(7, 75);
            spriteLayout3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteLayout3.Name = "spriteLayout3";
            spriteLayout3.Size = new System.Drawing.Size(129, 19);
            spriteLayout3.TabIndex = 2;
            spriteLayout3.Text = "Linear (line-by-line)";
            spriteLayout3.UseVisualStyleBackColor = true;
            // 
            // spriteLayout2
            // 
            spriteLayout2.AutoSize = true;
            spriteLayout2.Location = new System.Drawing.Point(7, 48);
            spriteLayout2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteLayout2.Name = "spriteLayout2";
            spriteLayout2.Size = new System.Drawing.Size(323, 19);
            spriteLayout2.TabIndex = 1;
            spriteLayout2.Text = "Column-major (for sprites to be plotted at any pixel line)";
            spriteLayout2.UseVisualStyleBackColor = true;
            // 
            // spriteLayout1
            // 
            spriteLayout1.AutoSize = true;
            spriteLayout1.Checked = true;
            spriteLayout1.Location = new System.Drawing.Point(7, 22);
            spriteLayout1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteLayout1.Name = "spriteLayout1";
            spriteLayout1.Size = new System.Drawing.Size(304, 19);
            spriteLayout1.TabIndex = 0;
            spriteLayout1.TabStop = true;
            spriteLayout1.Text = "Row-major (good for character block aligned sprites)";
            spriteLayout1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(spriteSizeDownLabel);
            groupBox2.Controls.Add(spriteSizeAcrossLabel);
            groupBox2.Controls.Add(spriteSizeDown);
            groupBox2.Controls.Add(spriteSizeAcross);
            groupBox2.Controls.Add(spriteSize2);
            groupBox2.Controls.Add(spriteSize1);
            groupBox2.Location = new System.Drawing.Point(14, 142);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(382, 143);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sprite size";
            // 
            // spriteSizeDownLabel
            // 
            spriteSizeDownLabel.AutoSize = true;
            spriteSizeDownLabel.Enabled = false;
            spriteSizeDownLabel.Location = new System.Drawing.Point(111, 110);
            spriteSizeDownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            spriteSizeDownLabel.Name = "spriteSizeDownLabel";
            spriteSizeDownLabel.Size = new System.Drawing.Size(128, 15);
            spriteSizeDownLabel.TabIndex = 5;
            spriteSizeDownLabel.Text = "Character blocks down";
            // 
            // spriteSizeAcrossLabel
            // 
            spriteSizeAcrossLabel.AutoSize = true;
            spriteSizeAcrossLabel.Enabled = false;
            spriteSizeAcrossLabel.Location = new System.Drawing.Point(111, 80);
            spriteSizeAcrossLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            spriteSizeAcrossLabel.Name = "spriteSizeAcrossLabel";
            spriteSizeAcrossLabel.Size = new System.Drawing.Size(131, 15);
            spriteSizeAcrossLabel.TabIndex = 4;
            spriteSizeAcrossLabel.Text = "Character blocks across";
            // 
            // spriteSizeDown
            // 
            spriteSizeDown.Enabled = false;
            spriteSizeDown.Location = new System.Drawing.Point(44, 107);
            spriteSizeDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteSizeDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            spriteSizeDown.Name = "spriteSizeDown";
            spriteSizeDown.Size = new System.Drawing.Size(59, 23);
            spriteSizeDown.TabIndex = 3;
            spriteSizeDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // spriteSizeAcross
            // 
            spriteSizeAcross.Enabled = false;
            spriteSizeAcross.Location = new System.Drawing.Point(44, 77);
            spriteSizeAcross.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteSizeAcross.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            spriteSizeAcross.Name = "spriteSizeAcross";
            spriteSizeAcross.Size = new System.Drawing.Size(59, 23);
            spriteSizeAcross.TabIndex = 2;
            spriteSizeAcross.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // spriteSize2
            // 
            spriteSize2.AutoSize = true;
            spriteSize2.Location = new System.Drawing.Point(7, 50);
            spriteSize2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteSize2.Name = "spriteSize2";
            spriteSize2.Size = new System.Drawing.Size(231, 19);
            spriteSize2.TabIndex = 1;
            spriteSize2.Text = "Break sprites into smaller pieces of size:";
            spriteSize2.UseVisualStyleBackColor = true;
            spriteSize2.CheckedChanged += spriteSize2_CheckedChanged;
            // 
            // spriteSize1
            // 
            spriteSize1.AutoSize = true;
            spriteSize1.Checked = true;
            spriteSize1.Location = new System.Drawing.Point(7, 23);
            spriteSize1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteSize1.Name = "spriteSize1";
            spriteSize1.Size = new System.Drawing.Size(201, 19);
            spriteSize1.TabIndex = 0;
            spriteSize1.TabStop = true;
            spriteSize1.Text = "Export sprites at their defined size";
            spriteSize1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(headerLabel);
            groupBox3.Controls.Add(headerTextBox);
            groupBox3.Controls.Add(headerTickBox);
            groupBox3.Location = new System.Drawing.Point(14, 406);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(382, 128);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Header file generation";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new System.Drawing.Point(27, 52);
            headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new System.Drawing.Size(308, 30);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Syntax for defining a symbol in your assembler:\r\n{n} = generated symbol name, {v} = unprefixed hex value\r\n";
            // 
            // headerTextBox
            // 
            headerTextBox.Location = new System.Drawing.Point(44, 90);
            headerTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headerTextBox.Name = "headerTextBox";
            headerTextBox.Size = new System.Drawing.Size(164, 23);
            headerTextBox.TabIndex = 1;
            headerTextBox.Text = "{n} = &{v}";
            // 
            // headerTickBox
            // 
            headerTickBox.AutoSize = true;
            headerTickBox.Checked = true;
            headerTickBox.CheckState = System.Windows.Forms.CheckState.Checked;
            headerTickBox.Location = new System.Drawing.Point(8, 23);
            headerTickBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headerTickBox.Name = "headerTickBox";
            headerTickBox.Size = new System.Drawing.Size(260, 19);
            headerTickBox.TabIndex = 0;
            headerTickBox.Text = "Export header information for named sprites";
            headerTickBox.UseVisualStyleBackColor = true;
            headerTickBox.CheckedChanged += headerTickBox_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(masking2);
            groupBox4.Controls.Add(masking1);
            groupBox4.Location = new System.Drawing.Point(14, 306);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new System.Drawing.Size(382, 82);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Transparency / masking";
            // 
            // masking2
            // 
            masking2.AutoSize = true;
            masking2.Location = new System.Drawing.Point(7, 50);
            masking2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            masking2.Name = "masking2";
            masking2.Size = new System.Drawing.Size(169, 19);
            masking2.TabIndex = 1;
            masking2.Text = "Export separate sprite mask";
            masking2.UseVisualStyleBackColor = true;
            // 
            // masking1
            // 
            masking1.AutoSize = true;
            masking1.Checked = true;
            masking1.Location = new System.Drawing.Point(8, 23);
            masking1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            masking1.Name = "masking1";
            masking1.Size = new System.Drawing.Size(215, 19);
            masking1.TabIndex = 0;
            masking1.TabStop = true;
            masking1.Text = "Export transparent pixels as colour 0";
            masking1.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Location = new System.Drawing.Point(102, 541);
            okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(88, 27);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(214, 541);
            cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(88, 27);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new System.Drawing.Size(408, 584);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Export";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Export options";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spriteSizeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteSizeAcross).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton spriteLayout2;
        private System.Windows.Forms.RadioButton spriteLayout1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label spriteSizeDownLabel;
        private System.Windows.Forms.Label spriteSizeAcrossLabel;
        private System.Windows.Forms.NumericUpDown spriteSizeDown;
        private System.Windows.Forms.NumericUpDown spriteSizeAcross;
        private System.Windows.Forms.RadioButton spriteSize2;
        private System.Windows.Forms.RadioButton spriteSize1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox headerTextBox;
        private System.Windows.Forms.CheckBox headerTickBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton masking2;
        private System.Windows.Forms.RadioButton masking1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton spriteLayout3;
    }
}