using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Text;

namespace ctiencrypt
{
    class config
    {
        public const string Version = "6.0.2";

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        public static PrivateFontCollection FontSegoeUI = new PrivateFontCollection();
    }
}
