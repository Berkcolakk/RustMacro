using RustMacro.UI.src.App;
using RustMacro.UI.src.MouseEvent;
using RustMacro.UI.src.Weapons;
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
        KeyHandler ghk;
        public Main()
        {
            InitializeComponent();
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Red;
            MouseEventWin32.GetCursorPos(out Point lpPoint);
            MouseEventWin32.SetCursorPos(lpPoint.X+10, lpPoint.Y-10);
            comboBox1.Items.Insert(Weapons.NONE, Weapons.NONE_NAME);
            comboBox1.Items.Insert(Weapons.ASSAULT_RIFLE, Weapons.ASSAULT_RIFLE_NAME);
            comboBox1.Items.Insert(Weapons.SEMI_AUTO_RIFLE, Weapons.SEMI_AUTO_RIFLE_NAME);
            comboBox1.Items.Insert(Weapons.THOMPSON, Weapons.THOMPSON_NAME);
            comboBox1.Items.Insert(Weapons.LR_300_ASSAULT_RIFLE, Weapons.LR_300_ASSAULT_RIFLE_NAME);
            comboBox1.Items.Insert(Weapons.M_249, Weapons.M_249_NAME);
            comboBox1.Items.Insert(Weapons.M92_PISTOL, Weapons.M92_PISTOL_NAME);
            comboBox1.Items.Insert(Weapons.MP5A4, Weapons.MP5A4_NAME);
            comboBox1.Items.Insert(Weapons.SEMI_AUTO_PISTOL, Weapons.SEMI_AUTO_PISTOL_NAME);
            comboBox1.Items.Insert(Weapons.CUSTOM_SMG, Weapons.CUSTOM_SMG_NAME);
            comboBox1.Items.Insert(Weapons.REVOLVER, Weapons.REVOLVER_NAME);
            comboBox1.Items.Insert(Weapons.PYTHON_REVOLVER, Weapons.PYTHON_REVOLVER_NAME);
            comboBox1.SelectedIndex = 0;
            ghk = new KeyHandler(Keys.F12, this);
            ghk.Register();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Weapons.SELECTED_WEAPON = comboBox1.SelectedIndex;
            Weapons.SELECTED_WEAPON_NAME = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationStartProccess();
        }
        private void HandleHotkey()
        {
            ApplicationStartProccess();
        }
        public void ApplicationStartProccess()
        {
            if (AppStruct.APP_ONLINE == 1)
            {
                AppStruct.APP_ONLINE = 0;
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.Red;
            }
            else
            {
                AppStruct.APP_ONLINE = 1;
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.Green;
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == 1)
                HandleHotkey();
            base.WndProc(ref m);
        }
    }
}
