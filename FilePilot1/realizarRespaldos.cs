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
            dgvMirarRespaldos.ReadOnly = false;
        }

        private void CargarDocumentos()
        {
            try
            {
                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.sinRespaldos(dgvMirarRespaldos, usuarioId);
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
                if (!row.IsNewRow)
                {
                    bool estaSeleccionado = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.OwningColumn is DataGridViewCheckBoxColumn && cell.Value != null)
                        {
                            estaSeleccionado = Convert.ToBoolean(cell.Value);
                            break;
                        }
                    }

                    if (estaSeleccionado)
                    {
                        int? idDocumento = null;
                        string nombreArchivo = "";

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            var cell = row.Cells[i];
                            if (cell.OwningColumn.HeaderText.Equals("idDocumento", StringComparison.OrdinalIgnoreCase) ||
                                cell.OwningColumn.Name == "idDocumento")
                            {
                                if (cell.Value != null)
                                    idDocumento = Convert.ToInt32(cell.Value);
                            }
                            else if (cell.OwningColumn.HeaderText.Equals("Nombre", StringComparison.OrdinalIgnoreCase) ||
                                     cell.OwningColumn.Name == "Nombre")
                            {
                                nombreArchivo = cell.Value?.ToString() ?? "";
                            }
                        }

                        if (idDocumento.HasValue)
                        {
                            ClsTablas.Respaldo respaldo = new ClsTablas.Respaldo();
                            string resultado = respaldo.CrearRespaldo(idDocumento.Value, usuarioId);

                            if (resultado.Contains("exitosamente"))
                                exitoso++;
                            else
                            {
                                fallido++;
                                errores.Add($"{nombreArchivo}: {resultado}");
                            }
                        }
                        else
                        {
                            fallido++;
                            errores.Add("No se pudo obtener el ID del documento");
                        }
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
                    row.Cells["seleccion"].Value = true;
            }

            btnRespaldar_Click(sender, e);
        }

        private void dvgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMirarRespaldos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMirarRespaldos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dgvMirarRespaldos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        
        }
    }
}
