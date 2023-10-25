using BeebSpriter.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BeebSpriter.Internal
{
    internal static class Extensions
    {
        /// <summary>
        /// Converts the object value of this instance to its equivalent integer representation.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Converted object or default value of 0</returns>
        public static int ToInteger(this object obj)
        {
            int result = 0;

            if (obj != null && !int.TryParse(obj.ToString(), out result))
                result = 0;

            return result;
        }

        /// <summary>
        /// Converts the object value of this instance to its equivalent hex representation.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static string ToHex(this Object obj)
        {
            string result = string.Empty;

            if (obj != null)
            {
                result = string.Format("{0:X2}", obj.ToInteger());
            }

            return result;
        }

        /// <summary>
        /// Converts the object value of this instance to its equivalent binary representation.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Converted object or default value of 00000000</returns>
        public static string ToBinary(this Object obj)
        {
            string result = string.Empty;

            if (obj != null)
            {
                result = Convert.ToString(obj.ToInteger(), 2).PadLeft(8, '0');
            }

            return result;
        }

        /// <summary>
        /// Get the description field from the Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToDescription<T>(this T source)
        {
            FieldInfo fieldInfo = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }

        /// <summary>
        /// Get the Enum from the Description field
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static T ToEnum<T>(string value)
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (DescriptionAttribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == value)
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            throw new ArgumentException(string.Format("Not found '{0}' in Enum", nameof(value)));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="spriteView"></param>
        public static void ReleaseAll(this List<SpriteObject> spriteView)
        {
            foreach (SpriteObject obj in spriteView)
                spriteView.Release(obj);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="spriteView"></param>
        /// <param name="spriteObject"></param>
        public static void Release(this List<SpriteObject> spriteView, SpriteObject spriteObject)
        {
            int index = spriteView.IndexOf(spriteObject);
            if (index != -1)
            {
                spriteView[index].Selected = false;
                spriteView[index].SelectedNode = NodeLocation.None;
            }
        }

        /// <summary>
        /// Count to the number of different colours in a sprite
        /// </summary>
        /// <param name="Image"></param>
        /// <param name="palette"></param>
        /// <param name="conv"></param>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        /// <returns></returns>
        public static int[] CountPalette(this Bitmap Image, BeebPalette palette)
        {
            int[] colourCount = new int[16];

            RectangleF cloneRect = new(0, 0, Image.Width, Image.Height);

            Bitmap cloneImage = Image.Clone(cloneRect, Image.PixelFormat);

            Bitmap newImage = new(cloneImage);

            Rectangle rect = new(0, 0, newImage.Width, newImage.Height);
            BitmapData bmpData = newImage.LockBits(rect, ImageLockMode.ReadWrite, newImage.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * newImage.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                int b = rgbValues[counter];
                int g = rgbValues[counter + 1];
                int r = rgbValues[counter + 2];
                int a = rgbValues[counter + 3];

                Color origColour = Color.FromArgb(a, r, g, b);

                Color rgbColour = palette.FindClosestRGBColour(origColour);

                int index = palette.GetAcornColour(rgbColour);

                colourCount[index]++;
            }

            // Unlock the bits.
            newImage.UnlockBits(bmpData);
            newImage.Dispose();

            return colourCount;
        }

        /// <summary>
        /// Convert image to Acorn image
        /// </summary>
        /// <param name="Image"></param>
        /// <param name="palette"></param>
        /// <param name="conv"></param>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        /// <returns></returns>
        public static Bitmap ToAcornFormat(this Bitmap Image, BeebPalette palette)
        {
            RectangleF cloneRect = new(0, 0, Image.Width, Image.Height);

            Bitmap cloneImage = Image.Clone(cloneRect, Image.PixelFormat);

            Bitmap newImage = new(cloneImage);

            Rectangle rect = new(0, 0, newImage.Width, newImage.Height);
            BitmapData bmpData = newImage.LockBits(rect, ImageLockMode.ReadWrite, newImage.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * newImage.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                int b = rgbValues[counter];
                int g = rgbValues[counter + 1];
                int r = rgbValues[counter + 2];
                int a = rgbValues[counter + 3];

                Color originalColour = Color.FromArgb(a, r, g, b);

                Color rgbColour = palette.FindClosestRGBColour(originalColour);

                rgbValues[counter] = rgbColour.B;
                rgbValues[counter + 1] = rgbColour.G;
                rgbValues[counter + 2] = rgbColour.R;
                rgbValues[counter + 3] = rgbColour.A;
            }

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            newImage.UnlockBits(bmpData);

            return newImage;
        }

        /// <summary>
        /// Extract sprite from an image
        /// </summary>
        /// <param name="Image"></param>
        /// <param name="palette"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static byte[] ExtractSprite(this Bitmap Image, BeebPalette palette, Rectangle rect)
        {
            byte[] data = new byte[rect.Width * rect.Height];

            BitmapData bmpData = Image.LockBits(rect, ImageLockMode.ReadWrite, Image.PixelFormat);

            // Get the address of the first line.
            IntPtr source = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * rect.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(source, rgbValues, 0, bytes);

            int counter = 0;
            for (int y = 0; y < rect.Height; y++)
            {
                for (int x = 0; x < rect.Width; x++)
                {
                    int ptr = (y * bmpData.Stride + (x * 4));

                    int pixel = 0;

                    if (ptr < rgbValues.Length)
                    {
                        int b = rgbValues[ptr];
                        int g = rgbValues[ptr + 1];
                        int r = rgbValues[ptr + 2];
                        int a = rgbValues[ptr + 3];

                        Color col = Color.FromArgb(a, r, g, b);

                        pixel = palette.GetAcornColour(col);
                    }

                    data[counter++] = (byte)pixel;
                }
            }

            // Unlock the bits.
            Image.UnlockBits(bmpData);

            return data;
        }

        /// <summary>
        /// Convert Beeb Sprite image into Windows Bitmap image
        /// </summary>
        /// <param name="sprite"></param>
        /// <param name="palette"></param>
        /// <returns></returns>
        public static Bitmap ToImage(this Sprite sprite, BeebPalette palette)
        {
            Bitmap newImage = new(sprite.Width, sprite.Height, PixelFormat.Format32bppArgb);

            Rectangle rect = new(0, 0, newImage.Width, newImage.Height);
            BitmapData bmpData = newImage.LockBits(rect, ImageLockMode.ReadWrite, newImage.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * newImage.Height;
            byte[] rgbValues = new byte[bytes];

            int counter = 0;

            for (int index = 0; index < sprite.Bitmap.Length; index++)
            {
                int pixel = sprite.Bitmap[index];

                Color rgbColour = (pixel != 255) ? palette.WinColours[pixel] : Color.Gray;

                rgbValues[counter++] = rgbColour.B;
                rgbValues[counter++] = rgbColour.G;
                rgbValues[counter++] = rgbColour.R;
                rgbValues[counter++] = rgbColour.A;
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);
            newImage.UnlockBits(bmpData);

            return newImage;
        }

        /// <summary>
        /// Rotate Image by a set angle
        /// </summary>
        /// <param name="image"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Bitmap RotateImage(this Bitmap image, float angle)
        {
            Bitmap newImage = new(image.Width, image.Height);

            SolidBrush transparentBrush = new(Color.Gray);

            Graphics gfx = Graphics.FromImage(newImage);

            gfx.SmoothingMode = SmoothingMode.None;
            gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
            gfx.CompositingMode = CompositingMode.SourceCopy;
            gfx.CompositingQuality = CompositingQuality.HighSpeed;
            gfx.PixelOffsetMode = PixelOffsetMode.Half;

            gfx.FillRectangle(transparentBrush, 0, 0, image.Width, image.Height);

            gfx.TranslateTransform((float)newImage.Width / 2, (float)newImage.Height / 2);
            gfx.RotateTransform(angle);
            gfx.TranslateTransform(-(float)newImage.Width / 2, -(float)newImage.Height / 2);

            gfx.DrawImage(image, new Point(0, 0));
            gfx.Dispose();

            return newImage;
        }

        /// <summary>
        /// Convert C64 colour to Beeb colour
        /// </summary>
        /// <param name="colour"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static BeebColourType ToBeebColour(this C64ColourType colour)
        {
            return colour switch
            {
                C64ColourType.Black => BeebColourType.Black,
                C64ColourType.White => BeebColourType.White,
                C64ColourType.Red => BeebColourType.Red,
                C64ColourType.Cyan => BeebColourType.Cyan,
                C64ColourType.Purple => BeebColourType.Magenta,
                C64ColourType.Green => BeebColourType.Green,
                C64ColourType.Blue => BeebColourType.Blue,
                C64ColourType.Yellow => BeebColourType.Yellow,
                C64ColourType.Orange => BeebColourType.Yellow,
                C64ColourType.Brown => BeebColourType.Red,
                C64ColourType.Pink => BeebColourType.Magenta,
                C64ColourType.DarkGrey => BeebColourType.Black,
                C64ColourType.MediumGrey => BeebColourType.Blue,
                C64ColourType.LightGreen => BeebColourType.Green,
                C64ColourType.LightBlue => BeebColourType.Blue,
                C64ColourType.LightGrey => BeebColourType.White,
                _ => throw new Exception("Unknown Colour"),
            };
        }
    }
};