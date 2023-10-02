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
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblOrginialCreator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBuildDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUpgraders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.Location = new System.Drawing.Point(14, 10);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(304, 24);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "BeebSpriter v0.04 (pre-release)";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrginialCreator
            // 
            this.lblOrginialCreator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrginialCreator.Location = new System.Drawing.Point(12, 144);
            this.lblOrginialCreator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrginialCreator.Name = "lblOrginialCreator";
            this.lblOrginialCreator.Size = new System.Drawing.Size(304, 72);
            this.lblOrginialCreator.TabIndex = 1;
            this.lblOrginialCreator.Text = "Originally created by Richard Talbot-Watkins\r\nrichtw1@gmail.com\r\n\r\nhttp://www.ret" +
    "rosoftware.co.uk/BeebSpriter";
            this.lblOrginialCreator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(116, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.Location = new System.Drawing.Point(18, 36);
            this.lblBuildDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(301, 27);
            this.lblBuildDate.TabIndex = 3;
            this.lblBuildDate.Text = "28th September 2023";
            this.lblBuildDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblUpgraders
            // 
            this.lblUpgraders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpgraders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUpgraders.Location = new System.Drawing.Point(12, 63);
            this.lblUpgraders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpgraders.Name = "lblUpgraders";
            this.lblUpgraders.Size = new System.Drawing.Size(304, 81);
            this.lblUpgraders.TabIndex = 5;
            this.lblUpgraders.Text = "Upgraded by :\r\nOldSkoolCoder, \r\nFizgog, Sorcer3r, Docster, Phaze101";
            this.lblUpgraders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // About
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 255);
            this.ControlBox = false;
            this.Controls.Add(this.lblUpgraders);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBuildDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOrginialCreator);
            this.Controls.Add(this.lblVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About BeebSpriter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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