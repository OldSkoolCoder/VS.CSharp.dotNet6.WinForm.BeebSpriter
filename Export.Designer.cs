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
            gbSpriteLayout = new System.Windows.Forms.GroupBox();
            spriteLayout3 = new System.Windows.Forms.RadioButton();
            spriteLayout2 = new System.Windows.Forms.RadioButton();
            spriteLayout1 = new System.Windows.Forms.RadioButton();
            gbSpriteSize = new System.Windows.Forms.GroupBox();
            lblSpriteSizeDown = new System.Windows.Forms.Label();
            lblSpriteSizeAcross = new System.Windows.Forms.Label();
            spriteSizeDown = new System.Windows.Forms.NumericUpDown();
            spriteSizeAcross = new System.Windows.Forms.NumericUpDown();
            spriteSize2 = new System.Windows.Forms.RadioButton();
            spriteSize1 = new System.Windows.Forms.RadioButton();
            gbHearFileGenerattion = new System.Windows.Forms.GroupBox();
            lblHeader = new System.Windows.Forms.Label();
            txtHeader = new System.Windows.Forms.TextBox();
            chkHeader = new System.Windows.Forms.CheckBox();
            gpMaskingMode = new System.Windows.Forms.GroupBox();
            masking2 = new System.Windows.Forms.RadioButton();
            masking1 = new System.Windows.Forms.RadioButton();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            gbSelectedAssembler = new System.Windows.Forms.GroupBox();
            rbKickASM = new System.Windows.Forms.RadioButton();
            rbBeebASM = new System.Windows.Forms.RadioButton();
            gbPReview = new System.Windows.Forms.GroupBox();
            txtPreview = new System.Windows.Forms.TextBox();
            gbSpriteLayout.SuspendLayout();
            gbSpriteSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spriteSizeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteSizeAcross).BeginInit();
            gbHearFileGenerattion.SuspendLayout();
            gpMaskingMode.SuspendLayout();
            gbSelectedAssembler.SuspendLayout();
            gbPReview.SuspendLayout();
            SuspendLayout();
            // 
            // gbSpriteLayout
            // 
            gbSpriteLayout.Controls.Add(spriteLayout3);
            gbSpriteLayout.Controls.Add(spriteLayout2);
            gbSpriteLayout.Controls.Add(spriteLayout1);
            gbSpriteLayout.Location = new System.Drawing.Point(14, 14);
            gbSpriteLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbSpriteLayout.Name = "gbSpriteLayout";
            gbSpriteLayout.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbSpriteLayout.Size = new System.Drawing.Size(382, 110);
            gbSpriteLayout.TabIndex = 0;
            gbSpriteLayout.TabStop = false;
            gbSpriteLayout.Text = "Sprite layout";
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
            // gbSpriteSize
            // 
            gbSpriteSize.Controls.Add(lblSpriteSizeDown);
            gbSpriteSize.Controls.Add(lblSpriteSizeAcross);
            gbSpriteSize.Controls.Add(spriteSizeDown);
            gbSpriteSize.Controls.Add(spriteSizeAcross);
            gbSpriteSize.Controls.Add(spriteSize2);
            gbSpriteSize.Controls.Add(spriteSize1);
            gbSpriteSize.Location = new System.Drawing.Point(14, 142);
            gbSpriteSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbSpriteSize.Name = "gbSpriteSize";
            gbSpriteSize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbSpriteSize.Size = new System.Drawing.Size(382, 143);
            gbSpriteSize.TabIndex = 1;
            gbSpriteSize.TabStop = false;
            gbSpriteSize.Text = "Sprite size";
            // 
            // lblSpriteSizeDown
            // 
            lblSpriteSizeDown.AutoSize = true;
            lblSpriteSizeDown.Enabled = false;
            lblSpriteSizeDown.Location = new System.Drawing.Point(111, 110);
            lblSpriteSizeDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSpriteSizeDown.Name = "lblSpriteSizeDown";
            lblSpriteSizeDown.Size = new System.Drawing.Size(128, 15);
            lblSpriteSizeDown.TabIndex = 5;
            lblSpriteSizeDown.Text = "Character blocks down";
            // 
            // lblSpriteSizeAcross
            // 
            lblSpriteSizeAcross.AutoSize = true;
            lblSpriteSizeAcross.Enabled = false;
            lblSpriteSizeAcross.Location = new System.Drawing.Point(111, 80);
            lblSpriteSizeAcross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSpriteSizeAcross.Name = "lblSpriteSizeAcross";
            lblSpriteSizeAcross.Size = new System.Drawing.Size(131, 15);
            lblSpriteSizeAcross.TabIndex = 4;
            lblSpriteSizeAcross.Text = "Character blocks across";
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
            spriteSize2.Location = new System.Drawing.Point(8, 52);
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
            spriteSize1.Location = new System.Drawing.Point(8, 22);
            spriteSize1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spriteSize1.Name = "spriteSize1";
            spriteSize1.Size = new System.Drawing.Size(201, 19);
            spriteSize1.TabIndex = 0;
            spriteSize1.TabStop = true;
            spriteSize1.Text = "Export sprites at their defined size";
            spriteSize1.UseVisualStyleBackColor = true;
            // 
            // gbHearFileGenerattion
            // 
            gbHearFileGenerattion.Controls.Add(lblHeader);
            gbHearFileGenerattion.Controls.Add(txtHeader);
            gbHearFileGenerattion.Controls.Add(chkHeader);
            gbHearFileGenerattion.Location = new System.Drawing.Point(14, 480);
            gbHearFileGenerattion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbHearFileGenerattion.Name = "gbHearFileGenerattion";
            gbHearFileGenerattion.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbHearFileGenerattion.Size = new System.Drawing.Size(382, 128);
            gbHearFileGenerattion.TabIndex = 2;
            gbHearFileGenerattion.TabStop = false;
            gbHearFileGenerattion.Text = "Header file generation";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new System.Drawing.Point(27, 52);
            lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(308, 30);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Syntax for defining a symbol in your assembler:\r\n{n} = generated symbol name, {v} = unprefixed hex value\r\n";
            // 
            // txtHeader
            // 
            txtHeader.Location = new System.Drawing.Point(44, 90);
            txtHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new System.Drawing.Size(164, 23);
            txtHeader.TabIndex = 1;
            txtHeader.Text = "{n} = &{v}";
            txtHeader.KeyDown += txtHeader_KeyDown;
            // 
            // chkHeader
            // 
            chkHeader.AutoSize = true;
            chkHeader.Checked = true;
            chkHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            chkHeader.Location = new System.Drawing.Point(8, 23);
            chkHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkHeader.Name = "chkHeader";
            chkHeader.Size = new System.Drawing.Size(260, 19);
            chkHeader.TabIndex = 0;
            chkHeader.Text = "Export header information for named sprites";
            chkHeader.UseVisualStyleBackColor = true;
            chkHeader.CheckedChanged += chkHeader_CheckedChanged;
            // 
            // gpMaskingMode
            // 
            gpMaskingMode.Controls.Add(masking2);
            gpMaskingMode.Controls.Add(masking1);
            gpMaskingMode.Location = new System.Drawing.Point(14, 306);
            gpMaskingMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gpMaskingMode.Name = "gpMaskingMode";
            gpMaskingMode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gpMaskingMode.Size = new System.Drawing.Size(382, 82);
            gpMaskingMode.TabIndex = 3;
            gpMaskingMode.TabStop = false;
            gpMaskingMode.Text = "Transparency / masking";
            // 
            // masking2
            // 
            masking2.AutoSize = true;
            masking2.Location = new System.Drawing.Point(9, 48);
            masking2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            masking2.Name = "masking2";
            masking2.Size = new System.Drawing.Size(169, 19);
            masking2.TabIndex = 1;
            masking2.Text = "Export separate sprite mask";
            masking2.UseVisualStyleBackColor = true;
            masking2.CheckedChanged += masking2_CheckedChanged;
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
            masking1.CheckedChanged += masking1_CheckedChanged;
            // 
            // btnOK
            // 
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(102, 615);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(88, 27);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(214, 615);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // gbSelectedAssembler
            // 
            gbSelectedAssembler.Controls.Add(rbKickASM);
            gbSelectedAssembler.Controls.Add(rbBeebASM);
            gbSelectedAssembler.Location = new System.Drawing.Point(14, 408);
            gbSelectedAssembler.Name = "gbSelectedAssembler";
            gbSelectedAssembler.Size = new System.Drawing.Size(382, 55);
            gbSelectedAssembler.TabIndex = 6;
            gbSelectedAssembler.TabStop = false;
            gbSelectedAssembler.Text = "Selected Assembler";
            // 
            // rbKickASM
            // 
            rbKickASM.AutoSize = true;
            rbKickASM.Location = new System.Drawing.Point(236, 22);
            rbKickASM.Name = "rbKickASM";
            rbKickASM.Size = new System.Drawing.Size(70, 19);
            rbKickASM.TabIndex = 1;
            rbKickASM.TabStop = true;
            rbKickASM.Text = "Kick ASS";
            rbKickASM.UseVisualStyleBackColor = true;
            rbKickASM.CheckedChanged += rbKickASM_CheckedChanged;
            // 
            // rbBeebASM
            // 
            rbBeebASM.AutoSize = true;
            rbBeebASM.Location = new System.Drawing.Point(44, 22);
            rbBeebASM.Name = "rbBeebASM";
            rbBeebASM.Size = new System.Drawing.Size(76, 19);
            rbBeebASM.TabIndex = 0;
            rbBeebASM.TabStop = true;
            rbBeebASM.Text = "BeebASM";
            rbBeebASM.UseVisualStyleBackColor = true;
            rbBeebASM.CheckedChanged += rbBeebASM_CheckedChanged;
            // 
            // gbPReview
            // 
            gbPReview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbPReview.Controls.Add(txtPreview);
            gbPReview.Location = new System.Drawing.Point(403, 14);
            gbPReview.Name = "gbPReview";
            gbPReview.Size = new System.Drawing.Size(653, 594);
            gbPReview.TabIndex = 7;
            gbPReview.TabStop = false;
            gbPReview.Text = "Preview";
            // 
            // txtPreview
            // 
            txtPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPreview.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPreview.Location = new System.Drawing.Point(6, 18);
            txtPreview.Multiline = true;
            txtPreview.Name = "txtPreview";
            txtPreview.ReadOnly = true;
            txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtPreview.Size = new System.Drawing.Size(641, 570);
            txtPreview.TabIndex = 0;
            // 
            // Export
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(1068, 653);
            ControlBox = false;
            Controls.Add(gbPReview);
            Controls.Add(gbSelectedAssembler);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(gpMaskingMode);
            Controls.Add(gbHearFileGenerattion);
            Controls.Add(gbSpriteSize);
            Controls.Add(gbSpriteLayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Export";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Export options";
            gbSpriteLayout.ResumeLayout(false);
            gbSpriteLayout.PerformLayout();
            gbSpriteSize.ResumeLayout(false);
            gbSpriteSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spriteSizeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteSizeAcross).EndInit();
            gbHearFileGenerattion.ResumeLayout(false);
            gbHearFileGenerattion.PerformLayout();
            gpMaskingMode.ResumeLayout(false);
            gpMaskingMode.PerformLayout();
            gbSelectedAssembler.ResumeLayout(false);
            gbSelectedAssembler.PerformLayout();
            gbPReview.ResumeLayout(false);
            gbPReview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbSpriteLayout;
        private System.Windows.Forms.RadioButton spriteLayout2;
        private System.Windows.Forms.RadioButton spriteLayout1;
        private System.Windows.Forms.GroupBox gbSpriteSize;
        private System.Windows.Forms.Label lblSpriteSizeDown;
        private System.Windows.Forms.Label lblSpriteSizeAcross;
        private System.Windows.Forms.NumericUpDown spriteSizeDown;
        private System.Windows.Forms.NumericUpDown spriteSizeAcross;
        private System.Windows.Forms.RadioButton spriteSize2;
        private System.Windows.Forms.RadioButton spriteSize1;
        private System.Windows.Forms.GroupBox gbHearFileGenerattion;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.CheckBox chkHeader;
        private System.Windows.Forms.GroupBox gpMaskingMode;
        private System.Windows.Forms.RadioButton masking2;
        private System.Windows.Forms.RadioButton masking1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton spriteLayout3;
        private System.Windows.Forms.GroupBox gbSelectedAssembler;
        private System.Windows.Forms.RadioButton rbKickASM;
        private System.Windows.Forms.RadioButton rbBeebASM;
        private System.Windows.Forms.GroupBox gbPReview;
        private System.Windows.Forms.TextBox txtPreview;
    }
}