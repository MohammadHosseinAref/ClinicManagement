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
    public partial class Frm_About : MetroForm
    {
        public Frm_About()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_Site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mohammadhoseinaref.com/");
        }

        private void Frm_About_Load(object sender, EventArgs e)
        {

        }
    }
}
