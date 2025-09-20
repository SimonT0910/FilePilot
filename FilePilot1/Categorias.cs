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
        private int usuarioId;
        private string rutaBaseCategorias;


        public Categorias()
        {
            InitializeComponent();
            resizer = new Forms(this);
            usuarioId = int.Parse(fmr_PantallaInicio.UsuarioActual);

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
            CargarCategorias();
        }

        private void AgregarCategoria(string nombre)
        {
            try
            {
                cConexion conexion = new cConexion(); // Usamos tu clase personalizada

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Categoria (nombre, idUsuario) VALUES (@nombre, @idUsuario)",
                    conexion.AbrirConexion()); // Abrimos la conexión desde tu clase

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@idUsuario", usuarioId);

                

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Categoría agregada");
                    AgregarCategoriaVisual(nombre); // Agregar también en la vista
                }

                conexion.CerrarConexion(); // Cerramos la conexión

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            pb.Click += (sender, e) => abrirCategoria(nombre);

            Label lbl = new Label();
            lbl.Text = nombre;
            lbl.TextAlign = ContentAlignment.TopCenter;
            lbl.Width = contenedor.Width - 10;
            lbl.Location = new Point(5, pb.Bottom + 5);
            lbl.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            lbl.MaximumSize = new Size(contenedor.Width - 10, 0);
            lbl.AutoSize = true;
            lbl.Click += (sender, e) => abrirCategoria(nombre);

            contenedor.Controls.Add(pb);
            contenedor.Controls.Add(lbl);
            contenedor.Tag = nombre;

            flpCategorias.Controls.Add(contenedor);
        }

        private void abrirCategoria(string nombre)
        {
            categoriaSeparada formCategoria = new categoriaSeparada();
            formCategoria.CategoriaSeleccionada = nombre;
            formCategoria.Show();
            this.Hide();
        }

        private void EliminarCategoria(string nombre)
        {
            try
            {
                cConexion conexion = new cConexion(); // Usamos tu clase personalizada

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Categoria WHERE nombre = @nombre AND idUsuario = @idUsuario",
                    conexion.AbrirConexion()); // Abrimos la conexión desde tu clase

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@idUsuario", usuarioId);

                int result = cmd.ExecuteNonQuery();

                conexion.CerrarConexion(); // Cerramos la conexión

                if (result == 0)
                {
                    MessageBox.Show("No se encontró la categoría a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Eliminar carpeta física
                string rutaCarpeta = Path.Combine(rutaBaseCategorias, nombre);
                if (Directory.Exists(rutaCarpeta))
                    Directory.Delete(rutaCarpeta, true);

                // ✅ Eliminar control visual
                Control eliminar = null;
                foreach (Control c in flpCategorias.Controls)
                {
                    if (c.Tag != null && c.Tag.ToString() == nombre)
                    {
                        eliminar = c;
                        break;
                    }
                }

                if (eliminar != null)
                {
                    flpCategorias.Controls.Remove(eliminar);
                    eliminar.Dispose();
                    MessageBox.Show("Categoría eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                flpCategorias.Controls.Clear();

                cConexion conexion = new cConexion(); // Usamos tu clase personalizada

                SqlCommand cmd = new SqlCommand(
                    "SELECT nombre FROM Categoria WHERE idUsuario = @idUsuario ORDER BY nombre",
                    conexion.AbrirConexion()); // Abrimos la conexión desde tu clase

                cmd.Parameters.AddWithValue("@idUsuario", usuarioId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();
                    AgregarCategoriaVisual(nombre); // Tu método visual personalizado
                }

                reader.Close(); //  Cerramos el lector
                conexion.CerrarConexion(); // Cerramos la conexión
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Inclusion(ComboBox comboBox, int idUsuario)
        {
            try
            {
                comboBox.Items.Clear();

                cConexion conexion = new cConexion(); // Usamos tu clase personalizada

                SqlCommand cmd = new SqlCommand(
                    "SELECT nombre FROM Categoria WHERE idUsuario = @idUsuario ORDER BY nombre",
                    conexion.AbrirConexion()); // Abrimos la conexión desde tu clase

                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader["nombre"].ToString());
                }

                reader.Close(); // Cerramos el lector
                conexion.CerrarConexion(); // Cerramos la conexión

                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;
                else
                {
                    comboBox.Items.Add("Sin categorías");
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (!string.IsNullOrEmpty(nombre))
            {
                EliminarCategoria(nombre);
            }
        }


    }
}
