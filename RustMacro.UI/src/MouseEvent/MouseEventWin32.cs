using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RustMacro.UI.src.MouseEvent
{
    public class MouseEventWin32
    {
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        //Sol Tıkladı
        //mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
        ////Sol Bıraktı
        //mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
    }
}
