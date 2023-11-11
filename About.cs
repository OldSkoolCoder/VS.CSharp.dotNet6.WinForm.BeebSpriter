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

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            string sVersion = String.Format("v{0}.{1}.{2}",
                version.Major,
                version.Minor,
                version.Build);

            string sBuildPackage = "";

            switch (version.MinorRevision)
            {
                case 0:
                    sBuildPackage = "(Development)";
                    break;
                case 1:
                    sBuildPackage = "(Test)";
                    break;
                case 2:
                    sBuildPackage = "(Pre-Release)";
                    break;
                case 3:
                    sBuildPackage = "(Candidate Release)";
                    break;
                default:
                    break;
            }
            lblVersion.Text = String.Format("BeebSpriter {0} {1}", sVersion, sBuildPackage);
            lblBuildDate.Text = "11th November 2023";
        }

    }
}
