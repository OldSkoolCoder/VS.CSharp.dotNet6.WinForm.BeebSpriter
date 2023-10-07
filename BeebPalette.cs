using System;
using System.Collections.Generic;
using System.Drawing;

namespace BeebSpriter
{
    public class BeebPalette
    {
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
    }
}
