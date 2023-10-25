using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using BeebSpriter.Properties;

namespace BeebSpriter.Controls
{
    partial class Canvas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param nathis="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required thisthod for Designer support - do not modify
        /// the contents of this thisthod with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            BringObjectToFront = new System.Windows.Forms.ToolStripMenuItem();
            SendObjectToBack = new System.Windows.Forms.ToolStripMenuItem();
            BringObjectForward = new System.Windows.Forms.ToolStripMenuItem();
            SendObjectBackward = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            CutObject = new System.Windows.Forms.ToolStripMenuItem();
            CopyObject = new System.Windows.Forms.ToolStripMenuItem();
            PasteObject = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            DeleteObject = new System.Windows.Forms.ToolStripMenuItem();
            ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { BringObjectToFront, SendObjectToBack, BringObjectForward, SendObjectBackward, ToolStripSeparator1, CutObject, CopyObject, PasteObject, ToolStripSeparator2, DeleteObject });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new System.Drawing.Size(453, 610);
            ContextMenuStrip1.Opening += ContextMenuStrip1_Opening;
            // 
            // BringObjectToFront
            // 
            BringObjectToFront.Image = Resources.BringToFront;
            BringObjectToFront.Name = "BringObjectToFront";
            BringObjectToFront.Size = new System.Drawing.Size(452, 58);
            BringObjectToFront.Text = "Bring to Front";
            BringObjectForward.Click += BringObjectToFront_Click;
            // 
            // SendObjectToBack
            // 
            SendObjectToBack.Image = Resources.SendToBack;
            SendObjectToBack.Name = "SendObjectToBack";
            SendObjectToBack.Size = new System.Drawing.Size(452, 58);
            SendObjectToBack.Text = "Send to Back";
            SendObjectToBack.Click += SendObjectToBack_Click;
            // 
            // BringObjectForward
            // 
            BringObjectForward.Image = Resources.BringForward;
            BringObjectForward.Name = "BringObjectForward";
            BringObjectForward.Size = new System.Drawing.Size(452, 58);
            BringObjectForward.Text = "Bring Forward";
            BringObjectForward.Click += BringObjectForward_Click;
            // 
            // SendObjectBackward
            // 
            SendObjectBackward.Image = Resources.SendBackward;
            SendObjectBackward.Name = "SendObjectBackward";
            SendObjectBackward.Size = new System.Drawing.Size(452, 58);
            SendObjectBackward.Text = "Send Backward";
            SendObjectBackward.Click += SendObjectBackward_Click;
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new System.Drawing.Size(449, 6);
            // 
            // CutObject
            // 
            CutObject.Name = "CutObject";
            CutObject.Size = new System.Drawing.Size(452, 58);
            CutObject.Text = "Cut";
            CutObject.Click += CutSelectedItems_Click;
            // 
            // CopyObject
            // 
            CopyObject.Name = "CopyObject";
            CopyObject.Size = new System.Drawing.Size(452, 58);
            CopyObject.Text = "Copy";
            CopyObject.Click += CopySelectedItems_Click;
            // 
            // PasteObject
            // 
            PasteObject.Name = "PasteObject";
            PasteObject.Size = new System.Drawing.Size(452, 58);
            PasteObject.Text = "Paste";
            PasteObject.Click += PasteSelectedItems_CLick;
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new System.Drawing.Size(449, 6);
            // 
            // DeleteObject
            // 
            DeleteObject.Image = Resources.DeleteObject;
            DeleteObject.Name = "DeleteObject";
            DeleteObject.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            DeleteObject.Size = new System.Drawing.Size(452, 58);
            DeleteObject.Text = "Delete";
            DeleteObject.Click += DeleteSelectedItems_Click;
        
            // 
            // Canvas
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ContextMenuStrip = ContextMenuStrip1;
            this.Name = "Canvas";
            ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BringObjectToFront;
        private System.Windows.Forms.ToolStripMenuItem SendObjectToBack;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CutObject;
        private System.Windows.Forms.ToolStripMenuItem CopyObject;
        private System.Windows.Forms.ToolStripMenuItem PasteObject;
        private System.Windows.Forms.ToolStripMenuItem DeleteObject;
        private System.Windows.Forms.ToolStripMenuItem BringObjectForward;
        private System.Windows.Forms.ToolStripMenuItem SendObjectBackward;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        
    }
}
