using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }

        public Sprite(string name, Sprite toCopy)
        {
            this.Name = name;
            this.Width = toCopy.Width;
            this.Height = toCopy.Height;
            this.Bitmap = (byte[])toCopy.Bitmap.Clone();
            this.Palette = (BeebPalette.Colour[])toCopy.Palette.Clone();
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
                return Name;
            }
        }
    }
}
