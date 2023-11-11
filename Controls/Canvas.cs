using BeebSpriter.Enum;
using BeebSpriter.Internal;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BeebSpriter.Controls
{
    public partial class Canvas : ScrollableControl
    {
        [Browsable(false)]
        public SpriteObjectList SpriteObjectList { get; set; }

        public int ZoomFactor { get; set; }
        public Bitmap Image { get; set; }
        public Bitmap OriginalImage { get; set; }
        public Size ImageSize { get; set; }
        public Rectangle ImageRect { get; private set; }
        public Pen PixelPenGrid { get; set; }
        public Pen SpritePenGrid { get; set; }
        public bool ShowGrid { get; set; }
        public bool CenterImage { get; set; }
        public Point PixelAspectRatio { get; set; }

        private bool mouseDown = false;
        private bool mouseDragging = false;
        private Point mouseStartPos;
        private Point mouseEndPos;
        private Point mousePos;

        private bool spritesMove;
        private bool spritesResize;

        private bool ctrlKey;

        private readonly Node node = new();

        public event SpriteClickedEventHandler SpriteClicked;

        public delegate void SpriteClickedEventHandler(object sender, ActiveSpriteEventArgs e);

        public event SpritesCreatedEventHandler SpritesCreated;

        public delegate void SpritesCreatedEventHandler(object sender, SelectedSpritesEventArgs e);

        public event SpritesResizingEventHandler SpritesResizing;

        public delegate void SpritesResizingEventHandler(object sender, SelectedSpritesEventArgs e);

        public event SpritesResizedEventHandler SpritesResized;

        public delegate void SpritesResizedEventHandler(object sender, SelectedSpritesEventArgs e);

        public event SpritessMovingEventHandler SpritesMoving;

        public delegate void SpritessMovingEventHandler(object sender, SelectedSpritesEventArgs e);

        public event SpritesMovedEventHandler SpritesMoved;

        public delegate void SpritesMovedEventHandler(object sender, SelectedSpritesEventArgs e);

        public event SpritesDeletedEventHandler SpritesDeleted;

        public delegate void SpritesDeletedEventHandler(object sender, SelectedSpritesEventArgs e);

        public Canvas()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            ZoomFactor = 1;

            SpriteObjectList = new SpriteObjectList();

            CenterImage = false;

            PixelAspectRatio = new Point(1, 1);

            PixelPenGrid = new Pen(SystemColors.ControlDarkDark)
            {
                Width = 1f,
                DashStyle = DashStyle.Dash
            };

            SpritePenGrid = new Pen(Color.Aquamarine)
            {
                Width = 1f,
                DashStyle = DashStyle.Dash
            };
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {
            Image = (Bitmap)System.Drawing.Image.FromFile(fileName);

            OriginalImage = (Bitmap)Image.Clone();

            ImageSize = new Size(Image.Width, Image.Height);

            Animate(true);

            Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        public new void Invalidate()
        {
            if (Image != null)
            {
                int x = 0;
                int y = 0;
                int width = ImageSize.Width * PixelAspectRatio.X * ZoomFactor;
                int height = ImageSize.Height * PixelAspectRatio.Y * ZoomFactor;

                AutoScrollMinSize = new Size(width, height);

                if (CenterImage)
                {
                    x = (ClientRectangle.Width / 2) - (width / 2);
                    y = (ClientRectangle.Height / 2) - (height / 2);
                }

                ImageRect = new Rectangle(x, y, width, height);
            }

            base.Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="animate"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Animate(bool animate)
        {
            if (Image != null)
            {
                if (animate)
                {
                    ImageAnimator.Animate(Image, new EventHandler(OnFrameChanged));
                }
                else
                {
                    ImageAnimator.StopAnimate(Image, new EventHandler(OnFrameChanged));
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler(OnFrameChanged), sender, e);
                return;
            }

            Invalidate();
        }

        /// <summary>
        /// Raises the MouseDown event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Focus();

                mouseDown = true;

                mousePos = ConvertMouseCoords(e.Location);
                mouseStartPos = mousePos;
                mouseEndPos = mousePos;
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        /// Raises the MouseMove event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            mousePos = ConvertMouseCoords(e.Location);
            
            if (mouseDown)
            {
                mouseEndPos = mousePos;//ConvertMouseCoords(e.Location);
                
                if (mouseEndPos != mouseStartPos)
                {
                    if (SpriteObjectList.SelectedItems.Count > 0)
                    {
                        Point pt = ConvertZoomFactor(mouseEndPos);
                        Size sz = (Size)ConvertZoomFactor(mouseStartPos);

                        MoveSpriteObject(pt, sz);
                    }

                    mouseDragging = true;
                    Invalidate();
                }
            }
            else
            {
                Point pnt = ConvertZoomFactor(mousePos);

                NodeLocation LastActiveNode = SpriteObjectList.ActiveNode;

                SpriteObjectList.HoverSelectedNode(pnt);

                if (LastActiveNode != SpriteObjectList.ActiveNode)
                {
                    Invalidate();
                }
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        /// Raises the MouseUp event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            mousePos = ConvertMouseCoords(e.Location);

            if (mouseDown)
            {
                if (mouseDragging)
                {
                    mouseDragging = false;

                    if (spritesMove)
                    {
                        spritesMove = false;
                        SpritesMoved?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
                    }
                    else if (spritesResize)
                    {
                        foreach (SpriteObject itm in SpriteObjectList.SelectedItems)
                        {
                            itm.Rect = SwapRect(itm.Rect);
                        }
                        spritesResize = false;
                        SpritesResized?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
                    }
                    else
                    {
                        CreateSpriteObject();
                    }
                }
                else
                {
                    SpriteObjectList.Capture(ConvertZoomFactor(mousePos), ctrlKey);

                    SpriteClicked?.Invoke(this, new ActiveSpriteEventArgs(SpriteObjectList.ActiveSprite));
                    Invalidate();
                }

                mouseDown = false;
            }

            base.OnMouseUp(e);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public Point ConvertMouseCoords(Point point)
        {
            Point newPoint = Point.Subtract(point, (Size)AutoScrollPosition);

            return newPoint;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public Point ConvertZoomFactor(Point point)
        {
            Point newPoint = point;//Point.Subtract(point, (Size)AutoScrollPosition);
            newPoint.X /= ZoomFactor;
            newPoint.Y /= ZoomFactor;

            return newPoint;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

            if (Image != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.CompositingMode = CompositingMode.SourceCopy;
                e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

                ImageAnimator.UpdateFrames(Image);

                e.Graphics.DrawImage(Image, ImageRect);

                if (ShowGrid)
                {
                    PaintGrid(e.Graphics, ImageRect, (Size)PixelAspectRatio, PixelPenGrid);
                }

                // Draw rectangles around current defined sprites
                foreach (SpriteObject itm in SpriteObjectList.Items)
                {
                    DrawSprites(e.Graphics, itm);
                }

                // Draw Selected Nodes - first one is active
                bool Active = true;
                foreach (SpriteObject obj in SpriteObjectList.SelectedItems)
                {
                    DrawNodes(e.Graphics, obj.Rect, Active);
                    Active = false;
                }

                // Draw Active Node
                foreach (SpriteObject itm in SpriteObjectList.SelectedItems)
                {
                    if (DrawActiveNode(e.Graphics, itm)) break;
                }

                DrawRubberband(e.Graphics);
            }

            base.OnPaint(e);
        }

        /// <summary>
        /// Paint the pixel grid
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="rect"></param>
        /// <param name="gridSize"></param>
        /// <param name="pen"></param>
        private void PaintGrid(Graphics gfx, Rectangle rect, Size gridSize, Pen pen)
        {
            int GridXOffset = gridSize.Width * ZoomFactor;

            for (int x = GridXOffset; x < rect.Width; x += GridXOffset)
            {
                gfx.DrawLine(pen, rect.X + x, rect.Y, rect.X + x, rect.Y + rect.Height);
            }

            int GridYOffset = gridSize.Height * ZoomFactor;

            for (int y = GridYOffset; y < rect.Height; y += GridYOffset)
            {
                gfx.DrawLine(pen, rect.X, rect.Y + y, rect.X + rect.Width, rect.Y + y);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="gfx"></param>
        private void DrawRubberband(Graphics gfx)
        {
            if (mouseDragging)
            {
                Point location = ConvertZoomFactor(mouseStartPos);
                Size size = (Size)ConvertZoomFactor(Point.Subtract(mouseEndPos, (Size)mouseStartPos));
                
                //Point location = ConvertMouseCoords(mouseStartPos);
                //Size size = (Size)ConvertMouseCoords(Point.Subtract(mouseEndPos, (Size)mouseStartPos));

                Rectangle newRect = new(location, size);

                DrawNodes(gfx, newRect, true);
            }
        }
   
        /// <summary>
        ///
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="spriteObject"></param>
        private void DrawSprites(Graphics gfx, SpriteObject spriteObject)
        {
            Rectangle rect = spriteObject.Rect.Resize(ZoomFactor);//SwapRect(spriteObject.Rect).Resize(ZoomFactor);
            gfx.DrawRectangle(spriteObject.Pen, rect);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool DrawActiveNode(Graphics gfx, SpriteObject obj)
        {
            if (obj.SelectedNode != NodeLocation.None)
            {
                Cursor = node.Arrow(obj.SelectedNode);

                if (obj.SelectedNode != NodeLocation.Everything)
                {             
                    Rectangle noderect = node.GetRect(obj.SelectedNode, obj.Rect.Resize(ZoomFactor));

                    DrawNode(gfx, noderect, node.ActiveColour);
                }

                SpriteObjectList.ActiveSprite = obj;
                return true;
            }

            Cursor = Cursors.Default;
            return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="rect"></param>
        /// <param name="Active"></param>
        private void DrawNodes(Graphics gfx, Rectangle rect, bool Active)
        {
            Rectangle newRect = SwapRect(rect).Resize(ZoomFactor);

            Pen pen = new(Color.Black)
            {
                DashStyle = DashStyle.Dash
            };

            gfx.DrawRectangle(pen, newRect);
            

            foreach (NodeLocation node in System.Enum.GetValues(typeof(NodeLocation)))
            {
                if (node != NodeLocation.Everything)
                {
                    Rectangle noderect = this.node.GetRect(node, newRect);

                    if (Active)
                    {
                        DrawNode(gfx, noderect, this.node.SelectedColour);
                    }
                    else
                    {
                        DrawNode(gfx, noderect, this.node.Colour);
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="rect"></param>
        /// <param name="col"></param>
        private void DrawNode(Graphics gfx, Rectangle rect, Color col)
        {
            using var solidBrush = new SolidBrush(col);
            gfx.FillEllipse(solidBrush, rect);
            gfx.DrawEllipse(Pens.Black, rect);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Tab:
                    SpriteObjectList.NextObject();
                    SpriteClicked?.Invoke(this, new ActiveSpriteEventArgs(SpriteObjectList.ActiveSprite));
                    Invalidate();
                    return true;

                case Keys.Shift | Keys.Tab:
                    SpriteObjectList.PreviousObject();
                    SpriteClicked?.Invoke(this, new ActiveSpriteEventArgs(SpriteObjectList.ActiveSprite));
                    Invalidate();
                    return true;

                case Keys.Left:
                    MoveSelectedItems(new Point(-5, 0));
                    return true;

                case Keys.Right:
                    MoveSelectedItems(new Point(5, 0));
                    return true;

                case Keys.Up:
                    MoveSelectedItems(new Point(0, -5));
                    return true;

                case Keys.Down:
                    MoveSelectedItems(new Point(0, 5));
                    return true;

                default: return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        /// <summary>
        /// Raises the KeyDown event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // Used for selecting multiple sprites one at a time
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlKey = true;
            }

            base.OnKeyDown(e);
        }

        /// <summary>
        /// Raises the KeyUp event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlKey = false;
            }

            base.OnKeyUp(e);
        }

        /// <summary>
        ///
        /// </summary>
        private void CreateSpriteObject()
        {
            Point location = new(mouseStartPos.X, mouseStartPos.Y);

            Point pnt = Point.Subtract(mouseEndPos, (Size)mouseStartPos);

            //Size size = new(pnt.X, pnt.Y);

            //Rectangle rect = new Rectangle(mouseStartPos.X, mouseStartPos.Y, pnt.X, pnt.Y);//.Resize(ZoomFactor);

            Rectangle rect = new Rectangle(ConvertZoomFactor(location), (Size)ConvertZoomFactor(pnt));

            SpriteObject itm = new()
            {
                Rect = SwapRect(rect) //new Rectangle(location, size)
            };

            SpriteObjectList.Add(itm);
            Invalidate(Rectangle.Inflate(itm.Rect, Node.NODE_SIZE, Node.NODE_SIZE));
            SpritesCreated?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="sz"></param>
        private void MoveSpriteObject(Point pt, Size sz)
        {
            if (SpriteObjectList.ActiveSprite.SelectedNode == NodeLocation.None)
            {
                SpriteObjectList.ReleaseSelectedItems();
                SpriteClicked?.Invoke(this, new ActiveSpriteEventArgs(null));
                return;
            }

            if (SpriteObjectList.ActiveSprite.SelectedNode == NodeLocation.Everything)
            {
                spritesMove = true;
                SpriteObjectList.MoveSelectedItems(Point.Subtract(pt, sz));
                SpritesMoving?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
            }
            else
            {
                spritesResize = true;
                SpriteObjectList.ResizeSelectedItems(Point.Subtract(pt, sz));
                SpritesResizing?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
            }

            mouseStartPos = mouseEndPos;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pnt"></param>
        private void MoveSelectedItems(Point pnt)
        {
            SpriteObjectList.MoveSelectedItems(pnt);
            SpritesMoved?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
            Invalidate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (SpriteObjectList.ActiveNode == NodeLocation.None)
            {
                SpriteObjectList.ReleaseSelectedItems();
                Invalidate();
            }

            BringObjectToFront.Enabled = SpriteObjectList.CanBringToFront;
            SendObjectToBack.Enabled = SpriteObjectList.CanSendToBack;
            BringObjectForward.Enabled = SpriteObjectList.CanBringForward;
            SendObjectBackward.Enabled = SpriteObjectList.CanSendBackward;

            CutObject.Enabled = SpriteObjectList.CanCut;
            CopyObject.Enabled = SpriteObjectList.CanCopy;
            PasteObject.Enabled = SpriteObjectList.CanPaste;

            DeleteObject.Enabled = SpriteObjectList.CanDelete;

            Cursor = Cursors.Default;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BringObjectToFront_Click(object sender, EventArgs e)
        {
            if (SpriteObjectList.CanBringToFront)
            {
                Cursor = Cursors.WaitCursor;
                SpriteObjectList.BringToFront();
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendObjectToBack_Click(object sender, EventArgs e)
        {
            if (SpriteObjectList.CanSendToBack)
            {
                Cursor = Cursors.WaitCursor;
                SpriteObjectList.SendtoBack();
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BringObjectForward_Click(object sender, EventArgs e)
        {
            if (SpriteObjectList.CanBringForward)
            {
                Cursor = Cursors.WaitCursor;
                SpriteObjectList.BringForward();
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendObjectBackward_Click(object sender, EventArgs e)
        {
            if (SpriteObjectList.CanSendBackward)
            {
                Cursor = Cursors.WaitCursor;
                SpriteObjectList.SendBackward();
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CutSelectedItems_Click(object sender, EventArgs e)
        {
            CutSelectedItems();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CopySelectedItems_Click(object sender, EventArgs e)
        {
            CopySelectedItems();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PasteSelectedItems_CLick(object sender, EventArgs e)
        {
            PasteSelectedItems();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteSelectedItems_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems();
        }

        public void CutSelectedItems()
        {
            if (SpriteObjectList.CanCut)
            {
                Cursor = Cursors.WaitCursor;
                SpritesDeleted?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));

                // Cut after event has been raised
                SpriteObjectList.CutSelectedItems(); 
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CopySelectedItems()
        {
            if (SpriteObjectList.CanCopy)
            {
                Cursor = Cursors.WaitCursor;
                SpriteObjectList.CopySelectedItems();
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void PasteSelectedItems()
        {
            if (SpriteObjectList.CanPaste)
            {
                Cursor = Cursors.WaitCursor;
                
                Point pnt = ConvertZoomFactor(mousePos);
                
                SpriteObjectList.PasteSelectedItems(pnt);
                SpritesCreated?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteSelectedItems()
        {
            if (SpriteObjectList.CanDelete)
            {
                Cursor = Cursors.WaitCursor;
                SpriteObjectList.DeleteSelectedItems();
                SpritesDeleted?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void SelectAll()
        {
            Cursor = Cursors.WaitCursor;
            SpriteObjectList.SelectAll();
            SpriteClicked?.Invoke(this, new ActiveSpriteEventArgs(null));
            Cursor = Cursors.Default;
            Invalidate();
        }

        /// <summary>
        /// Converts negative rectangle into positive rectangle
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private Rectangle SwapRect(Rectangle rect)
        {
            var newrect = rect;

            if (newrect.Width < 0)
            {
                newrect.X += newrect.Width;
                newrect.Width = -newrect.Width;
            }

            if (newrect.Height < 0)
            {
                newrect.Y += newrect.Height;
                newrect.Height = -newrect.Height;
            }

            return newrect;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        public void AlignSprites(AlignType value)
        {
            Cursor = Cursors.WaitCursor;
            SpriteObjectList.AlignSelectedItems(value);
            SpritesMoved?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
            Cursor = Cursors.Default;
            Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        public void ReSizeSelectedItems(ResizeType value)
        {
            Cursor = Cursors.WaitCursor;
            SpriteObjectList.ResizeSelectedItems(value);
            SpritesResized?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
            Cursor = Cursors.Default;
            Invalidate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void SpaceOutSelectedItems(SpaceOutType value)
        {
            Cursor = Cursors.WaitCursor;
            SpriteObjectList.SpaceOutSelectedItems(value);
            SpritesResized?.Invoke(this, new SelectedSpritesEventArgs(SpriteObjectList.SelectedItems));
            Cursor = Cursors.Default;
            Invalidate();
        }
    }
}