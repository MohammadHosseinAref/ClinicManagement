using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace myClinic
{
    public partial class Frm_choseBackup : MetroForm
    {
        public Frm_choseBackup()
        {
            InitializeComponent();
        }

        private void btn_getBackup_patients_Click(object sender, EventArgs e)
        {   
            Frm_getBackup_patients f = new Frm_getBackup_patients();
            f.Show();
            this.Close();
        }
    }
}
