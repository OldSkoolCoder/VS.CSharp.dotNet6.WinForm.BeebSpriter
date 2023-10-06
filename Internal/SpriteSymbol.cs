using BeebSpriter.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeebSpriter.Internal
{
    internal class SpriteSymbol
    {

        private string _name;
        private int _offset;
        private int _size;
        private int _width;
        private int _height;
        private string _selectedAssembler;
        private string _spriteData;

        public SpriteSymbol(string name, int offset, int size, int width, int height, string selectedAssembler)
        {
            this._name = name; 
            this._offset = offset; 
            this._size = size; 
            this._width = width; 
            this._height = height;
            this._selectedAssembler = selectedAssembler;
        }

        private string labelPreFix
        {
            get
            {
                return this._selectedAssembler == Constants.AssemblerVersions.BeebAssembler ? "." : "";
            }
        }

        private string labelSuFix
        {
            get
            {
                return this._selectedAssembler == Constants.AssemblerVersions.BeebAssembler ? "" : ":";
            }
        }

        private string dataPreFix
        {
            get
            {
                return this._selectedAssembler == Constants.AssemblerVersions.BeebAssembler ? "EQUB" : ".byte";
            }
        }

        private string preFix
        {
            get
            {
                return this._selectedAssembler == Constants.AssemblerVersions.BeebAssembler ? "&" : "$";
            }
        }

        public string name {
            get
            {
                return Regex.Replace(this._name.Replace(' ', '_'), "[^A-Za-z0-9]", "");
            }
        }

        public string offset
        {
            get
            {
                return this._offset.ToString("X2");
            }
        }

        public string size
        {
            get
            {
                return this._size.ToString("X2");
            }
        }

        public string width
        {
            get
            {
                return this._width.ToString("X2");
            }
        }
        public string height
        {
            get
            {
                return this._height.ToString("X2");
            }
        }

        public string spriteData
        {
            get
            {
                return this._spriteData.Replace("{symbol}", this.preFix).Replace("{labelprefix}", this.labelPreFix).Replace("{labelsufix}", this.labelSuFix).Replace("{dataprefix}", this.dataPreFix);
            }
            set
            {
                this._spriteData = value;
            }
        }
    }
}
