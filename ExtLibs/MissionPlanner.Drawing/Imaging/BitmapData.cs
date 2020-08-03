using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Drawing.Imaging
{// System.Drawing.Imaging.EmfPlusRecordType
    [StructLayout(LayoutKind.Sequential)]
    public sealed class EncoderParameter
    {
    }

    public class EncoderParameters
    {
        private int v;

        public EncoderParameters(int v)
        {
            this.v = v;
        }

        private EncoderParameter[] _param;

        public EncoderParameter[] Param
        {
            get
            {
                return _param;
            }
            set
            {
                _param = value;
            }
        }
    }

    public sealed class Encoder
    {
        public static object Quality = new Encoder(new Guid(492561589, -1462, 17709, new byte[8]
        {
            156,
            221,
            93,
            179,
            81,
            5,
            231,
            235
        }));

        private Guid _guid;

        public Guid Guid => _guid;

        public Encoder(Guid guid)
        {
            _guid = guid;
        }
    }

    public sealed class ImageCodecInfo
    {
        public static IEnumerable<ImageCodecInfo> GetImageEncoders()
        {
            return new ImageCodecInfo[0];
        }

        public string MimeType { get; set; }
    }

    public class BitmapData
    {
        public IntPtr Scan0 { get; set; }
        public int Stride { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}