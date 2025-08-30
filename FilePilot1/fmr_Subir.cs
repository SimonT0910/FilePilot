using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FilePilot1
{
    public partial class fmr_subir : System.Windows.Forms.Form
    {

        private Forms resizer;
        private int usuarioId;

        public fmr_subir(int idUsuario)
        {
            InitializeComponent();
            resizer = new Forms(this);
            usuarioId = idUsuario;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tlp_subir_docu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_ruta.Text = openFileDialog1.FileName;
            }
        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi(usuarioId);
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            FilePilot1.Forms.FormUtils.LimpiarCampos(this);
        }

        private void fmr_subir_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btn_Mis_documentos_Click(object sender, EventArgs e)
        {
            misdocumentos docu = new misdocumentos(usuarioId);
            docu.Show();
            this.Hide();
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_categoria.SelectedItem.ToString() == "No hay categorias")
            {
                MessageBox.Show("Debes crear categorias primero");
            }

            btn_subir.Enabled = (cmb_categoria.SelectedIndex >= 0);
        }

        private void CargarCategorias()
        {
            try
            {
                cmb_categoria.Items.Clear();

                string connectionString = "server=DESKTOP-D6A13IA;Initial Catalog=FilePilot;Integrated Security=True";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT nombre FROM Categoria WHERE idUsuario = @idUsuario ORDER BY nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", usuarioId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmb_categoria.Items.Add(reader["nombre"].ToString());
                            }
                        }
                    }
                }

                if (cmb_categoria.Items.Count > 0)
                {
                    cmb_categoria.SelectedIndex = 0;
                }
                else
                {
                    cmb_categoria.Items.Add("No hay categorias");
                    cmb_categoria.SelectedIndex = 0;
                    MessageBox.Show("No tienes categorias creadas. Ve a 'Categorias' para crear algunas.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
