using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BeebSpriter
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            lblVersion.Text = String.Format("BeebSpriter v{0} {1}", Application.ProductVersion, "(Pre-Release)");
        }
    }
}
