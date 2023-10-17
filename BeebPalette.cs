using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BeebSpriter
{
    public class BeebPalette
    {

        private const int TRANSPARENT_COLOUR = 255;

        public enum Colour
        {
            Black = 0,
            Red = 1,
            Green = 2,
            Yellow = 3,
            Blue = 4,
            Magenta = 5,
            Cyan = 6,
            White = 7
        }

        /// <summary>
        /// 
        /// </summary>
        public Color[] WinColours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Colour[] BeebColours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int NumColours {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numColour"></param>
        public BeebPalette(int numColours)
        {
            NumColours = numColours;

            BeebColours = new Colour[NumColours];
            WinColours = new Color[NumColours];

            for (int i = 0; i < NumColours; i++)
            {
                BeebColours[i] = (Colour)(i & 7);
                WinColours[i] = GetWindowsColour((Colour)(i & 7));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numColours"></param>
        /// <param name="palette"></param>
        public BeebPalette(int numColours, Colour[] palette)
        {
            NumColours = numColours;

            BeebColours = new Colour[NumColours];
            WinColours = new Color[NumColours];

            for (int i = 0; i < NumColours; i++)
            {
                BeebColours[i] = palette[i];
                WinColours[i] = GetWindowsColour((Colour)(palette[i]));
            }
        }

        public static Color GetWindowsColour(Colour beebColour)
        {
            switch (beebColour)
            {
                case Colour.Black: return Color.FromArgb(0, 0, 0);
                case Colour.Red: return Color.FromArgb(255, 0, 0);
                case Colour.Green: return Color.FromArgb(0, 255, 0);
                case Colour.Yellow: return Color.FromArgb(255, 255, 0);
                case Colour.Blue: return Color.FromArgb(0, 0, 255);
                case Colour.Magenta: return Color.FromArgb(255, 0, 255);
                case Colour.Cyan: return Color.FromArgb(0, 255, 255);
                case Colour.White: return Color.FromArgb(255, 255, 255);
                default: throw new Exception("Unknown colour");
            }
        }

        public static Colour GetNextColour(Colour colour)
        {
            return (Colour)(((int)colour + 1) & 7);
        }

        public static Colour GetPreviousColour(Colour colour)
        {
            return (Colour)(((int)colour - 1) & 7);
        }

        public static Colour GetFlashingColour(Colour colour)
        {
            return (Colour)(((int)colour) ^ 7);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public int GetAcornColour(Color col)
        {
            for (int i = 0; i < NumColours; i++)
            {
                if (col == WinColours[i]) return i;
            }

            return TRANSPARENT_COLOUR;
        }

        /// <summary>
        /// Closest match in RGB space
        /// </summary>
        /// <param name="origCol"></param>
        /// <returns></returns>
        public Color FindClosestRGBColour(Color origCol)
        {
            var colorDiffs = WinColours.ToList().Select(n => ColorDiff(n, origCol)).Min(n => n);
            int col = WinColours.ToList().FindIndex(n => ColorDiff(n, origCol) == colorDiffs);

            return WinColours[col];
        }

        /// <summary>
        /// Weighed only by saturation and brightness
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        private static int ColorDiff(Color c1, Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                   + (c1.G - c2.G) * (c1.G - c2.G)
                                   + (c1.B - c2.B) * (c1.B - c2.B));
        }

    }
}
