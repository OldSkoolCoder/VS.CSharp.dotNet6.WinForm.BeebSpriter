using BeebSpriter.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BeebSpriter.Internal
{
    public class SpriteObjectList
    {
        public NodeLocation ActiveNode { get; set; }
        public SpriteObject ActiveSprite { get; set; }
        public List<SpriteObject> Items { get; set; }
        public List<SpriteObject> SelectedItems { get; set; }
        public List<SpriteObject> ClipboardItems { get; set; }

        /// <summary>
        /// Creates a new object view.
        /// </summary>
        /// <remarks></remarks>
        public SpriteObjectList()
        {
            ActiveSprite = null;

            Items = new List<SpriteObject>();
            SelectedItems = new List<SpriteObject>();
            ClipboardItems = new List<SpriteObject>();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Guid Add(SpriteObject value)
        {
            Items.Add(value);
            SelectedItems.Add(value);

            ActiveSprite = Items[^1];

            return ActiveSprite.Guid;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CanBringToFront => SelectedItems.Count == 1 && Items.Count > 1;

        /// <summary>
        /// Brings the object to the front of the z-order.
        /// </summary>
        /// <remarks></remarks>
        public void BringToFront()
        {
            if (CanBringToFront)
            {
                Items.Remove(ActiveSprite);
                Items.Insert(Items.Count, ActiveSprite);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CanSendToBack => SelectedItems.Count == 1 && Items.Count > 1;

        /// <summary>
        /// Sends the object to the back of the z-order.
        /// </summary>
        /// <remarks></remarks>
        public void SendtoBack()
        {
            if (CanSendToBack)
            {
                Items.Remove(ActiveSprite);
                Items.Insert(0, ActiveSprite);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CanBringForward => SelectedItems.Count == 1 && Items.Count > 1;

        /// <summary>
        /// Bring the object forward in the z-order
        /// </summary>
        /// <remarks></remarks>
        public void BringForward()
        {
            if (CanBringForward)
            {
                int index = Items.IndexOf(ActiveSprite);
                if (index < Items.Count - 1)
                {
                    Items.Remove(ActiveSprite);
                    Items.Insert(index + 1, ActiveSprite);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CanSendBackward => SelectedItems.Count == 1 && Items.Count > 1;

        /// <summary>
        /// Send the object backward in the z-order
        /// </summary>
        /// <remarks></remarks>
        public void SendBackward()
        {
            if (CanSendBackward)
            {
                int index = Items.IndexOf(ActiveSprite);
                if (index > 0)
                {
                    Items.Remove(ActiveSprite);
                    Items.Insert(index - 1, ActiveSprite);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public bool CanCut => SelectedItems.Count > 0;

        /// <summary>
        /// Move the current selected items into the internal Clipboard
        /// </summary>
        /// <remarks></remarks>
        public void CutSelectedItems()
        {
            if (CanCut)
            {
                SetObjectData(SelectedItems);
                DeleteSelectedItems();
            }
        }

        /// <summary>
        ///
        /// </summary>
        public bool CanCopy => SelectedItems.Count > 0;

        /// <summary>
        /// Copies the current selected items into the internal clipboard
        /// </summary>
        /// <remarks></remarks>
        public void CopySelectedItems()
        {
            if (CanCopy)
            {
                SetObjectData(SelectedItems);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public bool CanPaste => GetObjectData.Count > 0;

        /// <summary>
        /// pastes the internal clipboard items into the canvas without clearing the undo buffer
        /// </summary>
        /// <param name="pnt"></param>
        /// <remarks></remarks>
        public void PasteSelectedItems(Point pnt)
        {
            if (CanPaste)
            {
                ReleaseSelectedItems();

                Point newpnt = pnt;

                List<SpriteObject> clonedItems = GetObjectData;

                // Locate top left most position of cloned items
                foreach (SpriteObject value in clonedItems)
                {
                    if (value.Rect.X < pnt.X) newpnt.X = value.Rect.X;
                    if (value.Rect.Y < pnt.Y) newpnt.Y = value.Rect.Y;
                }

                foreach (SpriteObject spriteObject in clonedItems)
                {
                    SpriteObject pasteObject = spriteObject.Clone();

                    pasteObject.Move(Point.Subtract(pnt, (Size)newpnt));

                    Add(pasteObject);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public bool CanDelete => SelectedItems.Count > 0;

        /// <summary>
        /// Deletes the selected items
        /// </summary>
        /// <remarks></remarks>
        public void DeleteSelectedItems()
        {
            if (CanDelete)
            {
                ActiveSprite = null;
                SelectedItems.Clear();

                // Remove in reverse order to resolve index error
                for (int i = Items.Count - 1; i >= 0; i -= 1)
                {
                    if (Items[i].Selected)
                    {
                        Items.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void ReleaseSelectedItems()
        {
            if (SelectedItems.Count == 0)
                return;

            ActiveSprite = null;
            SelectedItems.Clear();

            for (int i = Items.Count - 1; i >= 0; i -= 1)
            {
                Items[i].Selected = false;
                Items[i].SelectedNode = NodeLocation.None;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pnt"></param>
        public void MoveSelectedItems(Point pnt)
        {
            if (SelectedItems.Count == 0)
                return;

            for (int i = 0; i <= SelectedItems.Count - 1; i++)
                (SelectedItems[i]).Move(pnt);

            for (int i = 0; i <= SelectedItems.Count - 1; i++)
                (SelectedItems[i]).Move(pnt);
        }

        /// <summary>
        /// Resize all selected sprite objects
        /// </summary>
        /// <param name="pnt"></param>
        public void ResizeSelectedItems(Point pnt)
        {
            if (SelectedItems.Count == 0)
                return;

            for (int i = 0; i <= SelectedItems.Count - 1; i++)
                SelectedItems[i].Resize(ActiveSprite.SelectedNode, pnt);
        }

        /// <summary>
        /// Capture object under the mouse, allow multiple captures if the CTRL key is held down.
        /// </summary>
        /// <param name="pnt"></param>
        /// <param name="CtrlKey"></param>
        /// <remarks></remarks>
        public void Capture(Point pnt, bool CtrlKey)
        {
            ActiveSprite = null;

            if (CtrlKey == false)
            {
                SelectedItems.Clear();
                Items.ReleaseAll();
            }

            // This will ignore any objects that are behind others even though you might be able to see them with a transparent rectangle in front
            for (int i = Items.Count - 1; i >= 0; i -= 1)
            {
                if (Items[i].Contains(pnt))
                {
                    if (Items[i].Selected == true)
                    {
                        Items[i].Selected = false;
                        SelectedItems.Release(Items[i]);
                    }
                    else
                    {
                        Items[i].Selected = true;
                        SelectedItems.Add(Items[i]);
                    }
                    break;
                }
            }

            if (SelectedItems.Count > 0)
            {
                ActiveSprite = SelectedItems[0];
            }
        }

        /// <summary>
        /// Capture all objects within the specified rectangle.
        /// </summary>
        /// <param name="rect"></param>
        /// <remarks></remarks>
        public void CaptureAll(Rectangle rect)
        {
            ActiveSprite = null;
            SelectedItems.Clear();

            Items.ReleaseAll();

            for (int i = Items.Count - 1; i >= 0; i -= 1)
            {
                if (rect.Contains(Items[i].Rect))
                {
                    Items[i].Selected = true;
                    SelectedItems.Add(Items[i]);
                }
            }

            if (SelectedItems.Count > 0)
            {
                ActiveSprite = SelectedItems[0];
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CanSelectAll => Items.Count > 0 && SelectedItems.Count != Items.Count;

        /// <summary>
        ///
        /// </summary>
        public void SelectAll()
        {
            if (CanSelectAll)
            {
                SelectedItems.Clear();

                for (int i = Items.Count - 1; i >= 0; i -= 1)
                {
                    Items[i].Selected = true;
                    SelectedItems.Add(Items[i]);
                }

                if (SelectedItems.Count > 0)
                {
                    ActiveSprite = SelectedItems[0];
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void UnSelectAll()
        {
            ActiveSprite = null;

            SelectedItems.Clear();

            Items.ReleaseAll();
        }

        /// <summary>
        ///
        /// </summary>
        public void NextSprite()
        {
            if (Items.Count == 0)
                return;

            // Get current index of active object
            int index = Items.IndexOf(ActiveSprite);

            ActiveSprite = null;
            SelectedItems.Clear();

            Items.ReleaseAll();

            index += 1;
            if (index > Items.Count - 1)
            {
                index = 0;
            }
            Items[index].Selected = true;
            SelectedItems.Add(Items[index]);

            if (SelectedItems.Count > 0)
            {
                ActiveSprite = SelectedItems[0];
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void PreviousSprite()
        {
            if (Items.Count == 0)
                return;

            // Get current index of active object
            int index = Items.IndexOf(ActiveSprite);

            ActiveSprite = null;
            SelectedItems.Clear();

            Items.ReleaseAll();

            index -= 1;

            if (index < 0)
            {
                index = Items.Count - 1;
            }
            Items[index].Selected = true;
            SelectedItems.Add(Items[index]);

            if (SelectedItems.Count > 0)
            {
                ActiveSprite = SelectedItems[0];
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pnt"></param>
        public void HoverSelectedNode(Point pnt)
        {
            ActiveNode = NodeLocation.None;

            if (SelectedItems.Count == 0)
                return;

            for (int i = Items.Count - 1; i >= 0; i -= 1)
            {
                if (Items[i].HoverSelectedNode(pnt) == true)
                {
                    ActiveNode = Items[i].SelectedNode;
                    return;
                }
            }

            return;
        }

        /// <summary>
        ///
        /// </summary>
        public bool CanAlign => SelectedItems.Count > 1;

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="Exception"></exception>
        public void AlignSelectedItems(AlignType value)
        {
            if (CanAlign)
            {
                for (int i = 1; i <= SelectedItems.Count - 1; i++)
                {
                    Point pnt = SelectedItems[i].Rect.Location;

                    switch (value)
                    {
                        case AlignType.Left:
                            pnt.X = SelectedItems[0].Rect.X;
                            break;

                        case AlignType.Centre:

                            pnt.X = SelectedItems[0].Rect.Right - SelectedItems[0].Rect.Width / 2 - SelectedItems[i].Rect.Width / 2;
                            break;

                        case AlignType.Right:

                            pnt.X = SelectedItems[0].Rect.Right - SelectedItems[i].Rect.Width;
                            break;

                        case AlignType.Top:

                            pnt.Y = SelectedItems[0].Rect.Y;
                            break;

                        case AlignType.Middle:

                            pnt.Y = SelectedItems[0].Rect.Bottom - SelectedItems[0].Rect.Height / 2 - SelectedItems[i].Rect.Height / 2;
                            break;

                        case AlignType.Bottom:

                            pnt.Y = SelectedItems[0].Rect.Bottom - SelectedItems[i].Rect.Height;
                            break;

                        default: throw new Exception("Unknown Alignment type");
                    }

                    SelectedItems[i].Location = pnt;
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CanResize => SelectedItems.Count > 1;

        public void ResizeSelectedItems(ResizeType value)
        {
            if (CanResize)
            {
                for (int i = 1; i <= SelectedItems.Count - 1; i++)
                {
                    Rectangle rect = SelectedItems[i].Rect;

                    switch (value)
                    {
                        case ResizeType.Width:

                            rect.Width = SelectedItems[0].Rect.Width;
                            break;

                        case ResizeType.Height:
                            {
                                rect.Height = SelectedItems[0].Rect.Height;
                                break;
                            }
                        case ResizeType.Both:
                            {
                                rect.Width = SelectedItems[0].Rect.Width;
                                rect.Height = SelectedItems[0].Rect.Height;
                                break;
                            }
                    }

                    SelectedItems[i].Rect = new Rectangle(rect.Location, rect.Size);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CanSpaceOut => SelectedItems.Count > 2;

        public void SpaceOutSelectedItems(SpaceOutType value)
        {
            if (CanSpaceOut)
            {
                //SelectedItems.Sort(value);
                SelectedItems = (value == SpaceOutType.Horizontal) ? SelectedItems.OrderBy(x => x.Rect.Left).ToList() : SelectedItems.OrderBy(x => x.Rect.Bottom).ToList();

                // Calculate area rectangle
                Rectangle areaRect = new(0, 0, 0, 0)
                {
                    X = SelectedItems[0].Rect.X,
                    Y = SelectedItems[0].Rect.Y,
                };

                areaRect.Width = SelectedItems[^1].Rect.Right - areaRect.Left;
                areaRect.Height = SelectedItems[^1].Rect.Bottom - areaRect.Top;

                // Calculate Total object rectangle
                Rectangle objRect = new(0, 0, 0, 0);

                for (int i = 0; i <= SelectedItems.Count - 1; i++)
                {
                    objRect.Width += SelectedItems[i].Rect.Width;
                    objRect.Height += SelectedItems[i].Rect.Height;
                }

                int hspace = (areaRect.Width - objRect.Width) / (SelectedItems.Count - 1);
                int vspace = (areaRect.Height - objRect.Height) / (SelectedItems.Count - 1);

                if (hspace < 0) hspace = 0;
                if (vspace < 0) vspace = 0;

                Point offset = SelectedItems[0].Rect.Location + SelectedItems[0].Rect.Size;

                // Never move the first object
                for (int i = 1; i <= SelectedItems.Count - 1; i++)
                {
                    Point pnt = SelectedItems[i].Rect.Location;

                    if (value == SpaceOutType.Horizontal)
                    {
                        // Only move the last one if the horizontal space is 0
                        if (hspace > 0 && i == SelectedItems.Count - 1)
                            break;
                        pnt.X = offset.X + hspace;
                    }
                    else
                    {
                        // Only move the last one if the vertical space is 0
                        if (vspace > 0 && i == SelectedItems.Count - 1)
                            break;

                        pnt.Y = offset.Y + vspace;
                    }
                    SelectedItems[i].Location = pnt;

                    offset.X = pnt.X + SelectedItems[i].Rect.Width;
                    offset.Y = pnt.Y + SelectedItems[i].Rect.Height;
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public List<SpriteObject> GetObjectData => ClipboardItems;

        /// <summary>
        /// Clears the internal clipboard and then adds data to it.
        /// </summary>
        /// <param name="data"></param>
        /// <remarks></remarks>
        public void SetObjectData(List<SpriteObject> data)
        {
            ClipboardItems.Clear();

            foreach (SpriteObject value in data)
            {
                ClipboardItems.Add(value);
            }
        }

        public void PreviousObject()
        {
            if (Items.Count == 0) return;

            // Get current index of active object
            int index = Items.IndexOf(ActiveSprite);

            ActiveSprite = null;
            SelectedItems.Clear();

            Items.ReleaseAll();

            index -= 1;

            if (index < 0)
            {
                index = Items.Count - 1;
            }
            Items[index].Selected = true;
            SelectedItems.Add(Items[index]);

            if (SelectedItems.Count > 0)
            {
                ActiveSprite = SelectedItems[0];
            }
        }

        public void NextObject()
        {
            if (Items.Count == 0) return;

            // Get current index of active object
            int index = Items.IndexOf(ActiveSprite);

            ActiveSprite = null;
            SelectedItems.Clear();

            Items.ReleaseAll();

            index += 1;
            if (index > Items.Count - 1)
            {
                index = 0;
            }
            Items[index].Selected = true;
            SelectedItems.Add(Items[index]);

            if (SelectedItems.Count > 0)
            {
                ActiveSprite = SelectedItems[0];
            }
        }
    }
}