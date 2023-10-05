using System.ComponentModel;

namespace BeebSpriter.Enum
{
    public enum GfxModeType
    {
        [Description("Acorn BBC Mode 0 (640 x 256 Pixels,  2 Colours)")]
        Mode0 = 0,
        [Description("Acorn BBC Mode 1 (320 x 256 Pixels,  4 Colours)")]
        Mode1 = 1,
        [Description("Acorn BBC Mode 2 (160 x 256 Pixels, 16 Colours)")]
        Mode2 = 2,
        [Description("Acorn BBC Mode 4 (320 x 256 Pixels,  2 Colours)")]
        Mode4 = 4,
        [Description("Acorn BBC Mode 5 (160 x 256 Pixels,  4 Colours)")]
        Mode5 = 5
    }
}
