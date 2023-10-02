using System.Windows.Forms;

namespace BeebSpriter
{
    public partial class ReplaceColour : Form
    {
        public int OldColour => ColourComboBox1.SelectedIndex;

        public int NewColour => ColourComboBox2.SelectedIndex;

        public ReplaceColour(Sprite sprite)
        {
            InitializeComponent();

            ColourComboBox1.AddPalette(sprite);
            ColourComboBox2.AddPalette(sprite);
        }
    }
}