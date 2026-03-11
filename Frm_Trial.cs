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
    public partial class Frm_Trial : Form
    {
        public Frm_Trial()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (TxtB_Code.Text == "1234")
            {
                Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE", "Clinic", TxtB_Code.Text);
                MessageBox.Show("تبریک به نرم افزار کلینیک خوش آمدین شما مبتوانید از این پس از برنامه استفاده کنید");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("کد وارد شده معتبر نمیباشد...");
            }
        }

        private void btn_Exite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TxtB_Code_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Trial_Load(object sender, EventArgs e)
        {

        }
    }
}
