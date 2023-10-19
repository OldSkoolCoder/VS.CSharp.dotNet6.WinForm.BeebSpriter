using BeebSpriter.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BeebSpriter.Internal
{
    public class SpritePad
    {
        public string Id { get; set; }
        public int Version { get; set; }

        public int Flags { get; set; }

        public bool TilesOnline => (Flags & 0x01) != 0;
        public bool AnimatedSprites => (Flags & 0x10) != 0;
        public bool AnimatedTiles => (Flags & 0x100) != 0;

        public int SpriteQuantity { get; set; }

        public int TileQuantity { get; set; }

        public int SpriteAnimationQuantity { get; set; }

        public int TileAnimationQuantity { get; set; }

        public int TileWidth { get; set; }

        public int TileHeight { get; set; }

        public C64ColourType ColourBG { get; set; }

        public C64ColourType ColourMC1 { get; set; }

        public C64ColourType ColourMC2 { get; set; }

        public int SpriteOverlayDistance { get; set; }
        public int TileOverlayDistance { get; set; }

        public List<byte[]> Data { get; set; }
        public List<byte> Attribute { get; set; }

        /// <summary>
        /// Initializers a new instance of the <see cref="SpritePad"></see> class that is empty and has the default initial capacity.
        /// </summary>
        public SpritePad()
        {
            Data = new List<byte[]>();
            Attribute = new List<byte>();
        }

        /// <summary>
        /// Is the sprite a multi colour mode
        /// </summary>
        /// <param name="spriteNum"></param>
        /// <returns></returns>
        public bool MultiColourMode(int spriteNum)
        {
            return (Attribute[spriteNum] & 0x80) != 0;
        }

        /// <summary>
        /// C64 Sprite colour
        /// </summary>
        /// <param name="spriteNum"></param>
        /// <returns></returns>
        public C64ColourType SpriteColour(int spriteNum)
        {
            return (C64ColourType)(Attribute[spriteNum] & 0x0F);
        }

        /// <summary>
        /// Load SpritePad data into SpritePad Class
        /// </summary>
        /// <param name="spritePad"></param>
        public void Generate(string filename)
        {
            byte[] fileBytes = File.ReadAllBytes(filename);

            Id = string.Format("{0}{1}{2}", (char)fileBytes[0x00], (char)fileBytes[0x01], (char)fileBytes[0x02]);
            Version = fileBytes[0x03];
            Flags = fileBytes[0x04];
            SpriteQuantity = fileBytes[0x05] + (fileBytes[0x06] << 8);
            TileQuantity = fileBytes[0x07] + (fileBytes[0x08] << 8);
            SpriteAnimationQuantity = fileBytes[0x09];
            TileAnimationQuantity = fileBytes[0x0A];
            TileWidth = fileBytes[0x0B];
            TileHeight = fileBytes[0x0C];
            ColourBG = (C64ColourType)fileBytes[0x0D];
            ColourMC1 = (C64ColourType)fileBytes[0x0E];
            ColourMC2 = (C64ColourType)fileBytes[0x0F];

            int sourceIndex = 0x10;

            if (Version > 3)
            {
                SpriteOverlayDistance = fileBytes[0x10] + (fileBytes[0x11] << 8);
                TileOverlayDistance = fileBytes[0x12] + (fileBytes[0x13] << 8);
                sourceIndex = 0x14;
            }

            for (int index = 0; index < SpriteQuantity; ++index)
            {
                byte[] destArray = new byte[63];
                Array.Copy(fileBytes, sourceIndex, destArray, 0, 63);

                Data.Add(destArray);

                sourceIndex += 63;

                // Attribute is the 64th byte of each sprite
                Attribute.Add(fileBytes[sourceIndex++]);
            }

            if (TilesOnline)
            {
                // TODO
            }

            if (AnimatedSprites)
            {
                // TODO
            }

            if (AnimatedTiles)
            {
                // TODO
            }
        }

        /// <summary>
        /// Convert SpritePad Data into BeebSpriter Bitmap bytes
        /// </summary>
        /// <param name="spritePad"></param>
        /// <param name="spriteNum"></param>
        /// <returns></returns>
        public byte[] ToBytes(int spriteNum)
        {
            byte[] bytes = new byte[252];

            int index = 0;

            foreach (byte pixel in Data[spriteNum])
            {
                bytes[index++] = (byte)GetColour((pixel >> 6) & 0x03, spriteNum);
                bytes[index++] = (byte)GetColour((pixel >> 4) & 0x03, spriteNum);
                bytes[index++] = (byte)GetColour((pixel >> 2) & 0x03, spriteNum);
                bytes[index++] = (byte)GetColour(pixel & 0x03, spriteNum);
            }

            return bytes;
        }

        /// <summary>
        /// Convert SpritePad colour to Beeb colour
        /// </summary>
        /// <param name="spritePad"></param>
        /// <param name="pixel"></param>
        /// <param name="spriteNum"></param>
        /// <returns></returns>
        public BeebColourType GetColour(int pixel, int spriteNum)
        {
            bool multiColourMode = MultiColourMode(spriteNum);
            C64ColourType spriteColour = SpriteColour(spriteNum);

            return pixel switch
            {
                1 => multiColourMode ? ColourMC1.ToBeebColour() : spriteColour.ToBeebColour(),
                2 => spriteColour.ToBeebColour(),
                3 => multiColourMode ? ColourMC2.ToBeebColour() : spriteColour.ToBeebColour(),
                _ => BeebColourType.Transparent,
            };
        }

        /// <summary>
        /// Simple SpritePad data viewer
        /// </summary>
        /// <param name="spritePad"></param>
        /// <param name="rtb"></param>
        public void ShowData(RichTextBox rtb)
        {
            rtb.Clear();

            rtb.AppendText("ID                      : " + Id + Environment.NewLine);
            rtb.AppendText("Version                 : " + Version.ToString() + Environment.NewLine);
            rtb.AppendText("Flags                   : " + Flags.ToString() + Environment.NewLine);
            rtb.AppendText("Sprite Qty              : " + SpriteQuantity.ToString() + Environment.NewLine);
            rtb.AppendText("Tile Qty                : " + TileQuantity.ToString() + Environment.NewLine);
            rtb.AppendText("Sprite Animation Qty    : " + SpriteAnimationQuantity.ToString() + Environment.NewLine);
            rtb.AppendText("Tile Animation Qty      : " + TileAnimationQuantity.ToString() + Environment.NewLine);
            rtb.AppendText("Tile Width              : " + TileWidth.ToString() + Environment.NewLine);
            rtb.AppendText("Tile Height             : " + TileHeight.ToString() + Environment.NewLine);
            rtb.AppendText("Colour BG               : " + ColourBG.ToString() + Environment.NewLine);
            rtb.AppendText("Colour MC1              : " + ColourMC1.ToString() + Environment.NewLine);
            rtb.AppendText("Colour MC2              : " + ColourMC2.ToString() + Environment.NewLine);

            if (Version > 3)
            {
                rtb.AppendText("Sprite Overlay Distance : " + SpriteOverlayDistance.ToString() + Environment.NewLine);
                rtb.AppendText("Tile Overlay Distance   : " + TileOverlayDistance.ToString() + Environment.NewLine);
            }

            rtb.AppendText(Environment.NewLine);

            for (int index = 0; index < SpriteQuantity; index++)
            {
                rtb.AppendText("Sprite    : " + (index + 1).ToString() + Environment.NewLine);
                rtb.AppendText("Attribute : " + Attribute[index].ToBinary() + Environment.NewLine);

                string hex = BitConverter.ToString(Data[index]);
                hex = hex.Replace("-", ", ");
                rtb.AppendText(hex + Environment.NewLine + Environment.NewLine);
            }
        }
    }
}