using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MorseCodeDecoder
{
    public class Process_Location
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect
        {
            public int Left { get; set; }        // x position of upper-left corner
            public int Top { get; set; }         // y position of upper-left corner
            public int Right { get; set; }       // x position of lower-right corner
            public int Bottom { get; set; }      // y position of lower-right corner
        }

        public static Rectangle ProcessLocation(string process_name)
        {
            Process[] processes = Process.GetProcessesByName(process_name);
            Process process = processes[0];
            IntPtr ptr = process.MainWindowHandle;
            Rect ProcessRect = new Rect();
            GetWindowRect(ptr, ref ProcessRect);
            Rectangle myRect = new Rectangle();
            myRect.X = ProcessRect.Left;
            myRect.Y = ProcessRect.Top;
            myRect.Width = ProcessRect.Right - ProcessRect.Left + 1;
            myRect.Height = ProcessRect.Bottom - ProcessRect.Top + 1;
            return (myRect);
        }
    }
}
