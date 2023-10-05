namespace BeebSpriter
{
    partial class NewGfxMode
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
            ComboBoxGfxMode = new System.Windows.Forms.ComboBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ButtonCancel = new System.Windows.Forms.Button();
            ButtonOK = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            TextBoxCurrentGfxMode = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(ComboBoxGfxMode);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(15, 99);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(327, 67);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Graphics Mode";
            // 
            // ComboBoxGfxMode
            // 
            ComboBoxGfxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboBoxGfxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ComboBoxGfxMode.FormattingEnabled = true;
            ComboBoxGfxMode.Location = new System.Drawing.Point(7, 23);
            ComboBoxGfxMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ComboBoxGfxMode.Name = "ComboBoxGfxMode";
            ComboBoxGfxMode.Size = new System.Drawing.Size(312, 21);
            ComboBoxGfxMode.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(ButtonCancel);
            flowLayoutPanel1.Controls.Add(ButtonOK);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 181);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(355, 33);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new System.Drawing.Point(263, 3);
            ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new System.Drawing.Size(88, 27);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "&Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new System.Drawing.Point(167, 3);
            ButtonOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new System.Drawing.Size(88, 27);
            ButtonOK.TabIndex = 0;
            ButtonOK.Text = "&OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(TextBoxCurrentGfxMode);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(15, 12);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(327, 67);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Graphics Mode";
            // 
            // TextBoxCurrentGfxMode
            // 
            TextBoxCurrentGfxMode.Location = new System.Drawing.Point(7, 29);
            TextBoxCurrentGfxMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBoxCurrentGfxMode.MaxLength = 20;
            TextBoxCurrentGfxMode.Name = "TextBoxCurrentGfxMode";
            TextBoxCurrentGfxMode.ReadOnly = true;
            TextBoxCurrentGfxMode.Size = new System.Drawing.Size(312, 19);
            TextBoxCurrentGfxMode.TabIndex = 1;
            // 
            // NewGfxMode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 214);
            Controls.Add(groupBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewGfxMode";
            Text = "New Graphics Mode";
            Load += NewGfxMode_Load;
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxGfxMode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBoxCurrentGfxMode;
    }
}