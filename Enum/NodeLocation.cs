using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeebSpriter.Enum
{
    public enum NodeLocation
    {
        None = 0,
        LeftTop = 1,
        TopMiddle = 2,
        RightTop = 3,            // 1--2--3
        RightMiddle = 4,         // |     |
        RightBottom = 5,         // 8  9  4
        BottomMiddle = 6,        // |     |
        LeftBottom = 7,          // 7--6--5
        LeftMiddle = 8,
        Everything = 9
    }
}
