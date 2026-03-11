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
    public partial class Frm_Registery : Form
    {
        public Frm_Registery()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (TxtB_Code.Text == "1234")
            {
                Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE", "Clinic", TxtB_Code.Text);
                MessageBox.Show("congratuation");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("no......");
            }
        }
    }
}
