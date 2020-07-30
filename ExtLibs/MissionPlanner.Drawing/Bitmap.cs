using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SkiaSharp;

//[assembly: AssemblyTitle("System.Drawing.dll")]
[assembly: AssemblyDescription("System.Drawing.dll")]
[assembly: AssemblyDefaultAlias("System.Drawing.dll")]

//[assembly: AssemblyCompany(Consts.MonoCompany)]
//[assembly: AssemblyProduct(Consts.MonoProduct)]
[assembly: AssemblyCopyright(Consts.MonoCopyright)]
//[assembly: AssemblyVersion(Consts.FxVersion)]
[assembly: SatelliteContractVersion(Consts.FxVersion)]
//[assembly: AssemblyInformationalVersion(Consts.FxFileVersion)]

[assembly: NeutralResourcesLanguage("en-US")]

[assembly: ComVisible(false)]
[assembly: ComCompatibleVersion(1, 0, 3300, 0)]
//[assembly: AllowPartiallyTrustedCallers]

[assembly: CLSCompliant(true)]
//[assembly: AssemblyDelaySign (true)]

//[assembly: AssemblyFileVersion(Consts.FxFileVersion)]
[assembly: CompilationRelaxations(CompilationRelaxations.NoStringInterning)]
[assembly: Dependency("System,", LoadHint.Always)]



//[assembly: AssemblyDelaySign(true)]
//[assembly: AssemblyKeyFile("ecma.pub")]

static class Consts
{
    //
    // Use these assembly version constants to make code more maintainable.
    //

    public const string MonoVersion = "@MONO_VERSION@";
    public const string MonoCompany = "Mono development team";
    public const string MonoProduct = "Mono Common Language Infrastructure";
    public const string MonoCopyright = "(c) Various Mono authors";
    public const int MonoCorlibVersion = 1;


	public const string FxVersion = "4.0.0.0";
	public const string FxFileVersion = "4.6.57.0";
	public const string EnvironmentVersion = "4.0.30319.42000";

	public const string VsVersion = "0.0.0.0"; // Useless ?
	public const string VsFileVersion = "11.0.0.0"; // TODO:


#if MOBILE
	const string PublicKeyToken = "7cec85d7bea7798e";
#else
    const string PublicKeyToken = "b77a5c561934e089";
#endif

    //
    // Use these assembly name constants to make code more maintainable.
    //

    public const string AssemblyI18N = "I18N, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    public const string AssemblyMicrosoft_JScript = "Microsoft.JScript, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblyMicrosoft_VisualStudio = "Microsoft.VisualStudio, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblyMicrosoft_VisualStudio_Web = "Microsoft.VisualStudio.Web, Version=" + VsVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblyMicrosoft_VSDesigner = "Microsoft.VSDesigner, Version=" + VsVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblyMono_Http = "Mono.Http, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    public const string AssemblyMono_Posix = "Mono.Posix, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    public const string AssemblyMono_Security = "Mono.Security, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    public const string AssemblyMono_Messaging_RabbitMQ = "Mono.Messaging.RabbitMQ, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    public const string AssemblyCorlib = "mscorlib, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=" + PublicKeyToken;
    public const string AssemblySystem = "System, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";
    public const string AssemblySystem_Data = "System.Data, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";
    public const string AssemblySystem_Design = "System.Design, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_DirectoryServices = "System.DirectoryServices, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_Drawing = "System.Drawing, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_Drawing_Design = "System.Drawing.Design, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_Messaging = "System.Messaging, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_Security = "System.Security, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_ServiceProcess = "System.ServiceProcess, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_Web = "System.Web, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    public const string AssemblySystem_Windows_Forms = "System.Windows.Forms, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";
#if NET_4_0
	public const string AssemblySystem_2_0 = "System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystemCore_3_5 = "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Core = "System.Core, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string WindowsBase_3_0 = "WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyWindowsBase = "WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationCore_3_5 = "PresentationCore, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationCore_4_0 = "PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationFramework_3_5 = "PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblySystemServiceModel_3_0 = "System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
#elif MOBILE
	public const string AssemblySystem_Core = "System.Core, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";
#endif
}

namespace System.Drawing
{
    public class Bitmap : Image
    {
        private object p;
        private Size size;

        public Bitmap(int width, int height, int stride, SKColorType bgra8888 = (SKColorType.Bgra8888),
            IntPtr data = default(IntPtr))
        {
            nativeSkBitmap = new SKBitmap(new SKImageInfo(width, height, bgra8888));
            nativeSkBitmap.SetPixels(data);
        }

        public Bitmap(int width, int height, int stride, PixelFormat bgra8888 = (Drawing.PixelFormat.Format32bppArgb),
            IntPtr data = default(IntPtr))
        {
            nativeSkBitmap = new SKBitmap(new SKImageInfo(width, height, SKColorType.Bgra8888));
            nativeSkBitmap.SetPixels(data);
        }

        public Bitmap(int width, int height, SKColorType colorType = (SKColorType.Bgra8888))
        {
            nativeSkBitmap = new SKBitmap(new SKImageInfo(width, height, colorType));
            nativeSkBitmap.Erase(SKColor.Empty);
        }

        public Bitmap(Stream stream)
        {
            nativeSkBitmap = SKBitmap.Decode(stream);
        }

        public static implicit operator Bitmap(byte[] data)
        {
            return new Bitmap(new MemoryStream(data));
        }
        internal Bitmap()
        {
        }

        public static implicit operator SKImage(Bitmap input)
        {
            return SKImage.FromBitmap(input.nativeSkBitmap);
        }

        public Bitmap(int clientSizeWidth, int clientSizeHeight, Graphics realDc)
        {
            nativeSkBitmap = new SKBitmap(new SKImageInfo(clientSizeWidth, clientSizeHeight, SKColorType.Bgra8888));
            nativeSkBitmap.Erase(SKColor.Empty);
            //nativeSkBitmap.SetPixels(realDc._surface.);
        }

        public Bitmap(string filename)
        {
            using (var f = File.OpenRead(filename))
                nativeSkBitmap = SKBitmap.Decode(f);
        }

        public Bitmap(Image image)
        {
            nativeSkBitmap = image.nativeSkBitmap.Copy();
        }

        public Bitmap(byte[] largeIconsImage, Size clientSizeHeight)
        {
            nativeSkBitmap = SKBitmap.Decode(SKData.CreateCopy(largeIconsImage)).Resize(
                new SKImageInfo(clientSizeHeight.Width, clientSizeHeight.Height),
                SKFilterQuality.High);
        }

        public Bitmap(Image largeIconsImage, Size clientSizeHeight)
        {
            SKBitmap ans = new SKBitmap(clientSizeHeight.Width, clientSizeHeight.Height, SKColorType.Bgra8888, SKAlphaType.Premul);
            largeIconsImage.nativeSkBitmap.ScalePixels(ans, SKFilterQuality.Medium);
            nativeSkBitmap = ans;
        }

        public Bitmap(Image largeIconsImage, int x, int y)
        {
            SKBitmap ans = new SKBitmap(x, y, SKColorType.Bgra8888, SKAlphaType.Premul);
            largeIconsImage.nativeSkBitmap.ScalePixels(ans, SKFilterQuality.Medium);
            nativeSkBitmap = ans;
        }

        public Bitmap(int width, int height, PixelFormat format4BppIndexed): this(width, height, SKColorType.Bgra8888)
        {
        }

        public Bitmap(Type clientSizeWidth, string propertygridCategorizedPng)
        {
            // no idea
        }

        public Bitmap(Bitmap bmp, Size size): this(bmp, size.Width,size.Height)
        {
         
        }

        public Bitmap(byte[] camera_icon_G, int v1, int v2): this(camera_icon_G, new Size(v1,v2))
        {
        }

        public SKColorType PixelFormat
        {
            get { return nativeSkBitmap.ColorType; }

            set { }
        }

        public ColorPalette Palette { get; set; } = new ColorPalette(256);

        public BitmapData LockBits(Rectangle rectangle, object writeOnly, SKColorType imgPixelFormat)
        {
            return new BitmapData()
            {
                Scan0 = nativeSkBitmap.GetPixels(),
                Stride = nativeSkBitmap.RowBytes,
                Width = nativeSkBitmap.Width,
                Height = nativeSkBitmap.Height
            };
        }

        public void UnlockBits(BitmapData bmpData)
        {
            bmpData = null;
        }
        public void MakeTransparent()
        {
            if (nativeSkBitmap.IsEmpty)
                nativeSkBitmap.Erase(SKColor.Empty);
        }
        public void MakeTransparent(Color transparent)
        {
            if(nativeSkBitmap.IsEmpty)
                nativeSkBitmap.Erase(SKColor.Empty);
        }

        public Color GetPixel(int c2, int c1)
        {
            return nativeSkBitmap.GetPixel(c2, c1).ToColor();
        }

        public void SetPixel(int i, int i1, Color transparent)
        {
            nativeSkBitmap.SetPixel(i,i1, transparent.ToSKColor());
        }

        public Image GetThumbnailImage(int v1, int v2, GetThumbnailImageAbort myCallback, IntPtr zero)
        {
            SKBitmap ans = new SKBitmap(v1, v2, SKColorType.Bgra8888, SKAlphaType.Premul);
            nativeSkBitmap.ScalePixels(ans, SKFilterQuality.Medium);
            return new Bitmap() {nativeSkBitmap = ans, PixelFormat = SKColorType.Bgra8888};
        }

        public BitmapData LockBits(Rectangle rectangle, ImageLockMode readWrite, PixelFormat format32BppArgb)
        {
            return LockBits(rectangle, readWrite, SKColorType.Rgba8888);
        }

        public void RotateFlip(RotateFlipType rotateNoneFlipX)
        {
            //
        }

    }
}