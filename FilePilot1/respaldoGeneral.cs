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
    public partial class respaldoGeneral : Form
    {
        private Forms resizer;
        public respaldoGeneral()
        {
            InitializeComponent();
            resizer = new Forms(this);
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            frm_Admin admin = new frm_Admin();
            admin.Show();
            this.Hide();
        }

        private void respaldoGeneral_Load(object sender, EventArgs e)
        {
            CargarDocumentosAdmin();
            dgvRespaldoGeneral.AllowUserToAddRows = false;
            dgvRespaldoGeneral.ReadOnly = false;
        }

        private void CargarDocumentosAdmin()
        {
            try
            {
                ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                usuario.sinRespaldosAdmin(dgvRespaldoGeneral);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los documentos: " + ex.Message);
            }
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(fmr_PantallaInicio.UsuarioActual))
                {
                    MessageBox.Show("Error: No hay usuario autenticado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(fmr_PantallaInicio.UsuarioActual, out int idAdmin))
                {
                    MessageBox.Show("Error: ID de usuario inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea respaldar TODOS los documentos de todos los usuarios?",
                    "Confirmar Respaldo Masivo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    btnRespaldar.Enabled = false;
                    btnRespaldar.Text = "Respaldando...";
                    Application.DoEvents();

                    ClsTablas.usuarios usuarioAdmin = new ClsTablas.usuarios();
                    string resultado = usuarioAdmin.respaldarTodo(idAdmin);

                    MessageBox.Show(resultado, "Resultado del Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDocumentosAdmin();

                    btnRespaldar.Enabled = true;
                    btnRespaldar.Text = "Respaldado Todo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRespaldar.Enabled = true;
                btnRespaldar.Text = "Respaldar Todo";
            }
        }
    }
}