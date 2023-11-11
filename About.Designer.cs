namespace BeebSpriter
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            lblVersion = new System.Windows.Forms.Label();
            lblOrginialCreator = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            lblBuildDate = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblUpgraders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblVersion.Location = new System.Drawing.Point(14, 10);
            lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(304, 24);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "BeebSpriter v0.04 (pre-release)";
            lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrginialCreator
            // 
            lblOrginialCreator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOrginialCreator.Location = new System.Drawing.Point(12, 144);
            lblOrginialCreator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOrginialCreator.Name = "lblOrginialCreator";
            lblOrginialCreator.Size = new System.Drawing.Size(304, 72);
            lblOrginialCreator.TabIndex = 1;
            lblOrginialCreator.Text = "Originally created by Richard Talbot-Watkins\r\nrichtw1@gmail.com\r\n\r\nhttp://www.retrosoftware.co.uk/BeebSpriter";
            lblOrginialCreator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(116, 219);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblBuildDate
            // 
            lblBuildDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblBuildDate.Location = new System.Drawing.Point(18, 36);
            lblBuildDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBuildDate.Name = "lblBuildDate";
            lblBuildDate.Size = new System.Drawing.Size(301, 27);
            lblBuildDate.TabIndex = 3;
            lblBuildDate.Text = "11th November 2023";
            lblBuildDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(35, 35);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblUpgraders
            // 
            lblUpgraders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUpgraders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            lblUpgraders.Location = new System.Drawing.Point(12, 63);
            lblUpgraders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpgraders.Name = "lblUpgraders";
            lblUpgraders.Size = new System.Drawing.Size(304, 81);
            lblUpgraders.TabIndex = 5;
            lblUpgraders.Text = "Project Manager : OldSkoolCoder\r\nLead Programmer : Fizgog\r\nProgrammers: OldSkoolCoder, Sorcer3r, Docster, Phaze101";
            lblUpgraders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // About
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(332, 255);
            ControlBox = false;
            Controls.Add(lblUpgraders);
            Controls.Add(pictureBox1);
            Controls.Add(lblBuildDate);
            Controls.Add(button1);
            Controls.Add(lblOrginialCreator);
            Controls.Add(lblVersion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "About";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About BeebSpriter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblOrginialCreator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBuildDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUpgraders;
    }
}