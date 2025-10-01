using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FilePilot1.ClsTablas;

namespace FilePilot1
{
    public partial class misdocumentos : Form
    {
        private Forms resizer;
        cConexion conexion;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

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
        }

        public static int total_documentos {  get; set; }

        private void dgvMisDocumentos_MouseClick(object sender, MouseEventArgs e)
        {
            cmd = new SqlCommand("SELECT descripcion FROM Documento WHERE idDocumento = @idDocumento");

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
