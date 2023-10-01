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
    public partial class NewSpriteDialog : Form
    {
        public int MinSpriteWidth
        {
            get { return (int)numericUpDown1.Minimum; }
            set { numericUpDown1.Minimum = value; }
        }

        public int MaxSpriteWidth
        {
            get { return (int)numericUpDown1.Maximum; }
            set { numericUpDown1.Maximum = value; }
        }

        public int SpriteWidth
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public int MinSpriteHeight
        {
            get { return (int)numericUpDown2.Minimum; }
            set { numericUpDown2.Minimum = value; }
        }

        public int MaxSpriteHeight
        {
            get { return (int)numericUpDown2.Maximum; }
            set { numericUpDown2.Maximum = value; }
        }

        public int SpriteHeight
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public string SpriteName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public NewSpriteDialog()
        {
            InitializeComponent();
            textBox1.GotFocus += new EventHandler(textBox1_GotFocus);
            numericUpDown1.GotFocus += new EventHandler(numericUpDown_GotFocus);
            numericUpDown2.GotFocus += new EventHandler(numericUpDown_GotFocus);
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

        void numericUpDown_GotFocus(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, 100);
        }
    }
}
