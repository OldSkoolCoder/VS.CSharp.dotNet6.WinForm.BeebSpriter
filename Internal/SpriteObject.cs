using BeebSpriter.Enum;
using System;
using System.Drawing;

namespace BeebSpriter.Internal
{
    public class SpriteObject
    {
        private Rectangle m_Rect;

        public Guid Guid { get; set; }
        public bool Selected { get; set; }
        public Pen Pen { get; set; }
        public Color BackColour { get; set; }

        public NodeLocation SelectedNode { get; set; }

        public Node HoverNode = new();

        public Rectangle Rect
        { get { return m_Rect; } set { m_Rect = value; } }

        /// <summary>
        /// Gets or sets the coordinates of the upper-left corner of this system.Drawing.Rectangle structure.
        /// </summary>
        public Point Location
        { get { return m_Rect.Location; } set { m_Rect.Location = value; } }

        /// <summary>
        /// Gets or sets the size of this System.Drawing.Rectangle.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Size Size
        { get { return m_Rect.Size; } set { m_Rect.Size = value; } }

        /// <summary>
        /// Creates a new base object.
        /// </summary>
        /// <remarks></remarks>
        public SpriteObject()
        {
            Guid = Guid.NewGuid();
            Selected = true;
            SelectedNode = NodeLocation.None;
            Pen = new Pen(Color.Red);

            BackColour = Color.Transparent;
        }

        /// <summary>
        /// Creates a new base object.
        /// </summary>
        /// <param name="item"></param>
        /// <remarks></remarks>
        public SpriteObject(SpriteObject item)
        {
            Guid = Guid.NewGuid();
            Selected = true;
            SelectedNode = NodeLocation.None;
            Pen = new Pen(item.Pen.Color);

            m_Rect = item.Rect;
            BackColour = Color.Transparent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SpriteObject Clone()
        {
            return new SpriteObject(this);
        }

        /// <summary>
        /// Indicates whether the specified point is contained within the object.
        /// </summary>
        /// <param name="pnt"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool Contains(Point pnt)
        {
            return m_Rect.Contains(pnt);
        }

        /// <summary>
        /// Moves the object by the specified amount.
        /// </summary>
        /// <param name="pnt"></param>
        /// <remarks></remarks>
        public void Move(Point pnt)
        {
            m_Rect.Location = Point.Add(m_Rect.Location, (Size)pnt);
        }

        /// <summary>
        /// Resizes the object by the specified amount.
        /// </summary>
        /// <param name="SelectedNode"></param>
        /// <param name="pnt"></param>
        /// <remarks></remarks>
        public void Resize(NodeLocation SelectedNode, Point pnt)
        {
            switch (SelectedNode)
            {
                case NodeLocation.LeftTop:
                    {
                        m_Rect.X += pnt.X;
                        m_Rect.Y += pnt.Y;
                        m_Rect.Width -= pnt.X;
                        m_Rect.Height -= pnt.Y;
                        break;
                    }
                case NodeLocation.LeftMiddle:
                    {
                        m_Rect.X += pnt.X;
                        m_Rect.Width -= pnt.X;
                        break;
                    }
                case NodeLocation.LeftBottom:
                    {
                        m_Rect.X += pnt.X;
                        m_Rect.Width -= pnt.X;
                        m_Rect.Height += pnt.Y;
                        break;
                    }
                case NodeLocation.TopMiddle:
                    {
                        m_Rect.Y += pnt.Y;
                        m_Rect.Height -= pnt.Y;
                        break;
                    }
                case NodeLocation.BottomMiddle:
                    {
                        m_Rect.Height += pnt.Y;
                        break;
                    }
                case NodeLocation.RightTop:
                    {
                        m_Rect.Y += pnt.Y;
                        m_Rect.Width += pnt.X;
                        m_Rect.Height -= pnt.Y;
                        break;
                    }
                case NodeLocation.RightMiddle:
                    {
                        m_Rect.Width += pnt.X;
                        break;
                    }
                case NodeLocation.RightBottom:
                    {
                        m_Rect.Width += pnt.X;
                        m_Rect.Height += pnt.Y;
                        break;
                    }
            }
        }

        /// <summary>
        /// Gets the selected node that the mouse is over.
        /// </summary>
        /// <param name="pnt"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool HoverSelectedNode(Point pnt)
        {
            SelectedNode = HoverNode.HoverSelectedNode(pnt, Rect);

            if (SelectedNode == NodeLocation.None)
                return false;

            return true;
        }

        
    }
}