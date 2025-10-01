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
using System.Xml.Linq;

namespace FilePilot1
{
    public partial class buscar : System.Windows.Forms.Form
    {
        public buscar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buscar_Load(object sender, EventArgs e)
        {
            ClsTablas.Documento documento = new ClsTablas.Documento();
            documento.llenarGrid(dgvBuscar, int.Parse(fmr_PantallaInicio.UsuarioActual));

            total_documentos = dgvBuscar.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static int total_documentos { get; set; }

        private void dgvbuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.menu(dgvBuscar, e);
            }
        }

        private void dgv_buscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBuscar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ClsTablas.Documento documento = new ClsTablas.Documento();
            documento.llenarGrid(dgvBuscar, int.Parse(fmr_PantallaInicio.UsuarioActual), txt_busqueda.Text);

            total_documentos = dgvBuscar.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
        }
    }
}
