using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeebSpriter
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();

            SpriteSheet spriteSheet = SpriteSheetForm.Instance.SpriteSheet;

            spriteLayout1.Checked = false;
            spriteLayout2.Checked = false;
            spriteLayout3.Checked = false;

            switch (spriteSheet.SpriteLayout)
            {
                case SpriteSheet.SpriteDataLayout.RowMajor:
                    spriteLayout1.Checked = true;
                    break;

                case SpriteSheet.SpriteDataLayout.ColumnMajor:
                    spriteLayout2.Checked = true;
                    break;

                case SpriteSheet.SpriteDataLayout.Linear:
                    spriteLayout3.Checked = true;
                    break;
            }

            spriteSizeAcross.Value = spriteSheet.SubSpriteWidth;
            spriteSizeDown.Value = spriteSheet.SubSpriteHeight;
            if (spriteSheet.ShouldBreakSprites)
            {
                spriteSize1.Checked = false;
                spriteSize2.Checked = true;
                spriteSizeAcross.Enabled = true;
                spriteSizeDown.Enabled = true;
                spriteSizeAcrossLabel.Enabled = true;
                spriteSizeDownLabel.Enabled = true;
            }

            if (spriteSheet.ShouldExportSeparateMask)
            {
                masking1.Checked = false;
                masking2.Checked = true;
            }

            headerTextBox.Text = spriteSheet.AssemblerSyntax;
            if (!spriteSheet.ShouldGenerateHeader)
            {
                headerTickBox.Checked = false;
                headerTextBox.Enabled = false;
                headerLabel.Enabled = false;
            }
        }

        private void spriteSize2_CheckedChanged(object sender, EventArgs e)
        {
            spriteSizeAcross.Enabled = spriteSize2.Checked;
            spriteSizeDown.Enabled = spriteSize2.Checked;
            spriteSizeAcrossLabel.Enabled = spriteSize2.Checked;
            spriteSizeDownLabel.Enabled = spriteSize2.Checked;
        }

        private void headerTickBox_CheckedChanged(object sender, EventArgs e)
        {
            headerTextBox.Enabled = headerTickBox.Checked;
            headerLabel.Enabled = headerTickBox.Checked;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SpriteSheet spriteSheet = SpriteSheetForm.Instance.SpriteSheet;

            if (spriteLayout1.Checked)
            {
                spriteSheet.SpriteLayout = SpriteSheet.SpriteDataLayout.RowMajor;
            }
            else if (spriteLayout2.Checked)
            {
                spriteSheet.SpriteLayout = SpriteSheet.SpriteDataLayout.ColumnMajor;
            }
            else if (spriteLayout3.Checked)
            {
                spriteSheet.SpriteLayout = SpriteSheet.SpriteDataLayout.Linear;
            }

            spriteSheet.SubSpriteWidth = (int)spriteSizeAcross.Value;
            spriteSheet.SubSpriteHeight = (int)spriteSizeDown.Value;
            spriteSheet.ShouldBreakSprites = spriteSize2.Checked;

            spriteSheet.ShouldExportSeparateMask = masking2.Checked;

            spriteSheet.AssemblerSyntax = headerTextBox.Text;
            spriteSheet.ShouldGenerateHeader = headerTickBox.Checked;

            spriteSheet.HasSetExportSettings = true;

            SpriteSheetForm.Instance.IsUnsaved = true;
        }
    }
}
