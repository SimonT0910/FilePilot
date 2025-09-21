using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePilot1
{
    public partial class realizarRespaldos : Form
    {
        private int usuarioId;
        private Forms resizer;
        public realizarRespaldos()
        {
            InitializeComponent();
            resizer = new Forms(this);
            usuarioId = int.Parse(fmr_PantallaInicio.UsuarioActual);

        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            misdocumentos documentos = new misdocumentos();
            documentos.Show();
            this.Hide();
        }

        private void realizarRespaldos_Load(object sender, EventArgs e)
        {
            CargarDocumentos();
            dgvMirarRespaldos.AllowUserToAddRows = false;
        }

        private void CargarDocumentos()
        {
            try
            {
                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.llenarGrid(dgvMirarRespaldos, usuarioId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los documentos: " + ex.Message);
            }
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            int exitoso = 0;
            int fallido = 0;
            List<string> errores = new List<string>();

            foreach (DataGridViewRow row in dgvMirarRespaldos.Rows)
            {
                if (!row.IsNewRow && row.Cells["CheckBoxColumn"].Value != null && Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value))
                {
                    int idDocumento = Convert.ToInt32(row.Cells["idDocumento"].Value);

                    ClsTablas.Respaldo respaldo = new ClsTablas.Respaldo();
                    string resultado = respaldo.CrearRespaldo(idDocumento, usuarioId);

                    if (resultado.Contains("correctamente"))
                        exitoso++;
                    else
                    {
                        fallido++;
                        errores.Add($"{row.Cells["Nombre"].Value}: {resultado}");
                    }
                }
            }

            string mensaje = $"Respaldos exitosos: {exitoso}\nFallidos: {fallido}";
            if (errores.Count > 0)
                mensaje += "\n\nErrores:\n" + string.Join("\n", errores);

            MessageBox.Show(mensaje);
            CargarDocumentos();
        }

        private void btnRespaldarTodo_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvMirarRespaldos.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["CheckBoxColumn"].Value = true;
            }

            btnRespaldar_Click(sender, e);
        }

        private void dvgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
