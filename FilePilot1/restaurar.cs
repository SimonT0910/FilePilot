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

namespace FilePilot1
{
    public partial class restaurar : System.Windows.Forms.Form
    {
        private Forms resizer;
        public restaurar()
        {
            InitializeComponent();
            resizer = new Forms(this);
        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            frm_Admin admin = new frm_Admin();
            admin.Show();
            this.Hide();
        }

        private void restaurar_Load(object sender, EventArgs e)
        {
            CargarSistema();
            dgvAdminRestaura.AllowUserToAddRows = false;
            dgvAdminRestaura.ReadOnly = false;
            dgvAdminRestaura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarSistema(string textoBusqueda = "")
        {
            try
            {
                ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                DataTable dt = usuario.obtenerRespaldos(textoBusqueda);

                dgvAdminRestaura.Rows.Clear();

                foreach (DataRow fila in dt.Rows)
                {
                    int nueva = dgvAdminRestaura.Rows.Add();
                    dgvAdminRestaura.Rows[nueva].Cells[0].Value = false;
                    dgvAdminRestaura.Rows[nueva].Cells[1].Value = fila["idRespaldo"];
                    dgvAdminRestaura.Rows[nueva].Cells[2].Value = fila["nombreArchivo"].ToString();
                    dgvAdminRestaura.Rows[nueva].Cells[3].Value = fila["categoria"].ToString();
                    dgvAdminRestaura.Rows[nueva].Cells[4].Value = Convert.ToDateTime(fila["fecha"]).ToShortDateString();
                    dgvAdminRestaura.Rows[nueva].Cells[5].Value = fila["usuarioResponsable"].ToString();
                    dgvAdminRestaura.Rows[nueva].Cells[6].Value = fila["tipo"].ToString();
                }

                total_documentos = dgvAdminRestaura.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
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
            List<int> respaldos = new List<int>();

            foreach (DataGridViewRow row in dgvAdminRestaura.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value))
                {
                    int idRespaldo = Convert.ToInt32(row.Cells[1].Value);
                    string nombreArchivo = row.Cells[2].Value.ToString();

                    ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                    string resultado = usuario.restaurar(idRespaldo, int.Parse(fmr_PantallaInicio.UsuarioActual));

                    if (resultado.Contains("exitosamente"))
                    {
                        exitoso++;
                        respaldos.Add(idRespaldo);
                    }
                    else
                    {
                        fallido++;
                        errores.Add($"{nombreArchivo}: {resultado}");
                    }
                }
            }

            string mensaje = $"Documentos restaurados exitosamente: {exitoso}\nDocumentos que fallaron al restaurar: {fallido}";
            if (errores.Count > 0)
            {
                mensaje += "\n\nErrores:\n" + string.Join("\n", errores);
            }

            MessageBox.Show(mensaje, "Restauración Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (respaldos.Count > 0 && MessageBox.Show("¿Desea eliminar los respaldos ya restaurados?", "Eliminar Respaldos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EliminarRespal(respaldos);
            }

            CargarSistema();
        }

        private void EliminarRespal(List<int> idsRespaldos)
        {
            try
            {
                ClsTablas.usuarios usuarioAdmin = new ClsTablas.usuarios();

                foreach (int idRespaldo in idsRespaldos)
                {
                    usuarioAdmin.eliminarRespaldosAdmin(idRespaldo);
                }

                MessageBox.Show("Respaldos eliminados correctamente", "Eliminación Completada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los respaldos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusquedaAdmin_TextChanged(object sender, EventArgs e)
        {
            CargarSistema(txtBusquedaAdmin.Text);
        }

        private void label3_Click(object sender, EventArgs e) 
        { 

        }

        public static int total_documentos { get; set; }

        private void dgvAdminRestaura_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.menu(dgvAdminRestaura, e);
            }
        }

        private void dgvAdminRestaura_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 

        }
    }
}
