using System;
using SkiaSharp;

namespace System.Drawing.Imaging
{
    public sealed class ImageFormat 
    {
        public static SKEncodedImageFormat Bmp { get; set; } = SKEncodedImageFormat.Bmp;

        public static SKEncodedImageFormat Png { get; set; } = SKEncodedImageFormat.Png;

        public static SKEncodedImageFormat MemoryBmp { get; set; } = SKEncodedImageFormat.Wbmp;


        public static SKEncodedImageFormat Tiff { get; set; } = SKEncodedImageFormat.Jpeg;



        public static SKEncodedImageFormat Gif { get; set; } = SKEncodedImageFormat.Gif;

        public static SKEncodedImageFormat Jpeg { get; set; } = SKEncodedImageFormat.Jpeg;


        public static SKEncodedImageFormat Icon { get; set; } = SKEncodedImageFormat.Ico;
    }
}