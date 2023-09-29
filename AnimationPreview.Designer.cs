namespace BeebSpriter
{
    partial class AnimationPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationPreview));
            this.lbSpriteList = new System.Windows.Forms.ListBox();
            this.previewPanel = new BeebSpriter.DoubleBufferedPanel();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lbMode = new System.Windows.Forms.ListBox();
            this.lblFast = new System.Windows.Forms.Label();
            this.lblSlow = new System.Windows.Forms.Label();
            this.btnDeleteSprite = new System.Windows.Forms.Button();
            this.btnSpriteMoveUp = new System.Windows.Forms.Button();
            this.btnSpriteMoveDown = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.lblZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSpriteList
            // 
            this.lbSpriteList.AllowDrop = true;
            this.lbSpriteList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSpriteList.FormattingEnabled = true;
            this.lbSpriteList.IntegralHeight = false;
            this.lbSpriteList.ItemHeight = 15;
            this.lbSpriteList.Location = new System.Drawing.Point(14, 10);
            this.lbSpriteList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbSpriteList.Name = "lbSpriteList";
            this.lbSpriteList.Size = new System.Drawing.Size(185, 282);
            this.lbSpriteList.TabIndex = 0;
            this.lbSpriteList.Click += new System.EventHandler(this.lbSpriteList_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPanel.Location = new System.Drawing.Point(217, 83);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(305, 209);
            this.previewPanel.TabIndex = 1;
            this.previewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previewPanel_Paint);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpeed.LargeChange = 1;
            this.tbSpeed.Location = new System.Drawing.Point(217, 10);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSpeed.Maximum = 8;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(153, 45);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.Value = 6;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // lbMode
            // 
            this.lbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMode.FormattingEnabled = true;
            this.lbMode.ItemHeight = 15;
            this.lbMode.Items.AddRange(new object[] {
            "Cyclic",
            "Yo-yo",
            "One shot"});
            this.lbMode.Location = new System.Drawing.Point(396, 10);
            this.lbMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(126, 49);
            this.lbMode.TabIndex = 3;
            // 
            // lblFast
            // 
            this.lblFast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFast.AutoSize = true;
            this.lblFast.Location = new System.Drawing.Point(225, 47);
            this.lblFast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFast.Name = "lblFast";
            this.lblFast.Size = new System.Drawing.Size(28, 15);
            this.lblFast.TabIndex = 4;
            this.lblFast.Text = "Fast";
            // 
            // lblSlow
            // 
            this.lblSlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlow.AutoSize = true;
            this.lblSlow.Location = new System.Drawing.Point(335, 47);
            this.lblSlow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlow.Name = "lblSlow";
            this.lblSlow.Size = new System.Drawing.Size(32, 15);
            this.lblSlow.TabIndex = 5;
            this.lblSlow.Text = "Slow";
            // 
            // btnDeleteSprite
            // 
            this.btnDeleteSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSprite.Image = global::BeebSpriter.Properties.Resources.remove;
            this.btnDeleteSprite.Location = new System.Drawing.Point(14, 295);
            this.btnDeleteSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteSprite.Name = "btnDeleteSprite";
            this.btnDeleteSprite.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteSprite.TabIndex = 6;
            this.btnDeleteSprite.UseVisualStyleBackColor = true;
            this.btnDeleteSprite.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSpriteMoveUp
            // 
            this.btnSpriteMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpriteMoveUp.Image = global::BeebSpriter.Properties.Resources.moveup;
            this.btnSpriteMoveUp.Location = new System.Drawing.Point(42, 295);
            this.btnSpriteMoveUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSpriteMoveUp.Name = "btnSpriteMoveUp";
            this.btnSpriteMoveUp.Size = new System.Drawing.Size(28, 28);
            this.btnSpriteMoveUp.TabIndex = 7;
            this.btnSpriteMoveUp.UseVisualStyleBackColor = true;
            this.btnSpriteMoveUp.Click += new System.EventHandler(this.btnSpriteMoveUp_Click);
            // 
            // btnSpriteMoveDown
            // 
            this.btnSpriteMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpriteMoveDown.Image = global::BeebSpriter.Properties.Resources.movedown;
            this.btnSpriteMoveDown.Location = new System.Drawing.Point(71, 295);
            this.btnSpriteMoveDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSpriteMoveDown.Name = "btnSpriteMoveDown";
            this.btnSpriteMoveDown.Size = new System.Drawing.Size(28, 28);
            this.btnSpriteMoveDown.TabIndex = 8;
            this.btnSpriteMoveDown.UseVisualStyleBackColor = true;
            this.btnSpriteMoveDown.Click += new System.EventHandler(this.btnSpriteMoveDown_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Image = global::BeebSpriter.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(495, 300);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(28, 28);
            this.btnStop.TabIndex = 9;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Image = global::BeebSpriter.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(464, 300);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(28, 28);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbZoom
            // 
            this.tbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbZoom.Location = new System.Drawing.Point(217, 300);
            this.tbZoom.Maximum = 50;
            this.tbZoom.Minimum = 2;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(203, 45);
            this.tbZoom.TabIndex = 11;
            this.tbZoom.Value = 2;
            this.tbZoom.Scroll += new System.EventHandler(this.tbZoom_Scroll);
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZoom.Location = new System.Drawing.Point(419, 308);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(39, 21);
            this.lblZoom.TabIndex = 12;
            this.lblZoom.Text = "x 20";
            // 
            // AnimationPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 343);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSpriteMoveDown);
            this.Controls.Add(this.btnSpriteMoveUp);
            this.Controls.Add(this.btnDeleteSprite);
            this.Controls.Add(this.lblSlow);
            this.Controls.Add(this.lblFast);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.lbSpriteList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(504, 276);
            this.Name = "AnimationPreview";
            this.Text = "Animation previewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimationPreview_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.AnimationPreview_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSpriteList;
        private DoubleBufferedPanel previewPanel;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.ListBox lbMode;
        private System.Windows.Forms.Label lblFast;
        private System.Windows.Forms.Label lblSlow;
        private System.Windows.Forms.Button btnDeleteSprite;
        private System.Windows.Forms.Button btnSpriteMoveUp;
        private System.Windows.Forms.Button btnSpriteMoveDown;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.Label lblZoom;
    }
}