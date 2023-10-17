using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeebSpriter.Internal
{
    public class AnimationSet
    {
        public String Name {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<String> Sprites { get; set; }

        public AnimationSet() 
        {
            Sprites = new List<String>();
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
