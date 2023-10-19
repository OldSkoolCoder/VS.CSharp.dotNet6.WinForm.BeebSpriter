using System.ComponentModel;

namespace BeebSpriter.Enum
{
    public enum BeebColourType
    {
        [Description("Black")]
        Black = 0,

        [Description("Red")]
        Red = 1,

        [Description("Green")]
        Green = 2,

        [Description("Yellow")]
        Yellow = 3,

        [Description("Blue")]
        Blue = 4,

        [Description("Magenta")]
        Magenta = 5,

        [Description("Cyan")]
        Cyan = 6,

        [Description("White")]
        White = 7,

        [Description("Black/White")]
        BlackWhite = 8,

        [Description("Red/Cyan")]
        RedCyan = 9,

        [Description("Green/Magenta")]
        GreenMagenta = 10,

        [Description("Yellow/Blue")]
        YellowBlue = 11,

        [Description("Blue/Yellow")]
        BlueYellow = 12,

        [Description("Magenta/Green")]
        MagentaGreen = 13,

        [Description("Cyan/Red")]
        CyanRed = 14,

        [Description("White/Black")]
        WhiteBlack = 15,

        [Description("Transparent")]
        Transparent = 255
    }
}