using BeebSpriter.Enum;
using BeebSpriter.Internal;
using System.Drawing;
using System.Windows.Forms;

namespace BeebSpriter.Controls
{
    [ToolboxBitmap(typeof(ComboBox))]
    internal class ColourComboBox : ComboBox
    {
        /// <summary>
        ///
        /// </summary>
        public class ColourInfo
        {
            public string Text { get; set; }
            public Color Color { get; set; }

            /// <summary>
            ///
            /// </summary>
            /// <param name="text"></param>
            /// <param name="color"></param>
            public ColourInfo(string text, Color color)
            {
                Text = text;
                Color = color;
            }
        }

        /// <summary>
        /// Represents a Windows colour combo box control.
        /// </summary>
        public ColourComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        /// <summary>
        /// Create the palete from the sprite data
        /// </summary>
        /// <param name="sprite"></param>
        public void AddPalette(Sprite sprite)
        {
            Items.Clear();

            for (int i = 0; i < sprite.Palette.Length; i++)
            {
                Color spriteColour = BeebPalette.GetWindowsColour(sprite.Palette[i]);
                Items.Add(new ColourInfo(((BeebColourType)i).ToDescription(), spriteColour)); //(BeebColourType[i]   sprite.Palette[i]), spriteColour)); ;
            }

            SelectedIndex = 0;
        }

        /// <summary>
        /// Occurs when a visual aspect of an owner-drawn <see cref="ComboBox"></see> changes.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                ColourInfo current = (ColourInfo)Items[e.Index];

                Rectangle rect = new(4, e.Bounds.Top + 2, 21, e.Bounds.Height - 5);

                using SolidBrush brush = new(current.Color);
                e.Graphics.FillRectangle(brush, rect);
                e.Graphics.DrawRectangle(Pens.Black, rect);

                using SolidBrush brush2 = new(Color.Black);
                e.Graphics.DrawString(string.Format("{0:#0} {1}", e.Index, current.Text), Font, brush2, 30, ((e.Bounds.Height - Font.Height) / 2) + e.Bounds.Top);
            }
        }

        /// <summary>
        /// Gets or sets the currently selected item.
        /// </summary>
        public new ColourInfo SelectedItem
        {
            get
            {
                return (ColourInfo)base.SelectedItem;
            }
            set
            {
                base.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets the text of the selected item, or sets the selection to
        /// the item with the specified text.
        /// </summary>
        public new string SelectedText
        {
            get
            {
                if (SelectedIndex >= 0)
                    return SelectedItem.Text;

                return string.Empty;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    if (((ColourInfo)Items[i]).Text == value)
                    {
                        SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the value of the selected item, or sets the selection to
        /// the item with the specified value.
        /// </summary>
        public new Color SelectedValue
        {
            get
            {
                if (SelectedIndex >= 0)
                    return SelectedItem.Color;
                return Color.White;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    if (((ColourInfo)Items[i]).Color == value)
                    {
                        SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}