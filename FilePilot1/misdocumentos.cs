using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePilot1
{
    public partial class misdocumentos : Form
    {
        private Forms resizer;

        public misdocumentos()
        {
            InitializeComponent();
            resizer = new Forms(this);

        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi();
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void btnSubirDocumentos_Click(object sender, EventArgs e)
        {
            fmr_subir subir = new fmr_subir();
            subir.Show();
            this.Hide();
        }

        private void dgv_recientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
