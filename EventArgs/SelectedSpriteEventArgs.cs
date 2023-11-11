using BeebSpriter.Internal;
using System;
using System.Collections.Generic;

namespace BeebSpriter
{
    public class SelectedSpritesEventArgs : EventArgs
    {
        public List<SpriteObject> SelectedItems { get; init; }

        public SelectedSpritesEventArgs(List<SpriteObject> obj)
        {
            SelectedItems = obj;
        }

        public int Count()
        {
            return SelectedItems.Count;
        }
    }
}