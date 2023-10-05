using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            rbBeebASM.Checked = false;
            rbKickASM.Checked = false;

            switch (spriteSheet.SelectedAssembler)
            {
                case "BeebASM":
                    rbBeebASM.Checked = true;
                    break;
                case "KickASM":
                    rbKickASM.Checked = true;
                    break;
            }

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
                lblSpriteSizeAcross.Enabled = true;
                lblSpriteSizeDown.Enabled = true;
            }

            if (spriteSheet.ShouldExportSeparateMask)
            {
                masking1.Checked = false;
                masking2.Checked = true;
            }

            txtHeader.Text = spriteSheet.AssemblerSyntax;
            if (!spriteSheet.ShouldGenerateHeader)
            {
                chkHeader.Checked = false;
                txtHeader.Enabled = false;
                lblHeader.Enabled = false;
            }

            txtPreview.Text = spriteSheet.PreviewExport(SpriteSheetForm.Instance.SpriteSheet.SelectedAssembler, SpriteSheetForm.Instance.ProjectFilename);
        }

        private void spriteSize2_CheckedChanged(object sender, EventArgs e)
        {
            spriteSizeAcross.Enabled = spriteSize2.Checked;
            spriteSizeDown.Enabled = spriteSize2.Checked;
            lblSpriteSizeAcross.Enabled = spriteSize2.Checked;
            lblSpriteSizeDown.Enabled = spriteSize2.Checked;
        }

        private void chkHeader_CheckedChanged(object sender, EventArgs e)
        {
            txtHeader.Enabled = chkHeader.Checked;
            lblHeader.Enabled = chkHeader.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
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

            spriteSheet.AssemblerSyntax = txtHeader.Text;
            spriteSheet.ShouldGenerateHeader = chkHeader.Checked;

            spriteSheet.HasSetExportSettings = true;

            SpriteSheetForm.Instance.IsUnsaved = true;
        }

        private void txtHeader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Return)
            {
                SpriteSheetForm.Instance.SpriteSheet.AssemblerSyntax = txtHeader.Text;
                txtPreview.Text = SpriteSheetForm.Instance.SpriteSheet.PreviewExport(SpriteSheetForm.Instance.SpriteSheet.SelectedAssembler, SpriteSheetForm.Instance.ProjectFilename);
                e.SuppressKeyPress = true;
            }
        }

        private void rbBeebASM_CheckedChanged(object sender, EventArgs e)
        {
            SpriteSheetForm.Instance.SpriteSheet.AssemblerSyntax = txtHeader.Text;
            SpriteSheetForm.Instance.SpriteSheet.SelectedAssembler = "BeebASM";
            txtPreview.Text = SpriteSheetForm.Instance.SpriteSheet.PreviewExport(SpriteSheetForm.Instance.SpriteSheet.SelectedAssembler, SpriteSheetForm.Instance.ProjectFilename);
        }

        private void rbKickASM_CheckedChanged(object sender, EventArgs e)
        {
            SpriteSheetForm.Instance.SpriteSheet.AssemblerSyntax = txtHeader.Text;
            SpriteSheetForm.Instance.SpriteSheet.SelectedAssembler = "KickASM";
            txtPreview.Text = SpriteSheetForm.Instance.SpriteSheet.PreviewExport(SpriteSheetForm.Instance.SpriteSheet.SelectedAssembler, SpriteSheetForm.Instance.ProjectFilename);
        }
    }
}
