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
    public partial class ResizeDialog : Form
    {
        public int SpriteWidth
        {
            get { return (int)numericWidth.Value; }
            set { numericWidth.Value = value; }
        }

        public int SpriteHeight
        {
            get { return (int)numericHeight.Value; }
            set { numericHeight.Value = value; }
        }

        public ResizeDialog()
        {
            InitializeComponent();
            numericWidth.GotFocus += new EventHandler(numericUpDown_GotFocus);
            numericHeight.GotFocus += new EventHandler(numericUpDown_GotFocus);

        }

        protected override void OnShown(EventArgs e)
        {
            numericWidth.Focus();
            base.OnShown(e);
        }

        void numericUpDown_GotFocus(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, 100);
        }

    }
}
