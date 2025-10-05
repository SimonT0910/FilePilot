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

        private void misdocumentos_Load(object sender, EventArgs e)
        {
            ClsTablas.Documento documento = new ClsTablas.Documento();
            documento.llenarGrid(dgvMisDocumentos, int.Parse(fmr_PantallaInicio.UsuarioActual));

            total_documentos = dgvMisDocumentos.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

            dgvMisDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static int total_documentos {  get; set; }

        private void dgvMisDocumentos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.menu(dgvMisDocumentos, e);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar busqueda = new buscar();
            busqueda.Show();
        }

        private void dgvMisDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptb_inicio_Click(object sender, EventArgs e)
        {

        }

        private void btnRealizarRespaldos_Click(object sender, EventArgs e)
        {
            realizarRespaldos respaldos = new realizarRespaldos();
            respaldos.Show();
            this.Hide();
        }
    }
}
