using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VisualBounds.Imaging.PaintBucket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new FRM_Main(args));
        }
    }
}
