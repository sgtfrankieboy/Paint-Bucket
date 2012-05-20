using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace VisualBounds.Imaging.PaintBucket
{
    public static class Win32API
    {
        #region SetWindowTheme

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, String pszSubAppName, String pszSubIdList);

        #endregion

        public static class Dwm
        {
            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmEnableBlurBehindWindow(
                IntPtr hWnd, DWM_BLURBEHIND pBlurBehind);

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmExtendFrameIntoClientArea(
                IntPtr hWnd, MARGINS pMargins);

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern bool DwmIsCompositionEnabled();

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmEnableComposition(bool bEnable);

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmGetColorizationColor(
                out int pcrColorization,
                [MarshalAs(UnmanagedType.Bool)]out bool pfOpaqueBlend);

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern IntPtr DwmRegisterThumbnail(
                IntPtr dest, IntPtr source);

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmUnregisterThumbnail(IntPtr hThumbnail);

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmUpdateThumbnailProperties(
                IntPtr hThumbnail, DWM_THUMBNAIL_PROPERTIES props);

            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmQueryThumbnailSourceSize(
                IntPtr hThumbnail, out Size size);

            [StructLayout(LayoutKind.Sequential)]
            public class DWM_THUMBNAIL_PROPERTIES
            {
                public uint dwFlags;
                public RECT rcDestination;
                public RECT rcSource;
                public byte opacity;
                [MarshalAs(UnmanagedType.Bool)]
                public bool fVisible;
                [MarshalAs(UnmanagedType.Bool)]
                public bool fSourceClientAreaOnly;
                public const uint DWM_TNP_RECTDESTINATION = 0x00000001;
                public const uint DWM_TNP_RECTSOURCE = 0x00000002;
                public const uint DWM_TNP_OPACITY = 0x00000004;
                public const uint DWM_TNP_VISIBLE = 0x00000008;
                public const uint DWM_TNP_SOURCECLIENTAREAONLY = 0x00000010;
            }

            [StructLayout(LayoutKind.Sequential)]
            public class MARGINS
            {
                public int cxLeftWidth, cxRightWidth,
                           cyTopHeight, cyBottomHeight;

                public MARGINS(int left, int top, int right, int bottom)
                {
                    cxLeftWidth = left; cyTopHeight = top;
                    cxRightWidth = right; cyBottomHeight = bottom;
                }
            }

            [StructLayout(LayoutKind.Sequential)]
            public class DWM_BLURBEHIND
            {
                public uint dwFlags;
                [MarshalAs(UnmanagedType.Bool)]
                public bool fEnable;
                public IntPtr hRegionBlur;
                [MarshalAs(UnmanagedType.Bool)]
                public bool fTransitionOnMaximized;

                public const uint DWM_BB_ENABLE = 0x00000001;
                public const uint DWM_BB_BLURREGION = 0x00000002;
                public const uint DWM_BB_TRANSITIONONMAXIMIZED = 0x00000004;
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int left, top, right, bottom;

                public RECT(int left, int top, int right, int bottom)
                {
                    this.left = left; this.top = top;
                    this.right = right; this.bottom = bottom;
                }
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("uxtheme", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public extern static Int32 GetCurrentThemeName(StringBuilder stringThemeName, int lengthThemeName, StringBuilder stringColorName, int lengthColorName, StringBuilder stringSizeName, int lengthSizeName);

        public static string GetThemeName()
        {
            StringBuilder sbFilename = new StringBuilder(0x200);
            Int32 s = GetCurrentThemeName(sbFilename, 0x200, null, 0, null, 0);

            return sbFilename.ToString();
        }
    }
}
