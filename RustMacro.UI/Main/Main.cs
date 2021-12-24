using RustMacro.UI.src.MouseEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustMacro.UI.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            MouseEventWin32.GetCursorPos(out Point lpPoint);
            MouseEventWin32.SetCursorPos(lpPoint.X+10, lpPoint.Y-10);
        }
    }
}
