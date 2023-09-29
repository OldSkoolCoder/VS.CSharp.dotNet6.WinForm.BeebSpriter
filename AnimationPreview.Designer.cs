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
            this.modeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteSprite = new System.Windows.Forms.Button();
            this.btnSpriteMoveUp = new System.Windows.Forms.Button();
            this.btnSpriteMoveDown = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
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
            this.tbSpeed.Value = 1;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // modeListBox
            // 
            this.modeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modeListBox.FormattingEnabled = true;
            this.modeListBox.ItemHeight = 15;
            this.modeListBox.Items.AddRange(new object[] {
            "Cyclic",
            "Yo-yo",
            "One shot"});
            this.modeListBox.Location = new System.Drawing.Point(396, 10);
            this.modeListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modeListBox.Name = "modeListBox";
            this.modeListBox.Size = new System.Drawing.Size(126, 49);
            this.modeListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fast";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slow";
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
            // AnimationPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 343);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSpriteMoveDown);
            this.Controls.Add(this.btnSpriteMoveUp);
            this.Controls.Add(this.btnDeleteSprite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modeListBox);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.lbSpriteList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(504, 276);
            this.Name = "AnimationPreview";
            this.Text = "Animation previewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimationPreview_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSpriteList;
        private DoubleBufferedPanel previewPanel;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.ListBox modeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteSprite;
        private System.Windows.Forms.Button btnSpriteMoveUp;
        private System.Windows.Forms.Button btnSpriteMoveDown;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
    }
}