using System.Drawing.Imaging;

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
    }
}