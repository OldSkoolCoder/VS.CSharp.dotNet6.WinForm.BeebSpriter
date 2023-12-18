using BeebSpriter.Internal;
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
    public partial class CopySpriteDialog : Form
    {
        public string SpriteName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public CopySpriteDialog()
        {
            InitializeComponent();
            textBox1.GotFocus += new EventHandler(textBox1_GotFocus);
        }

        protected override void OnShown(EventArgs e)
        {
            textBox1.Focus();
            base.OnShown(e);
        }

        void textBox1_GotFocus(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string sError = Helper.CheckNameOfSprite(SpriteSheetForm.Instance.SpriteSheet.SpriteList, textBox1.Text, ref textBox1);

            if (sError != "")
            {
                e.Cancel = true;
                this.epError.SetError(textBox1, sError);
            }

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            this.epError.SetError(textBox1, "");
        }
    }
}
