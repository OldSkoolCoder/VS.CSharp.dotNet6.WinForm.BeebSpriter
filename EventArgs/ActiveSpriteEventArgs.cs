using BeebSpriter.Internal;
using System;

namespace BeebSpriter
{
    public class ActiveSpriteEventArgs : EventArgs
    {
        public SpriteObject ActiveObject { get; init; }

        public ActiveSpriteEventArgs(SpriteObject obj)
        {
            ActiveObject = obj;
        }
    }
}