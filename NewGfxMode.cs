using BeebSpriter.Enum;
using BeebSpriter.Internal;
using System;
using System.Windows.Forms;

namespace BeebSpriter
{
    public partial class NewGfxMode : Form
    {
        /// <summary>
        /// Get Selected mode chosen from dropdown
        /// </summary>
        public int SelectedMode => (int)Extensions.ToEnum<GfxModeType>(ComboBoxGfxMode.SelectedItem.ToString());

        /// <summary>
        /// Initialise the new Gfx Mode Form
        /// </summary>
        /// <param name="gfxModeType"></param>
        public NewGfxMode(GfxModeType gfxModeType)
        {
            InitializeComponent();

            TextBoxCurrentGfxMode.Text = gfxModeType.ToDescription();
            TextBoxCurrentGfxMode.ReadOnly = true; // Lock the field
        }

        /// <summary>
        /// Load mode information into controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGfxMode_Load(object sender, EventArgs e)
        {
            ComboBoxGfxMode.Items.Clear();

            foreach (var itm in System.Enum.GetValues(typeof(GfxModeType)))
            {
                ComboBoxGfxMode.Items.Add(itm.ToDescription());
            }

            ComboBoxGfxMode.SelectedIndex = 0;
        }

        /// <summary>
        /// OK Button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Cancel Button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}