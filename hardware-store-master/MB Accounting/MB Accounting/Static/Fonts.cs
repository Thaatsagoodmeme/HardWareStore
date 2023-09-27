using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MB_Accounting
{
    public static class Fonts
    {
        private static PrivateFontCollection _pfc = new PrivateFontCollection();

        // Load fonts from resources
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        // _pfc.Families[0]
        public static void InitMontserratMediumFont()
        {
            int fontLength = Properties.Resources.Montserrat_Medium.Length;
            byte[] fontData = Properties.Resources.Montserrat_Medium;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);
            _pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);
        }

        // _pfc.Families[1]
        public static void InitMontserratSemiBoldFont()
        {
            int fontLength = Properties.Resources.Montserrat_SemiBold.Length;
            byte[] fontData = Properties.Resources.Montserrat_SemiBold;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);
            _pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);
        }

        // Takes index of font in _pfc.Families array and control and applies the font
        public static void SetPropertyFont(int fontIndex, params Control[] controls)
        {
            try
            {
                foreach (Control c in controls)
                {
                    c.Font = new Font(_pfc.Families[fontIndex], c.Font.Size);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
