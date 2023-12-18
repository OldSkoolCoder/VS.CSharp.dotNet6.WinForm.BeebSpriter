using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BeebSpriter.Internal
{
    public static class Helper
    {
        /// <summary>
        /// Get a list of valid images
        /// </summary>
        /// <returns></returns>
        public static string GetImageFilter()
        {
            string result = string.Empty;

            string sep = string.Empty;
            foreach (var codec in ImageCodecInfo.GetImageEncoders())
            {
                string codecName = codec.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                result = string.Format("{0}{1}{2} ({3})|{3}", result, sep, codecName, codec.FilenameExtension);
                sep = "|";
            }
            result = string.Format("{0}{1}{2} ({3})|{3}", result, sep, "All Files", "*.*");

            result = "All images|*.bmp;*.dib;*.rle;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.png|" + result;

            return result;
        }

        public static string CheckNameOfSprite(List<Sprite> spriteList, string SpriteName, ref TextBox textBox)
        {
            if (SpriteName == "")
            {
                return "Please Specify a name.";
            }
            else
            {
                string newSpriteName = CorrectSpriteName(SpriteName);

                if (newSpriteName != SpriteName)
                {
                    textBox.Text = newSpriteName;
                    return "Only AlphaNumeric Characters Allowed.";
                }
                else
                {
                    string sError = "";
                    if (CheckForDuplicateNames(spriteList, newSpriteName))
                    {
                        sError = "This name is already in use";
                    };
                    return sError;
                }
            }

        }

        public static string CorrectSpriteName(string SpriteName)
        {
            string newSpriteName = SpriteName;
            Regex rgx = new Regex("[^a-zA-Z0-9-_]");
            newSpriteName = rgx.Replace(newSpriteName, "");
            return newSpriteName;
        }

        //public static bool CheckForDuplicateNames(List<Sprite> spriteList, string SpriteName)
        //{
        //    bool bError = false;
        //    foreach (Sprite sprite in spriteList)
        //    {
        //        if (sprite.Name.ToLower() == SpriteName.ToLower())
        //        {
        //            bError = true;
        //            break;
        //        }
        //    }
        //    return bError;
        //}

        public static bool CheckForDuplicateNames(List<Sprite> spriteList, string SpriteName, int? instances = 0)
        {
            int noFound = 0;
            foreach (Sprite sprite in spriteList)
            {
                if (sprite.Name.ToLower() == SpriteName.ToLower())
                {
                    noFound ++;
                }
            }

            if (noFound > instances)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}