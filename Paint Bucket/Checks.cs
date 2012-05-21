using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualBounds.Imaging.PaintBucket
{

    public class Checks
    {
        public enum Theme
        {
            Aero,
            Basic,
            None
        }

        public static Theme CheckTheme()
        {
            if (Win32API.Dwm.DwmIsCompositionEnabled())
                return Theme.Aero;
            else if (Win32API.GetThemeName().Contains("Aero.msstyle"))
                return Theme.Basic;
            else
                return Theme.None;
        }

        public static bool isActive(IntPtr Handle)
        {
            return (Handle == Win32API.GetForegroundWindow());
        }
    }
}
