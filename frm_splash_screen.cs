using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myClinic
{
    public partial class frm_splash_screen : Form
    {
        public frm_splash_screen()
        {
            InitializeComponent();
        }

        private void frm_splash_screen_Load(object sender, EventArgs e)
        {
            timer_splash_screen.Enabled = true;
            timer_splash_screen.Interval = 300;
            timer_splash_screen.Start();
        }
        private void timer_splash_screen_Tick(object sender, EventArgs e)
        {
            if (progressB_splash_screen.Value < progressB_splash_screen.Maximum)
            {
                progressB_splash_screen.Value += 20;

            }
            else
            {
                this.Hide();
//                FrmMain fLogin = new FrmMain();

                FrmLogin fLogin = new FrmLogin();
                fLogin.Show();
                timer_splash_screen.Stop();
            }
        }


    }
}
