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
            lbSpriteList = new System.Windows.Forms.ListBox();
            previewPanel = new DoubleBufferedPanel();
            tbSpeed = new System.Windows.Forms.TrackBar();
            lbMode = new System.Windows.Forms.ListBox();
            lblFast = new System.Windows.Forms.Label();
            lblSlow = new System.Windows.Forms.Label();
            btnDeleteSprite = new System.Windows.Forms.Button();
            btnSpriteMoveUp = new System.Windows.Forms.Button();
            btnSpriteMoveDown = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            btnPlay = new System.Windows.Forms.Button();
            tbZoom = new System.Windows.Forms.TrackBar();
            lblZoom = new System.Windows.Forms.Label();
            cbAnimationSets = new System.Windows.Forms.ComboBox();
            btnAddAnimationSet = new System.Windows.Forms.Button();
            btnEditAnimationSet = new System.Windows.Forms.Button();
            btnDeleteAnimationSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbZoom).BeginInit();
            SuspendLayout();
            // 
            // lbSpriteList
            // 
            lbSpriteList.AllowDrop = true;
            lbSpriteList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lbSpriteList.DisplayMember = "Name";
            lbSpriteList.FormattingEnabled = true;
            lbSpriteList.IntegralHeight = false;
            lbSpriteList.ItemHeight = 15;
            lbSpriteList.Location = new System.Drawing.Point(14, 39);
            lbSpriteList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbSpriteList.Name = "lbSpriteList";
            lbSpriteList.Size = new System.Drawing.Size(185, 253);
            lbSpriteList.TabIndex = 0;
            lbSpriteList.Click += lbSpriteList_Click;
            // 
            // previewPanel
            // 
            previewPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            previewPanel.Location = new System.Drawing.Point(217, 65);
            previewPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new System.Drawing.Size(305, 227);
            previewPanel.TabIndex = 1;
            previewPanel.Paint += previewPanel_Paint;
            // 
            // tbSpeed
            // 
            tbSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbSpeed.LargeChange = 1;
            tbSpeed.Location = new System.Drawing.Point(297, 10);
            tbSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbSpeed.Maximum = 8;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new System.Drawing.Size(153, 45);
            tbSpeed.TabIndex = 2;
            tbSpeed.Value = 6;
            tbSpeed.ValueChanged += tbSpeed_ValueChanged;
            // 
            // lbMode
            // 
            lbMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbMode.FormattingEnabled = true;
            lbMode.ItemHeight = 15;
            lbMode.Items.AddRange(new object[] { "Cyclic", "Yo-yo", "One shot" });
            lbMode.Location = new System.Drawing.Point(458, 10);
            lbMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbMode.Name = "lbMode";
            lbMode.Size = new System.Drawing.Size(64, 49);
            lbMode.TabIndex = 3;
            // 
            // lblFast
            // 
            lblFast.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFast.AutoSize = true;
            lblFast.Location = new System.Drawing.Point(305, 47);
            lblFast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFast.Name = "lblFast";
            lblFast.Size = new System.Drawing.Size(28, 15);
            lblFast.TabIndex = 4;
            lblFast.Text = "Fast";
            // 
            // lblSlow
            // 
            lblSlow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSlow.AutoSize = true;
            lblSlow.Location = new System.Drawing.Point(415, 47);
            lblSlow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSlow.Name = "lblSlow";
            lblSlow.Size = new System.Drawing.Size(32, 15);
            lblSlow.TabIndex = 5;
            lblSlow.Text = "Slow";
            // 
            // btnDeleteSprite
            // 
            btnDeleteSprite.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeleteSprite.Image = Properties.Resources.remove;
            btnDeleteSprite.Location = new System.Drawing.Point(14, 295);
            btnDeleteSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteSprite.Name = "btnDeleteSprite";
            btnDeleteSprite.Size = new System.Drawing.Size(28, 28);
            btnDeleteSprite.TabIndex = 6;
            btnDeleteSprite.UseVisualStyleBackColor = true;
            btnDeleteSprite.Click += btnDelete_Click;
            // 
            // btnSpriteMoveUp
            // 
            btnSpriteMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSpriteMoveUp.Image = Properties.Resources.moveup;
            btnSpriteMoveUp.Location = new System.Drawing.Point(42, 295);
            btnSpriteMoveUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSpriteMoveUp.Name = "btnSpriteMoveUp";
            btnSpriteMoveUp.Size = new System.Drawing.Size(28, 28);
            btnSpriteMoveUp.TabIndex = 7;
            btnSpriteMoveUp.UseVisualStyleBackColor = true;
            btnSpriteMoveUp.Click += btnSpriteMoveUp_Click;
            // 
            // btnSpriteMoveDown
            // 
            btnSpriteMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSpriteMoveDown.Image = Properties.Resources.movedown;
            btnSpriteMoveDown.Location = new System.Drawing.Point(71, 295);
            btnSpriteMoveDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSpriteMoveDown.Name = "btnSpriteMoveDown";
            btnSpriteMoveDown.Size = new System.Drawing.Size(28, 28);
            btnSpriteMoveDown.TabIndex = 8;
            btnSpriteMoveDown.UseVisualStyleBackColor = true;
            btnSpriteMoveDown.Click += btnSpriteMoveDown_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnStop.Image = Properties.Resources.Stop;
            btnStop.Location = new System.Drawing.Point(495, 300);
            btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(28, 28);
            btnStop.TabIndex = 9;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnPlay.Image = Properties.Resources.Play;
            btnPlay.Location = new System.Drawing.Point(464, 300);
            btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(28, 28);
            btnPlay.TabIndex = 10;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // tbZoom
            // 
            tbZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tbZoom.Location = new System.Drawing.Point(217, 300);
            tbZoom.Maximum = 50;
            tbZoom.Minimum = 2;
            tbZoom.Name = "tbZoom";
            tbZoom.Size = new System.Drawing.Size(203, 45);
            tbZoom.TabIndex = 11;
            tbZoom.Value = 2;
            tbZoom.Scroll += tbZoom_Scroll;
            // 
            // lblZoom
            // 
            lblZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoom.AutoSize = true;
            lblZoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblZoom.Location = new System.Drawing.Point(419, 308);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new System.Drawing.Size(39, 21);
            lblZoom.TabIndex = 12;
            lblZoom.Text = "x 20";
            // 
            // cbAnimationSets
            // 
            cbAnimationSets.DisplayMember = "Name";
            cbAnimationSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAnimationSets.FormattingEnabled = true;
            cbAnimationSets.Location = new System.Drawing.Point(14, 10);
            cbAnimationSets.Name = "cbAnimationSets";
            cbAnimationSets.Size = new System.Drawing.Size(185, 23);
            cbAnimationSets.TabIndex = 13;
            cbAnimationSets.ValueMember = "Name";
            cbAnimationSets.SelectedValueChanged += cbAnimationSets_SelectedValueChanged;
            // 
            // btnAddAnimationSet
            // 
            btnAddAnimationSet.Image = Properties.Resources.add;
            btnAddAnimationSet.Location = new System.Drawing.Point(206, 10);
            btnAddAnimationSet.Margin = new System.Windows.Forms.Padding(1);
            btnAddAnimationSet.Name = "btnAddAnimationSet";
            btnAddAnimationSet.Size = new System.Drawing.Size(24, 24);
            btnAddAnimationSet.TabIndex = 14;
            btnAddAnimationSet.UseVisualStyleBackColor = true;
            btnAddAnimationSet.Click += btnAddAnimationSet_Click;
            // 
            // btnEditAnimationSet
            // 
            btnEditAnimationSet.Image = Properties.Resources.Pencil;
            btnEditAnimationSet.Location = new System.Drawing.Point(230, 10);
            btnEditAnimationSet.Margin = new System.Windows.Forms.Padding(1);
            btnEditAnimationSet.Name = "btnEditAnimationSet";
            btnEditAnimationSet.Size = new System.Drawing.Size(24, 24);
            btnEditAnimationSet.TabIndex = 15;
            btnEditAnimationSet.UseVisualStyleBackColor = true;
            btnEditAnimationSet.Click += btnEditAnimationSet_Click;
            // 
            // btnDeleteAnimationSet
            // 
            btnDeleteAnimationSet.Image = Properties.Resources.remove;
            btnDeleteAnimationSet.Location = new System.Drawing.Point(254, 10);
            btnDeleteAnimationSet.Margin = new System.Windows.Forms.Padding(1);
            btnDeleteAnimationSet.Name = "btnDeleteAnimationSet";
            btnDeleteAnimationSet.Size = new System.Drawing.Size(24, 24);
            btnDeleteAnimationSet.TabIndex = 16;
            btnDeleteAnimationSet.UseVisualStyleBackColor = true;
            btnDeleteAnimationSet.Click += btnDeleteAnimationSet_Click;
            // 
            // AnimationPreview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(537, 343);
            Controls.Add(btnDeleteAnimationSet);
            Controls.Add(btnEditAnimationSet);
            Controls.Add(btnAddAnimationSet);
            Controls.Add(cbAnimationSets);
            Controls.Add(lblZoom);
            Controls.Add(tbZoom);
            Controls.Add(btnPlay);
            Controls.Add(btnStop);
            Controls.Add(btnSpriteMoveDown);
            Controls.Add(btnSpriteMoveUp);
            Controls.Add(btnDeleteSprite);
            Controls.Add(lblSlow);
            Controls.Add(lblFast);
            Controls.Add(lbMode);
            Controls.Add(tbSpeed);
            Controls.Add(previewPanel);
            Controls.Add(lbSpriteList);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(504, 276);
            Name = "AnimationPreview";
            Text = "Animation previewer";
            FormClosing += AnimationPreview_FormClosing;
            ResizeEnd += AnimationPreview_ResizeEnd;
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ComboBox cbAnimationSets;
        private System.Windows.Forms.Button btnAddAnimationSet;
        private System.Windows.Forms.Button btnEditAnimationSet;
        private System.Windows.Forms.Button btnDeleteAnimationSet;
    }
}