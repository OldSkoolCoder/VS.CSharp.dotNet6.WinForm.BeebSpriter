using BeebSpriter.Enum;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeebSpriter.Internal
{
    public class Node
    {
        public const int NODE_SIZE = 8;

        private readonly Cursor[] arrow = new Cursor[] {
            Cursors.Default,
            Cursors.SizeNWSE,
            Cursors.SizeNS,
            Cursors.SizeNESW,
            Cursors.SizeWE,
            Cursors.SizeNWSE,
            Cursors.SizeNS,
            Cursors.SizeNESW,
            Cursors.SizeWE,
            Cursors.SizeAll
        };

        public Color Colour { get; set; }
        public Color SelectedColour { get; set; }
        public Color ActiveColour { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Node()
        {
            Colour = Color.White;
            SelectedColour = Color.LightSteelBlue;
            ActiveColour = Color.RoyalBlue;
        }

        /// <summary>
        /// Gets the cursor type of the node.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public Cursor Arrow(NodeLocation value)
        {
            return arrow[(int)value];
        }

        /// <summary>
        /// Gets the ENUM type of the node at the specified location.
        /// </summary>
        /// <param name="pnt"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public NodeLocation HoverSelectedNode(Point pnt, Rectangle rect)
        {
            var erect = rect;
            erect.Inflate(NODE_SIZE, NODE_SIZE);

            if (erect.Contains(pnt))
            {
                foreach (NodeLocation pos in System.Enum.GetValues(typeof(NodeLocation)))
                {
                    Rectangle noderect = GetRect(pos, rect);
                    if (pnt.X >= noderect.Left && pnt.X <= noderect.Right && pnt.Y >= noderect.Top && pnt.Y <= noderect.Bottom)
                    {
                        return pos;
                    }
                }
            }

            return NodeLocation.None;
        }

        /// <summary>
        /// Gets a node based of the node location.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public Rectangle GetRect(NodeLocation value, Rectangle rect)
        {
            return value switch
            {
                NodeLocation.LeftTop => CreateNode(rect.Left, rect.Top),
                NodeLocation.LeftMiddle => CreateNode(rect.Left, (rect.Top + rect.Bottom) / 2),
                NodeLocation.LeftBottom => CreateNode(rect.Left, rect.Bottom),
                NodeLocation.TopMiddle => CreateNode((rect.Left + rect.Right) / 2, rect.Top),
                NodeLocation.BottomMiddle => CreateNode((rect.Left + rect.Right) / 2, rect.Bottom),
                NodeLocation.RightTop => CreateNode(rect.Right, rect.Top),
                NodeLocation.RightMiddle => CreateNode(rect.Right, (rect.Top + rect.Bottom) / 2),
                NodeLocation.RightBottom => CreateNode(rect.Right, rect.Bottom),
                NodeLocation.Everything => rect,
                _ => default,
            };
        }

        /// <summary>
        /// Creates a node at the specified location.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private Rectangle CreateNode(int x, int y)
        {
            return new Rectangle((int)Math.Round(x - NODE_SIZE / 2d), (int)Math.Round(y - NODE_SIZE / 2d), NODE_SIZE, NODE_SIZE);
        }
    }
}