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
    public partial class FrmUpdateSection : MetroForm
    {
        public FrmUpdateSection()
        {
            InitializeComponent();
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        private void FrmUpdateSection_Load(object sender, EventArgs e)
        {
            txtB_name_U.Text = C_Data.name;
        }
        public FrmSetting f;
        private void Btn_update_sec_Click(object sender, EventArgs e)
        {
            var query_update = db.Tbl_section.ToList().Find(x => x.ID == C_Data.id);

            //            String n = txtB_name_U.Text;
            query_update.sectionType = txtB_name_U.Text;

            db.SaveChanges();

            f.showData_Grid_sec();

            this.Close();
        }
    }
}
