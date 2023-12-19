﻿using System;
using System.Xml.Serialization;

namespace BeebSpriter
{
    public class Sprite
    {
        private string name;
        private int width;
        private int height;
        private byte[] bitmap;
        private BeebPalette.Colour[] palette;
        private SpritePanel spritePanel;
        private Guid guid;

        [XmlAttribute]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [XmlAttribute]
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        [XmlAttribute]
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public byte[] Bitmap
        {
            get { return this.bitmap; }
            set { this.bitmap = value; }
        }

        public BeebPalette.Colour[] Palette
        {
            get { return this.palette; }
            set { this.palette = value; }
        }

        [XmlAttribute]
        public Guid Guid
        {
            get { return this.guid; }
            set { this.guid = value; }
        }

        /// <summary>
        /// Get the number of colours used by the sprite
        /// </summary>
        public int NumColours => Palette.Length;

        public SpritePanel SpritePanel
        {
            get { return this.spritePanel; }
        }

        public Sprite()
        {
        }

        public Sprite(string name, int width, int height, BeebPalette.Colour[] palette)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.Bitmap = new byte[this.Width * this.Height];
            this.Palette = (BeebPalette.Colour[])palette.Clone();
            this.guid = Guid.NewGuid();
        }

        public Sprite(string name, Sprite toCopy)
        {
            this.Name = name;
            this.Width = toCopy.Width;
            this.Height = toCopy.Height;
            this.Bitmap = (byte[])toCopy.Bitmap.Clone();
            this.Palette = (BeebPalette.Colour[])toCopy.Palette.Clone();
            this.guid = Guid.NewGuid();
        }

        public void SetSpritePanel(SpritePanel spritePanel)
        {
            this.spritePanel = spritePanel;
        }

        public override string ToString()
        {
            if (Name == "")
            {
                return "<Unnamed sprite>";
            }
            else
            {
                return Name + "-OSK";
            }
        }

        /// <summary>
        /// Rotate Image Clockwise 90
        /// </summary>
        public void rotateClockWise()
        {
            byte[] clonedImage = (byte[])this.Bitmap.Clone();

            int index = 0;
            for (int x = 0; x < this.Width; x++)
            {
                for (int y = this.Height - 1; y >= 0; y--)
                {
                    this.Bitmap[index++] = clonedImage[y * Width + x];
                }
            }

            int tempVar = this.Width;
            this.Width = this.Height;
            this.Height = tempVar;
        }

        /// <summary>
        /// Rotate Image Anti Clockwise 90
        /// </summary>
        public void rotateAntiClockWise()
        {
            byte[] clonedImage = (byte[])this.Bitmap.Clone();

            int index = 0;
            for (int x = this.Width - 1; x >= 0; x--)
            {
                for (int y = 0; y < this.Height; y++)
                {
                    this.Bitmap[index++] = clonedImage[y * Width + x];
                }
            }

            int tempVar = this.Width;
            this.Width = this.Height;
            this.Height = tempVar;
        }

        /// <summary>
        /// Replace one colour with another in the sprite image
        /// </summary>
        /// <param name="oldColour"></param>
        /// <param name="newColour"></param>
        public void ReplaceColours(int oldColour, int newColour)
        {
            for (int index = 0; index < Bitmap.Length; index++)
            {
                if (Bitmap[index] == (byte)oldColour) Bitmap[index] = (byte)newColour;
            }
        }

        /// <summary>
        /// Make all colours negative in the sprite image
        /// </summary>
        /// <param name="colourDepth"></param>
        public void Negative(int colourDepth)
        {
            // 255 = Transparent Colour

            for (int index = 0; index < Bitmap.Length; index++)
            {
                if (Bitmap[index] != 255)
                    Bitmap[index] ^= (byte)(colourDepth - 1);
            }
        }

        /// <summary>
        /// Shift Image Left
        /// </summary>
        public void ShiftLeft()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int index = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 1; x <= Width; x++)
                {
                    Bitmap[index++] = clonedImage[y * Width + (x % Width)];
                }
            }
        }

        /// <summary>
        /// Shift Image Down
        /// </summary>
        public void ShiftDown()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int index = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Bitmap[index++] = clonedImage[((Height - 1 + y) % Height) * Width + x];
                }
            }
        }

        /// <summary>
        /// Shift Image Right
        /// </summary>
        public void ShiftRight()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int index = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Bitmap[index++] = clonedImage[y * Width + ((Width - 1 + x) % Width)];
                }
            }
        }

        /// <summary>
        /// Shift Image Up
        /// </summary>
        public void ShiftUp()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int index = 0;
            for (int y = 1; y <= Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Bitmap[index++] = clonedImage[(y % Height) * Width + x];
                }
            }
        }

        /// Reduce colours down to lower depth
        /// </summary>
        /// <param name="colourDepth"></param>
        public void ReduceColours(int colourDepth)
        {
            // 255 = Transparent Colour

            for (int index = 0; index < Bitmap.Length; index++)
            {
                if (Bitmap[index] != 255)
                    Bitmap[index] = (byte)(Bitmap[index] % colourDepth);
            }
        }

        /// <summary>
        /// Flip Left to Right
        /// </summary>
        public void FlipLeftToRight()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int index = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = Width - 1; x >= 0; x--)
                {
                    Bitmap[index++] = clonedImage[y * Width + x];
                }
            }
        }

        /// <summary>
        /// Flip Top to Bottom
        /// </summary>
        public void FlipTopToBottom()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int index = 0;
            for (int y = Height - 1; y >= 0; y--)
            {
                for (int x = 0; x < Width; x++)
                {
                    Bitmap[index++] = clonedImage[y * Width + x];
                }
            }
        }

        /// <summary>
        /// Reflect Left to Right
        /// </summary>
        public void ReflectLeftToRight()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int halfWidth = Width / 2;

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0, x1 = Width - 1; x < halfWidth; x++, x1--)
                {
                    Bitmap[y * Width + x1] = clonedImage[y * Width + x];
                }
            }
        }

        /// <summary>
        /// Reflect Top to Bottom
        /// </summary>
        public void ReflectTopToBottom()
        {
            byte[] clonedImage = (byte[])Bitmap.Clone();

            int halfHeight = Height / 2;

            for (int y = 0, y1 = Height - 1; y < halfHeight; y++, y1--)
            {
                for (int x = 0; x < Width; x++)
                {
                    Bitmap[y1 * Width + x] = clonedImage[y * Width + x];
                }
            }
        }
    }
}