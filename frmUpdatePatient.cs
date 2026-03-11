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
    public partial class frmUpdatePatient : MetroForm
    {
        public frmUpdatePatient()
        {
            InitializeComponent();
        }

        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        
        private void frmUpdatePatient_Load(object sender, EventArgs e)
        {
            txtB_name_U.Text = C_Data.name;
            txtB_family_U.Text = C_Data.family;
            txtB_mobil_U.Text = C_Data.mobil;
            TxtB_tell_U.Text = C_Data.tell;
            txtB_address_U.Text= C_Data.addres;
            txtB_comment_U.Text = C_Data.coment;
            txtB_Ncood_U.Text = C_Data.Ncood;
        }

        public FrmReception f;

        private void Btn_update_patient_Click(object sender, EventArgs e)
        {
            var query_update = db.Tbl_patieont.ToList().Find(x => x.ID == C_Data.id);

//            String n = txtB_name_U.Text;
            query_update.name = txtB_name_U.Text;
            query_update.family = txtB_family_U.Text;
            query_update.mobile = txtB_mobil_U.Text;
            query_update.tell = TxtB_tell_U.Text;
            query_update.NationalCode = txtB_Ncood_U.Text;
            query_update.address = txtB_address_U.Text;
            query_update.comment = txtB_comment_U.Text;

            db.SaveChanges();

            f.refresh_Tbl_Patient();

            this.Close();

        }
    }
}
