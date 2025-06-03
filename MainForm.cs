using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_PBO_Winform
{
    public partial class MainForm : Form
    {
        UCLogin UCLogin;
        public MainForm()
        {
            InitializeComponent();
            UCLogin = new UCLogin(this);

            this.Controls.Add(UCLogin);
        }

        public void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            userControl.Show();
        }

        public void HideAllUserControls()
        {
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                {
                    control.Hide();
                }
            }
        }
    }
}
