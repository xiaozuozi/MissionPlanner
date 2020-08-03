using System;

namespace System.Drawing.Imaging
{// System.Drawing.Imaging.EmfPlusRecordType

    public class BitmapData
    {
        public IntPtr Scan0 { get; set; }
        public int Stride { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}