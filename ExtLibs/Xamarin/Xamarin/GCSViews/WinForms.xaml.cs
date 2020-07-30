using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using Xamarin.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Application = System.Windows.Forms.Application;
using Form = System.Windows.Forms.Form;
using Label = System.Windows.Forms.Label;

namespace Xamarin.GCSViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinForms : ContentPage
    {
        public WinForms()
        {
            InitializeComponent();

            StartThreads();
        }

        private void StartThreads()
        {
            new Thread(() =>
            {
                var frm = new Form();
                frm.Controls.Add(new Label());
                frm.Controls.Add(new RadioButton());
                frm.Controls.Add(new CheckBox());
                frm.Controls.Add(new ComboBox());
                frm.Controls.Add(new DomainUpDown());
                frm.Controls.Add(new DataGridView());
                frm.Controls.Add(new TextBox());
                Application.Run(frm);
            }).Start();

            Forms.Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                this.MySkCanvasView.InvalidateSurface();
                return true;
            });

            this.MySkCanvasView.PaintSurface += MySkCanvasView_PaintSurface;
        }

        private void MySkCanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            try
            {
                var surface = e.Surface;

                Func<IntPtr, bool> func = null;
                func = (handle) =>
                {
                    var hwnd = Hwnd.ObjectFromHandle(handle);

                    var x = 0;
                    var y = 0;

                    XplatUI.driver.ClientToScreen(hwnd.client_window, ref x, ref y);

                    var width = 0;
                    var height = 0;
                    var client_width = 0;
                    var client_height = 0;

                    Monitor.Enter(XplatUIMine.paintlock);
                    if (hwnd.hwndbmp != null && hwnd.Mapped && hwnd.Visible)
                    {
                        if (hwnd.ClientWindow != hwnd.WholeWindow)
                        {
                            surface.Canvas.DrawImage(hwnd.hwndbmpNC.ToSKImage(), new SKPoint(hwnd.X, hwnd.Y - XplatUI.CaptionHeight), new SKPaint() { FilterQuality = SKFilterQuality.Low });
                        }
                        surface.Canvas.DrawImage(hwnd.hwndbmp.ToSKImage(), new SKPoint(x + hwnd.ClientRect.X, y + hwnd.ClientRect.Y), new SKPaint() { FilterQuality = SKFilterQuality.Low });
                    }
                    Monitor.Exit(XplatUIMine.paintlock);

                    surface.Canvas.DrawText(x + " " + y, x, y + 10, new SKPaint() { Color = SKColors.Red });

                    if (hwnd.Mapped && hwnd.Visible)
                    {
                        var enumer = Hwnd.windows.GetEnumerator();
                        while (enumer.MoveNext())
                        {
                            var hwnd2 = (System.Collections.DictionaryEntry)enumer.Current;
                            var Key = (IntPtr)hwnd2.Key;
                            var Value = (Hwnd)hwnd2.Value;
                            if (Value.ClientWindow == Key && Value.Parent == hwnd && Value.Visible && Value.Mapped)
                                func(Value.ClientWindow);
                        }
                    }

                    return true;
                };

                foreach (Form form in Application.OpenForms)
                {
                    if (form.IsHandleCreated)
                    {
                        try
                        {

                            func(form.Handle);
                        }
                        finally
                        {

                        }
                    }
                }

                foreach (Hwnd hw in Hwnd.windows.Values)
                {
                    if (hw.topmost && hw.Mapped && hw.Visible)
                    {
                        var ctlmenu = Control.FromHandle(hw.ClientWindow);
                        if (ctlmenu != null)
                            func(hw.ClientWindow);
                    }
                }

            }
            catch { }
        }
    }
}