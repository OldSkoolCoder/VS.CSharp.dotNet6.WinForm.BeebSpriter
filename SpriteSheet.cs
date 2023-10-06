using BeebSpriter.Enum;
using BeebSpriter.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BeebSpriter
{
    public class SpriteSheet
    {
        #region Private members

        public enum BackColour
        {
            Transparent,
            Black,
            Red,
            Green,
            Yellow,
            Blue,
            Magenta,
            Cyan,
            White
        };

        private struct Symbol
        {
            public Symbol(string name, int value)
            { this.name = name; this.value = value; }

            public string name;
            public int value;
        };

        //private struct SymbolSprite
        //{
        //    public SymbolSprite(string name, int offset, int size, int width, int height)
        //    { this.name = name; this.offset = offset; this.size = size; this.width = width; this.height = height; }

        //    public string name;
        //    public int offset;
        //    public int size;
        //    public int width;
        //    public int height;
        //};

        private int mode;
        private int xScale;
        private int yScale;
        private int bitsPerPixel;
        private List<Sprite> spriteList = new List<Sprite>();
        private BackColour backgroundColour = BackColour.Transparent;
        private BeebPalette.Colour[] defaultPalette;
        private bool defaultShowGridLines = true;
        private int horizontalBlockDividers = 0;
        private int verticalBlockDividers = 0;
        private int defaultZoom = 6;

        // Members relating to export options

        public enum SpriteDataLayout
        {
            RowMajor,
            ColumnMajor,
            Linear
        };

        private bool hasSetExportSettings = false;
        private SpriteDataLayout spriteLayout = SpriteDataLayout.RowMajor;
        private bool shouldBreakSprites = false;
        private int subSpriteWidth = 2;
        private int subSpriteHeight = 2;
        private bool shouldExportSeparateMask = false;
        private bool shouldGenerateHeader = true;
        private string assemblerSyntax = "{n} = &{v}";
        private string selectedAssembler = Constants.AssemblerVersions.BeebAssembler;

        #endregion

        [XmlAttribute]
        public int Mode
        {
            get
            {
                return this.mode;
            }

            set
            {
                this.mode = value;
                this.yScale = 2;

                switch (this.mode)
                {
                    case 0:
                        this.xScale = 1;
                        this.bitsPerPixel = 1;
                        break;

                    case 1:
                        this.xScale = 2;
                        this.bitsPerPixel = 2;
                        break;

                    case 2:
                        this.xScale = 4;
                        this.bitsPerPixel = 4;
                        break;

                    case 4:
                        this.xScale = 2;
                        this.bitsPerPixel = 1;
                        break;

                    case 5:
                        this.xScale = 4;
                        this.bitsPerPixel = 2;
                        break;

                    default:
                        throw new Exception("Bad Mode (" + mode + ")");
                }
            }
        }

        public int XScale
        {
            get { return this.xScale; }
        }

        public int YScale
        {
            get { return this.yScale; }
        }

        public int NumColours
        {
            get { return 1 << this.bitsPerPixel; }
        }

        public int PixelsPerByte
        {
            get { return 8 / this.bitsPerPixel; }
        }

        public int BitsPerPixel
        {
            get { return this.bitsPerPixel; }
        }

        public BackColour BackgroundColour
        {
            get { return this.backgroundColour; }
            set { this.backgroundColour = value; }
        }

        public BeebPalette.Colour[] DefaultPalette
        {
            get { return this.defaultPalette; }
            set { this.defaultPalette = value; }
        }

        public bool DefaultShowGridLines
        {
            get { return this.defaultShowGridLines; }
            set { this.defaultShowGridLines = value; }
        }

        public int HorizontalBlockDividers
        {
            get { return this.horizontalBlockDividers; }
            set { this.horizontalBlockDividers = value; }
        }

        public int VerticalBlockDividers
        {
            get { return this.verticalBlockDividers; }
            set { this.verticalBlockDividers = value; }
        }

        public int DefaultZoom
        {
            get { return this.defaultZoom; }
            set { this.defaultZoom = value; }
        }

        public bool HasSetExportSettings
        {
            get { return this.hasSetExportSettings; }
            set { this.hasSetExportSettings = value; }
        }

        public SpriteDataLayout SpriteLayout
        {
            get { return this.spriteLayout; }
            set { this.spriteLayout = value; }
        }

        public bool ShouldBreakSprites
        {
            get { return this.shouldBreakSprites; }
            set { this.shouldBreakSprites = value; }
        }

        public int SubSpriteWidth
        {
            get { return this.subSpriteWidth; }
            set { this.subSpriteWidth = value; }
        }

        public int SubSpriteHeight
        {
            get { return this.subSpriteHeight; }
            set { this.subSpriteHeight = value; }
        }

        public bool ShouldExportSeparateMask
        {
            get { return this.shouldExportSeparateMask; }
            set { this.shouldExportSeparateMask = value; }
        }

        public bool ShouldGenerateHeader
        {
            get { return this.shouldGenerateHeader; }
            set { this.shouldGenerateHeader = value; }
        }

        public string AssemblerSyntax
        {
            get { return this.assemblerSyntax; }
            set { this.assemblerSyntax = value; }
        }

        public string SelectedAssembler
        {
            get { return this.selectedAssembler; }
            set { this.selectedAssembler = value; }
        }


        public List<Sprite> SpriteList
        {
            get { return this.spriteList; }
            set { this.spriteList = value; }
        }



        public SpriteSheet()
        {
        }

        public SpriteSheet(int mode)
        {
            Mode = mode;

            SetDefaultPalette();
        }

        /// <summary>
        /// Set Default Palette base on the mode
        /// </summary>        
        public void SetDefaultPalette()
        {
            DefaultPalette = new BeebPalette.Colour[NumColours];

            switch (NumColours)
            {
                case 2:
                    DefaultPalette[0] = BeebPalette.Colour.Black;
                    DefaultPalette[1] = BeebPalette.Colour.White;
                    break;

                case 4:
                    DefaultPalette[0] = BeebPalette.Colour.Black;
                    DefaultPalette[1] = BeebPalette.Colour.Red;
                    DefaultPalette[2] = BeebPalette.Colour.Yellow;
                    DefaultPalette[3] = BeebPalette.Colour.White;
                    break;

                case 16:
                    DefaultPalette[0] = BeebPalette.Colour.Black;
                    DefaultPalette[1] = BeebPalette.Colour.Red;
                    DefaultPalette[2] = BeebPalette.Colour.Green;
                    DefaultPalette[3] = BeebPalette.Colour.Yellow;
                    DefaultPalette[4] = BeebPalette.Colour.Blue;
                    DefaultPalette[5] = BeebPalette.Colour.Magenta;
                    DefaultPalette[6] = BeebPalette.Colour.Cyan;
                    DefaultPalette[7] = BeebPalette.Colour.White;
                    DefaultPalette[8] = BeebPalette.Colour.Black;
                    DefaultPalette[9] = BeebPalette.Colour.Red;
                    DefaultPalette[10] = BeebPalette.Colour.Green;
                    DefaultPalette[11] = BeebPalette.Colour.Yellow;
                    DefaultPalette[12] = BeebPalette.Colour.Blue;
                    DefaultPalette[13] = BeebPalette.Colour.Magenta;
                    DefaultPalette[14] = BeebPalette.Colour.Cyan;
                    DefaultPalette[15] = BeebPalette.Colour.White;
                    break;
            }
        }

        /// <summary>
        /// Change sprite sheet to a different mode
        /// </summary>
        /// <param name="mode"></param>
        public void ChangeMode(int mode)
        {
            Mode = mode;
            SetDefaultPalette();

            foreach (Sprite sprite in SpriteList)
            {
                if (sprite.NumColours > NumColours)
                {
                    sprite.ReduceColours(NumColours);
                }

                // clone the active palette
                BeebPalette.Colour[] clonedPalette = (BeebPalette.Colour[])sprite.Palette.Clone();

                // Create a default palette for the new mode
                sprite.Palette = (BeebPalette.Colour[])DefaultPalette.Clone();

                // copy the cloned active palette to new palette
                for(int i = 0; i < sprite.Palette.Length && i < clonedPalette.Length; i++)
                {
                    sprite.Palette[i] = clonedPalette[i];   
                }
            }
        }

        private List<Symbol>GenerateSpriteFileAndSymbolData(FileStream fs)
        {
            // if fs is null, we wont actual export the data to file.

            List<Symbol> symbols = new List<Symbol>();

            int offset = 0;

            for (int pass = 0; pass < (this.ShouldExportSeparateMask ? 2 : 1); pass++)
            {
                foreach (Sprite s in this.SpriteList)
                {
                    int size = 0;
                    //ExportSprite(fs, s, pass == 1, out size);

                    if (s.Name != "")
                    {
                        string mangledName = Regex.Replace(s.Name, "[^A-Za-z0-9]", "").Replace(' ', '_');
                        if (pass == 1)
                        {
                            mangledName += "_mask";
                        }
                        symbols.Add(new Symbol(mangledName + "_offset", offset));
                        symbols.Add(new Symbol(mangledName + "_size", size));
                        symbols.Add(new Symbol(mangledName + "_width", s.Width / this.PixelsPerByte));
                        symbols.Add(new Symbol(mangledName + "_height", s.Height));
                    }
                    offset += size;
                }
            }

            return symbols;
        }

        private List<SpriteSymbol> GenerateSpriteFileAndSymbolSpriteData(FileStream fs)
        {
            // if fs is null, we wont actual export the data to file.

            List<SpriteSymbol> spriteSymbols = new List<SpriteSymbol>();

            int offset = 0;

            for (int pass = 0; pass < (this.ShouldExportSeparateMask ? 2 : 1); pass++)
            {
                foreach (Sprite s in this.SpriteList)
                {
                    int size;
                    string spriteData = ExportSprite(fs, s, pass == 1, out size);

                    if (s.Name != "")
                    {
                        string mangledName = s.Name.Replace(' ', '_');
                        if (pass == 1)
                        {
                            mangledName += "_mask";
                        }
                        SpriteSymbol spriteInfo = new SpriteSymbol(mangledName, offset, size, s.Width / this.PixelsPerByte, s.Height, this.SelectedAssembler);
                        spriteInfo.spriteData = spriteData;
                        spriteSymbols.Add(spriteInfo);
                    }
                    offset += size;
                }
            }

            return spriteSymbols;
        }

        public string PreviewExport(string assemblerUsed, string projectFilename)
        {
            string spriteASMData = "";
            return PerformExport(null, assemblerUsed, projectFilename, out spriteASMData);
        }

        private string PerformExport(FileStream fs, string assemblerUsed, string projectFilename, out string spriteData)
        {
            string previewText = "";
            spriteData = "";

            projectFilename = Regex.Replace(projectFilename, "[^A-Za-z0-9]", "");

            if (assemblerUsed == Constants.AssemblerVersions.BeebAssembler)
            {
                //                List<Symbol> symbols = new List<Symbol>();
                List<SpriteSymbol> symbolSprite = new List<SpriteSymbol>();

                try
                {
                    //                    symbols = GenerateSpriteFileAndSymbolData(fs);
                    symbolSprite = GenerateSpriteFileAndSymbolSpriteData(fs);

                    if (this.ShouldGenerateHeader)
                    {
                        foreach (SpriteSymbol sym in symbolSprite)
                        {
                            //string command = this.AssemblerSyntax.Replace("{n}", sym.name).Replace("{v}", sym.value) + Environment.NewLine; ;
                            //previewText += command + Environment.NewLine;

                            previewText += this.AssemblerSyntax.Replace("{n}", sym.name + "_offset").Replace("{v}", sym.offset) + Environment.NewLine;
                            previewText += this.AssemblerSyntax.Replace("{n}", sym.name + "_size").Replace("{v}", sym.size) + Environment.NewLine;
                            previewText += this.AssemblerSyntax.Replace("{n}", sym.name + "_width").Replace("{v}", sym.width) + Environment.NewLine;
                            previewText += this.AssemblerSyntax.Replace("{n}", sym.name + "_height").Replace("{v}", sym.height) + Environment.NewLine;
                            spriteData += sym.spriteData;
                        }
                    }
                    previewText += Environment.NewLine;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }
            }
            else
            {
                List<SpriteSymbol> symbolSprite = new List<SpriteSymbol>();

                previewText = projectFilename + ":{" + Environment.NewLine;
                string baseLocation = projectFilename + "_BASELOCATION";
                try
                {
                    symbolSprite = GenerateSpriteFileAndSymbolSpriteData(fs);

                    if (this.ShouldGenerateHeader)
                    {
                        foreach (SpriteSymbol sym in symbolSprite)
                        {
                            previewText += "    " + Regex.Replace(sym.name, "[^A-Za-z0-9]", "") + ":{" + Environment.NewLine;
                            previewText += "        .label OffSet = " + baseLocation + " + $" + sym.offset + Environment.NewLine;
                            previewText += "        .label Size = $" + sym.size + Environment.NewLine;
                            previewText += "        .label Width = $" + sym.width + Environment.NewLine;
                            previewText += "        .label Height = $" + sym.height + Environment.NewLine;
                            previewText += "    }" + Environment.NewLine;

                            spriteData += sym.spriteData;
                        }
                    }
                    previewText += "}" + Environment.NewLine;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }
            }

            return previewText;

        }

        public void Export(string strFileName)
        {
            string headerSymbolicData = "";

            try
            {
                string spriteASMData = "";
                using (FileStream fs = new FileStream(strFileName, FileMode.Create, FileAccess.Write))
                {
                    headerSymbolicData = PerformExport(fs, this.SelectedAssembler, Path.GetFileNameWithoutExtension(strFileName), out spriteASMData);
                }

                if (this.SelectedAssembler == "Constants.AssemblerVersions.KickAssembler")
                {
                    spriteASMData = Path.GetFileNameWithoutExtension(strFileName) + "_BASELOCATION:" + Environment.NewLine + spriteASMData;
                }
                using (StreamWriter sw = new StreamWriter(strFileName + ".asm",false))
                {
                    sw.Write(spriteASMData);
                }

                if (this.ShouldGenerateHeader)
                {
                    using (StreamWriter sw = new StreamWriter(strFileName + ".info"))
                    {
                        sw.Write(headerSymbolicData);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private string ExportSprite(FileStream fs, Sprite sprite, bool generateMask, out int size)
        {
            // Read constants from sprite sheet
            int pixelsPerByte = this.PixelsPerByte;
            int subSpriteWidth = this.SubSpriteWidth;
            int subSpriteHeight = this.SubSpriteHeight;

            int numPiecesAcross = 1;
            int numPiecesDown = 1;
            int pieceBlocksAcross = (sprite.Width + pixelsPerByte - 1) / pixelsPerByte;
            int pieceHeight = sprite.Height;


            string dataExportString = "{labelprefix}" + sprite.Name + (generateMask ? "_MASK":"") + "_DATA";
            dataExportString += "{labelsufix}" + Environment.NewLine;

            if (this.ShouldBreakSprites)
            {
                numPiecesAcross = (pieceBlocksAcross + subSpriteWidth - 1) / subSpriteWidth;
                numPiecesDown = (sprite.Height + subSpriteHeight * 8 - 1) / (subSpriteHeight * 8);
                pieceBlocksAcross = subSpriteWidth;
                pieceHeight = subSpriteHeight * 8;
            }

            size = 0;

            for (int piecey = 0; piecey < numPiecesDown; piecey++)
            {
                for (int piecex = 0; piecex < numPiecesAcross; piecex++)
                {
                    switch (this.SpriteLayout)
                    {
                        case SpriteSheet.SpriteDataLayout.RowMajor:

                            for (int y = 0; y < pieceHeight; y += 8)
                            {
                                for (int x = 0; x < pieceBlocksAcross; x++)
                                {
                                    dataExportString += "{dataprefix}";
                                    for (int l = 0; l < 8; l++)
                                    {
                                        byte beeb = 0;

                                        for (int p = 0; p < pixelsPerByte; p++)
                                        {
                                            int xx = (piecex * pieceBlocksAcross + x) * pixelsPerByte + p;
                                            int yy = piecey * pieceHeight + y + l;
                                            byte pixel = GetPixel(sprite, xx, yy, generateMask);
                                            beeb |= (byte)(GetBeebColour(pixel) << (pixelsPerByte - 1 - p));
                                        }

                                        dataExportString += (l == 0 ? " " : ", ") + "{symbol}" + beeb.ToString("X2");

                                        if (fs != null)
                                        {
                                            fs.WriteByte(beeb);
                                        }
                                        size++;
                                    }
                                    dataExportString += Environment.NewLine;
                                }
                            }

                            break;

                        case SpriteSheet.SpriteDataLayout.ColumnMajor:

                            for (int x = 0; x < pieceBlocksAcross; x++)
                            {
                                dataExportString += "{dataprefix}";
                                for (int y = 0; y < pieceHeight; y++)
                                {
                                    byte beeb = 0;

                                    for (int p = 0; p < pixelsPerByte; p++)
                                    {
                                        int xx = (piecex * pieceBlocksAcross + x) * pixelsPerByte + p;
                                        int yy = piecey * pieceHeight + y;
                                        byte pixel = GetPixel(sprite, xx, yy, generateMask);
                                        beeb |= (byte)(GetBeebColour(pixel) << (pixelsPerByte - 1 - p));
                                    }

                                    dataExportString += (y == 0 ? " " : ", ") + "{symbol}" + beeb.ToString("X2");

                                    if (fs != null)
                                    {
                                        fs.WriteByte(beeb);
                                    }
                                    size++;
                                    dataExportString += Environment.NewLine;
                                }
                            }

                            break;

                        case SpriteSheet.SpriteDataLayout.Linear:

                            for (int y = 0; y < pieceHeight; y++)
                            {
                                dataExportString += "{dataprefix}";
                                for (int x = 0; x < pieceBlocksAcross; x++)
                                {
                                    byte beeb = 0;

                                    for (int p = 0; p < pixelsPerByte; p++)
                                    {
                                        int xx = (piecex * pieceBlocksAcross + x) * pixelsPerByte + p;
                                        int yy = piecey * pieceHeight + y;
                                        byte pixel = GetPixel(sprite, xx, yy, generateMask);
                                        beeb |= (byte)(GetBeebColour(pixel) << (pixelsPerByte - 1 - p));
                                    }

                                    dataExportString += (x == 0 ? " " : ", ") + "{symbol}" + beeb.ToString("X2");
                                    if (fs != null)
                                    {
                                        fs.WriteByte(beeb);
                                    }
                                    size++;
                                    dataExportString += Environment.NewLine;
                                }
                            }

                            break;
                    }
                }
            }

            return dataExportString;
        }

        private byte GetPixel(Sprite sprite, int x, int y, bool generateMask)
        {
            byte pixel = 255;

            if (x >= 0 && x < sprite.Width && y >= 0 && y < sprite.Height)
            {
                pixel = sprite.Bitmap[x + y * sprite.Width];
            }

            if (generateMask)
            {
                return (byte)((pixel == 255) ? this.NumColours - 1 : 0);
            }
            else
            {
                return (byte)((pixel == 255) ? 0 : pixel);
            }
        }

        private byte GetBeebColour(byte colour)
        {
            byte beebByte = 0;
            for (int i = 0; i < this.BitsPerPixel; i++)
            {
                if ((colour & (1 << i)) != 0)
                {
                    beebByte |= (byte)(1 << (i * this.PixelsPerByte));
                }
            }

            return beebByte;
        }



    }
}
