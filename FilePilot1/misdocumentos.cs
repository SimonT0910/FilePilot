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
        private int usuarioId;

        public misdocumentos(int idUsuario)
        {
            InitializeComponent();
            resizer = new Forms(this);
            usuarioId = idUsuario;

        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi(usuarioId);
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void btnSubirDocumentos_Click(object sender, EventArgs e)
        {
            fmr_subir subir = new fmr_subir(usuarioId);
            subir.Show();
            this.Hide();
        }

        private void dgv_recientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
