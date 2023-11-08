using BeebSpriter.Enum;
using System;
using System.Collections.Generic;
using System.IO;

namespace BeebSpriter.Internal
{
    public class SEUCK
    {
        public List<byte[]> Data { get; set; }
        public List<byte> Attribute { get; set; }

        /// <summary>
        /// Initializers a new instance of the <see cref="SEUCK"></see> class that is empty and has the default initial capacity.
        /// </summary>
        public SEUCK()
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
        /// Load SEUCK data into SpritePad Class
        /// </summary>
        /// <param name="spritePad"></param>
        public void Generate(string filename)
        {
            byte[] fileBytes = File.ReadAllBytes(filename);

            int length = (int)fileBytes.Length;
          
            // Skip first 2 bytes
            _ = fileBytes[0x00];
            _ = fileBytes[0x01];

            int SpriteQuantity = length / 64;

            int sourceIndex = 0x02;

            for (int index = 0; index < SpriteQuantity; ++index)
            {
                byte[] destArray = new byte[63];
                Array.Copy(fileBytes, sourceIndex, destArray, 0, 63);

                Data.Add(destArray);

                sourceIndex += 63;

                // Attribute is the 64th byte of each sprite
                Attribute.Add(fileBytes[sourceIndex++]);
            }
        }

        /// <summary>
        /// Convert SEUCK Data into BeebSpriter Bitmap bytes
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
        /// Convert SEUCK colour to Beeb colour
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
                1 => BeebColourType.Black,
                2 => spriteColour.ToBeebColour(),
                3 => BeebColourType.White,
                _ => BeebColourType.Transparent,
            };
        }
    }
}