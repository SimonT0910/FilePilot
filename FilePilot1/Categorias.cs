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
    public partial class Categorias : Form
    {

        private Forms resizer;
        private string rutaBaseCategorias;
        private int usuarioId;

        public Categorias(int idUsuario)
        {
            InitializeComponent();
            resizer = new Forms(this);
            usuarioId = idUsuario;

            rutaBaseCategorias = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FilePilot", "Categorias", usuarioId.ToString());

            if (!Directory.Exists(rutaBaseCategorias))
                Directory.CreateDirectory(rutaBaseCategorias);
        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi();
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            //CargarCategorias();
        }

        private SqlConnection ObtenerConexion()
        {
            string connectionString = "server=DESKTOP-D6A13IA;Initial Catalog=FilePilot;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        private void AgregarCategoria(String nombre)
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();

                    string query = "INSERT INTO Categoria (nombre, idUsuario) VALUES (@nombre, @idUsuario)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@idUsuario", usuarioId);
                        cmd.ExecuteNonQuery();
                    }
                }

                string rutaCarpeta = Path.Combine(rutaBaseCategorias, nombre);
                if (!Directory.Exists(rutaCarpeta))
                    Directory.CreateDirectory(rutaCarpeta);

                AgregarCategoriaVisual(nombre);

                MessageBox.Show("Categoria agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("Ya tienes una categoría con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AgregarCategoriaVisual(String nombre)
        {

            Panel contenedor = new Panel();
            contenedor.Margin = new Padding(10);
            contenedor.Width = 150;
            contenedor.Height = 150;

            PictureBox pb = new PictureBox();
            pb.Image = Properties.Resources.carpetas;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Width = 100;
            pb.Height = 100;
            pb.Location = new Point((contenedor.Width - pb.Width) / 2, 10);
            pb.Cursor = Cursors.Hand;

            Label lbl = new Label();
            lbl.Text = nombre;
            lbl.TextAlign = ContentAlignment.TopCenter;
            lbl.Width = contenedor.Width - 10;
            lbl.Location = new Point(5, pb.Bottom + 5);
            lbl.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            lbl.MaximumSize = new Size(contenedor.Width - 10, 0);
            lbl.AutoSize = true;

            contenedor.Controls.Add(pb);
            contenedor.Controls.Add(lbl);
            contenedor.Tag = nombre;

            flowLayoutPanel1.Controls.Add(contenedor);
        }
        

        private void EliminarCategoria(String nombre)
        {
           // try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();

                    string query = "DELETE FROM Categoria WHERE nombre = @nombre AND idUsuario = @idUsuario";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@idUsuario", usuarioId);
                        int result = cmd.ExecuteNonQuery();

                        if (result == 0)
                        {
                           // MessageBox.Show("No se encontro la categoría a eliminar")
                        }
                    }
                }
            }
            Control eliminar = null;

            foreach(Control c in flowLayoutPanel1.Controls)
            {
                if(c.Tag != null && c.Tag.ToString() == nombre)
                {
                    eliminar = c;
                    break;
                }
            }
            if(eliminar != null)
            {
                flowLayoutPanel1.Controls.Remove(eliminar);
                eliminar.Dispose();
            }
            else
            {
                MessageBox.Show("No se encontró la categoría a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCate_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la nueva categoría:", "Nueva Categoría", "Categoria");

            if (!string.IsNullOrEmpty(nombre))
            {
                AgregarCategoria(nombre);
            }
        }

        private void btnEliminarCate_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la categoría a eliminar:", "Eliminar Categoría", "");

            if(!string.IsNullOrEmpty(nombre))
            {
                EliminarCategoria(nombre);
            }
        }
    }
}
