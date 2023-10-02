namespace BeebSpriter
{
    partial class ReplaceColour
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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ButtonCancel = new System.Windows.Forms.Button();
            ButtonOK = new System.Windows.Forms.Button();
            LabelCurrentColour = new System.Windows.Forms.Label();
            LabelNewColour = new System.Windows.Forms.Label();
            StatusStrip1 = new System.Windows.Forms.StatusStrip();
            ColourComboBox1 = new Controls.ColourComboBox();
            ColourComboBox2 = new Controls.ColourComboBox();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 185);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(276, 29);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            ButtonCancel.Location = new System.Drawing.Point(165, 93);
            ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new System.Drawing.Size(88, 27);
            ButtonCancel.TabIndex = 7;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            ButtonOK.Location = new System.Drawing.Point(69, 93);
            ButtonOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new System.Drawing.Size(88, 27);
            ButtonOK.TabIndex = 6;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            // 
            // LabelCurrentColour
            // 
            LabelCurrentColour.AutoSize = true;
            LabelCurrentColour.Location = new System.Drawing.Point(13, 19);
            LabelCurrentColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelCurrentColour.Name = "LabelCurrentColour";
            LabelCurrentColour.Size = new System.Drawing.Size(86, 15);
            LabelCurrentColour.TabIndex = 10;
            LabelCurrentColour.Text = "Current Colour";
            // 
            // LabelNewColour
            // 
            LabelNewColour.AutoSize = true;
            LabelNewColour.Location = new System.Drawing.Point(13, 49);
            LabelNewColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelNewColour.Name = "LabelNewColour";
            LabelNewColour.Size = new System.Drawing.Size(70, 15);
            LabelNewColour.TabIndex = 9;
            LabelNewColour.Text = "New Colour";
            // 
            // StatusStrip1
            // 
            StatusStrip1.Location = new System.Drawing.Point(0, 123);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Size = new System.Drawing.Size(266, 22);
            StatusStrip1.TabIndex = 12;
            // 
            // ColourComboBox1
            // 
            ColourComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ColourComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            ColourComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ColourComboBox1.Location = new System.Drawing.Point(106, 16);
            ColourComboBox1.Name = "ColourComboBox1";
            ColourComboBox1.SelectedItem = null;
            ColourComboBox1.SelectedValue = System.Drawing.Color.White;
            ColourComboBox1.Size = new System.Drawing.Size(147, 24);
            ColourComboBox1.TabIndex = 13;
            // 
            // ColourComboBox2
            // 
            ColourComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ColourComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            ColourComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ColourComboBox2.Location = new System.Drawing.Point(107, 46);
            ColourComboBox2.Name = "ColourComboBox2";
            ColourComboBox2.SelectedItem = null;
            ColourComboBox2.SelectedValue = System.Drawing.Color.White;
            ColourComboBox2.Size = new System.Drawing.Size(147, 24);
            ColourComboBox2.TabIndex = 14;
            // 
            // ReplaceColour
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(266, 145);
            Controls.Add(ColourComboBox2);
            Controls.Add(StatusStrip1);
            Controls.Add(LabelCurrentColour);
            Controls.Add(LabelNewColour);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOK);
            Controls.Add(ColourComboBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReplaceColour";
            Text = "Replace Colour";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelNewColour;
        private System.Windows.Forms.Label LabelCurrentColour;
        private System.Windows.Forms.StatusStrip StatusStrip1;

        private Controls.ColourComboBox ColourComboBox1;
        private Controls.ColourComboBox ColourComboBox2;
    }
}