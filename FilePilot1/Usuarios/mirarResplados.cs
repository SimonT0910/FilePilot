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
    public partial class respaldos : Form
    {
        private Forms resizer;
        private int usuarioId;
        public respaldos()
        {
            InitializeComponent();
            resizer = new Forms(this);
            usuarioId = int.Parse(fmr_PantallaInicio.UsuarioActual);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi();
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void mirarResplados_Load(object sender, EventArgs e)
        {
            CargarRespaldos();
            dgvRestauracion.AllowUserToAddRows = false;
            dgvRestauracion.ReadOnly = false;
        }

        private void CargarRespaldos()
        {
            try
            {
                ClsTablas.Respaldo respaldo = new ClsTablas.Respaldo();
                DataTable dt = respaldo.obtenerRespaldo(usuarioId);

                dgvRestauracion.Rows.Clear();

                //Llenar el DataGridView
                foreach (DataRow fila in dt.Rows)
                {
                    int nueva = dgvRestauracion.Rows.Add();
                    dgvRestauracion.Rows[nueva].Cells[0].Value = false;
                    dgvRestauracion.Rows[nueva].Cells[1].Value = fila["idRespaldo"];
                    dgvRestauracion.Rows[nueva].Cells[2].Value = fila["nombreArchivo"].ToString();
                    dgvRestauracion.Rows[nueva].Cells[3].Value = fila["categoria"].ToString();
                    dgvRestauracion.Rows[nueva].Cells[4].Value = Convert.ToDateTime(fila["fecha"]).ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los documentos: " + ex.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            int exitoso = 0;
            int fallido = 0;
            List<string> errores = new List<string>();
            List<int> restaurados = new List<int>();

            foreach (DataGridViewRow row in dgvRestauracion.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value))
                {
                    int idRespaldo = Convert.ToInt32(row.Cells[1].Value);

                    ClsTablas.Respaldo respaldo = new ClsTablas.Respaldo();
                    string resultado = respaldo.restaurarDocumento(idRespaldo, usuarioId);

                    if (resultado.Contains("exitosamente"))
                    {
                        exitoso++;
                        restaurados.Add(idRespaldo);
                    }
                    else
                    {
                        fallido++;
                        errores.Add($"{row.Cells[2].Value}: {resultado}");
                    }
                }
            }

            string mensaje = $"Documentos restaurados al sistema: {exitoso}\nFallidos: {fallido}";
            if (errores.Count > 0)
                mensaje += "\n\nErrores:\n" + string.Join("\n", errores);

            MessageBox.Show(mensaje);

            if (restaurados.Count > 0)
            {
                eliminarRestaurados(restaurados);
            }
            CargarRespaldos();
            btnRestaurar.Enabled = false;
        }

        private void eliminarRestaurados(List<int> id)
        {
            try
            {
                ClsTablas.Respaldo respaldo = new ClsTablas.Respaldo();

                foreach (int idRespaldo in id)
                {
                    respaldo.eliminarRespaldo(idRespaldo, usuarioId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los documentos restaurados: " + ex.Message);
            }
        }
    }
}
