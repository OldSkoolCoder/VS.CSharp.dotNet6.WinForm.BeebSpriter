﻿namespace BeebSpriter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spriteLayout2 = new System.Windows.Forms.RadioButton();
            this.spriteLayout1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.spriteSizeDownLabel = new System.Windows.Forms.Label();
            this.spriteSizeAcrossLabel = new System.Windows.Forms.Label();
            this.spriteSizeDown = new System.Windows.Forms.NumericUpDown();
            this.spriteSizeAcross = new System.Windows.Forms.NumericUpDown();
            this.spriteSize2 = new System.Windows.Forms.RadioButton();
            this.spriteSize1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.headerTickBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.masking2 = new System.Windows.Forms.RadioButton();
            this.masking1 = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.spriteLayout3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeAcross)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spriteLayout3);
            this.groupBox1.Controls.Add(this.spriteLayout2);
            this.groupBox1.Controls.Add(this.spriteLayout1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprite layout";
            // 
            // spriteLayout2
            // 
            this.spriteLayout2.AutoSize = true;
            this.spriteLayout2.Location = new System.Drawing.Point(6, 42);
            this.spriteLayout2.Name = "spriteLayout2";
            this.spriteLayout2.Size = new System.Drawing.Size(279, 17);
            this.spriteLayout2.TabIndex = 1;
            this.spriteLayout2.Text = "Column-major (for sprites to be plotted at any pixel line)";
            this.spriteLayout2.UseVisualStyleBackColor = true;
            // 
            // spriteLayout1
            // 
            this.spriteLayout1.AutoSize = true;
            this.spriteLayout1.Checked = true;
            this.spriteLayout1.Location = new System.Drawing.Point(6, 19);
            this.spriteLayout1.Name = "spriteLayout1";
            this.spriteLayout1.Size = new System.Drawing.Size(270, 17);
            this.spriteLayout1.TabIndex = 0;
            this.spriteLayout1.TabStop = true;
            this.spriteLayout1.Text = "Row-major (good for character block aligned sprites)";
            this.spriteLayout1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spriteSizeDownLabel);
            this.groupBox2.Controls.Add(this.spriteSizeAcrossLabel);
            this.groupBox2.Controls.Add(this.spriteSizeDown);
            this.groupBox2.Controls.Add(this.spriteSizeAcross);
            this.groupBox2.Controls.Add(this.spriteSize2);
            this.groupBox2.Controls.Add(this.spriteSize1);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sprite size";
            // 
            // spriteSizeDownLabel
            // 
            this.spriteSizeDownLabel.AutoSize = true;
            this.spriteSizeDownLabel.Enabled = false;
            this.spriteSizeDownLabel.Location = new System.Drawing.Point(95, 95);
            this.spriteSizeDownLabel.Name = "spriteSizeDownLabel";
            this.spriteSizeDownLabel.Size = new System.Drawing.Size(116, 13);
            this.spriteSizeDownLabel.TabIndex = 5;
            this.spriteSizeDownLabel.Text = "Character blocks down";
            // 
            // spriteSizeAcrossLabel
            // 
            this.spriteSizeAcrossLabel.AutoSize = true;
            this.spriteSizeAcrossLabel.Enabled = false;
            this.spriteSizeAcrossLabel.Location = new System.Drawing.Point(95, 69);
            this.spriteSizeAcrossLabel.Name = "spriteSizeAcrossLabel";
            this.spriteSizeAcrossLabel.Size = new System.Drawing.Size(121, 13);
            this.spriteSizeAcrossLabel.TabIndex = 4;
            this.spriteSizeAcrossLabel.Text = "Character blocks across";
            // 
            // spriteSizeDown
            // 
            this.spriteSizeDown.Enabled = false;
            this.spriteSizeDown.Location = new System.Drawing.Point(38, 93);
            this.spriteSizeDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spriteSizeDown.Name = "spriteSizeDown";
            this.spriteSizeDown.Size = new System.Drawing.Size(51, 20);
            this.spriteSizeDown.TabIndex = 3;
            this.spriteSizeDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // spriteSizeAcross
            // 
            this.spriteSizeAcross.Enabled = false;
            this.spriteSizeAcross.Location = new System.Drawing.Point(38, 67);
            this.spriteSizeAcross.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spriteSizeAcross.Name = "spriteSizeAcross";
            this.spriteSizeAcross.Size = new System.Drawing.Size(51, 20);
            this.spriteSizeAcross.TabIndex = 2;
            this.spriteSizeAcross.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // spriteSize2
            // 
            this.spriteSize2.AutoSize = true;
            this.spriteSize2.Location = new System.Drawing.Point(6, 43);
            this.spriteSize2.Name = "spriteSize2";
            this.spriteSize2.Size = new System.Drawing.Size(211, 17);
            this.spriteSize2.TabIndex = 1;
            this.spriteSize2.Text = "Break sprites into smaller pieces of size:";
            this.spriteSize2.UseVisualStyleBackColor = true;
            this.spriteSize2.CheckedChanged += new System.EventHandler(this.spriteSize2_CheckedChanged);
            // 
            // spriteSize1
            // 
            this.spriteSize1.AutoSize = true;
            this.spriteSize1.Checked = true;
            this.spriteSize1.Location = new System.Drawing.Point(6, 20);
            this.spriteSize1.Name = "spriteSize1";
            this.spriteSize1.Size = new System.Drawing.Size(182, 17);
            this.spriteSize1.TabIndex = 0;
            this.spriteSize1.TabStop = true;
            this.spriteSize1.Text = "Export sprites at their defined size";
            this.spriteSize1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.headerLabel);
            this.groupBox3.Controls.Add(this.headerTextBox);
            this.groupBox3.Controls.Add(this.headerTickBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Header file generation";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(23, 45);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(275, 26);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Syntax for defining a symbol in your assembler:\r\n{n} = generated symbol name, {v}" +
    " = unprefixed hex value\r\n";
            // 
            // headerTextBox
            // 
            this.headerTextBox.Location = new System.Drawing.Point(38, 78);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(141, 20);
            this.headerTextBox.TabIndex = 1;
            this.headerTextBox.Text = "{n} = &{v}";
            // 
            // headerTickBox
            // 
            this.headerTickBox.AutoSize = true;
            this.headerTickBox.Checked = true;
            this.headerTickBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headerTickBox.Location = new System.Drawing.Point(7, 20);
            this.headerTickBox.Name = "headerTickBox";
            this.headerTickBox.Size = new System.Drawing.Size(229, 17);
            this.headerTickBox.TabIndex = 0;
            this.headerTickBox.Text = "Export header information for named sprites";
            this.headerTickBox.UseVisualStyleBackColor = true;
            this.headerTickBox.CheckedChanged += new System.EventHandler(this.headerTickBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.masking2);
            this.groupBox4.Controls.Add(this.masking1);
            this.groupBox4.Location = new System.Drawing.Point(12, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 71);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transparency / masking";
            // 
            // masking2
            // 
            this.masking2.AutoSize = true;
            this.masking2.Location = new System.Drawing.Point(6, 43);
            this.masking2.Name = "masking2";
            this.masking2.Size = new System.Drawing.Size(155, 17);
            this.masking2.TabIndex = 1;
            this.masking2.Text = "Export separate sprite mask";
            this.masking2.UseVisualStyleBackColor = true;
            // 
            // masking1
            // 
            this.masking1.AutoSize = true;
            this.masking1.Checked = true;
            this.masking1.Location = new System.Drawing.Point(7, 20);
            this.masking1.Name = "masking1";
            this.masking1.Size = new System.Drawing.Size(195, 17);
            this.masking1.TabIndex = 0;
            this.masking1.TabStop = true;
            this.masking1.Text = "Export transparent pixels as colour 0";
            this.masking1.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(87, 469);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(183, 469);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // spriteLayout3
            // 
            this.spriteLayout3.AutoSize = true;
            this.spriteLayout3.Location = new System.Drawing.Point(6, 65);
            this.spriteLayout3.Name = "spriteLayout3";
            this.spriteLayout3.Size = new System.Drawing.Size(112, 17);
            this.spriteLayout3.TabIndex = 2;
            this.spriteLayout3.Text = "Linear (line-by-line)";
            this.spriteLayout3.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(351, 503);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeAcross)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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