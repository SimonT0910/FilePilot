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
            //Limitar la longitud del nombre visible
            string nombreV = nombre.Length > 15 ? nombre.Substring(0, 12) + "...": nombre;

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
            lbl.Text = nombreV;
            lbl.Width = contenedor.Width - 10;
            lbl.Height = 35;
            lbl.Location = new Point(5, pb.Bottom + 5);
            lbl.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoEllipsis = true;
            lbl.Click += (sender, e) => abrirCategoria(nombre);

            ToolTip tool = new ToolTip(); //Mostar nombre completo al dejar el mouse encima
            tool.SetToolTip(lbl, nombre);
            tool.SetToolTip(pb, nombre);

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
                if (categoriaLlena(nombre))
                {
                    int cantidad = obtenerDocu(nombre);
                    MessageBox.Show($"No se puede eliminar la categoria '{nombre}'\n\n" + $"Esta categoria tiene {cantidad} documento(s) asociado(s).\n\n" + "Debe eliminar primero los documentos antes de eliminar la categoria.", "No se puede eliminar la categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cConexion conexion = new cConexion();
                SqlCommand cmd = new SqlCommand("DELETE FROM Categoria WHERE nombre = @nombre AND idUsuario = @idUsuario",
                    conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@idUsuario", usuarioId);

                int resultado = cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                if(resultado == 0)
                {
                    MessageBox.Show("No se encontro la categoria a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Eliminar la carpeta fisica
                string rutaCarpeta = Path.Combine(rutaBaseCategorias, nombre);
                if (Directory.Exists(rutaCarpeta))
                    Directory.Delete(rutaCarpeta, true);

                //Eliminar control visual
                Control eliminar = null;
                foreach(Control c in flpCategorias.Controls)
                {
                    if(c.Tag != null && c.Tag.ToString() == nombre)
                    {
                        eliminar = c;
                        break;
                    }
                }

                if(eliminar != null)
                {
                    flpCategorias.Controls.Remove(eliminar);
                    eliminar.Dispose();
                    MessageBox.Show("Categoria eliminada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al eliminar categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool categoriaLlena(string nombre)
        {
            try
            {
                cConexion conexion = new cConexion();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM documento WHERE categoria = @categoria AND usuarioPropietario = @usuario", conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@categoria", nombre);
                cmd.Parameters.AddWithValue("@usuario", usuarioId);

                int cantidad = (int)cmd.ExecuteScalar();
                conexion.CerrarConexion();

                return cantidad > 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al verificar documentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private int obtenerDocu(string nombre)
        {
            try
            {
                cConexion conexion = new cConexion();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Documento WHERE categoria = @categoria AND usuarioPropietario = @usuario", conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@categoria", nombre);
                cmd.Parameters.AddWithValue("@usuario", usuarioId);

                int cantidad = (int)cmd.ExecuteScalar();
                conexion.CerrarConexion();

                return cantidad;
            }
            catch (Exception)
            {
                return 0;
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

                ClsTablas.Movimientos mov = new ClsTablas.Movimientos();
                mov.registrar(int.Parse(fmr_PantallaInicio.UsuarioActual), "Creación de Categoría");
            }
        }

        private void btnEliminarCate_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la categoría a eliminar:", "Eliminar Categoría", "");

            if (!string.IsNullOrEmpty(nombre))
            {
                EliminarCategoria(nombre);

                ClsTablas.Movimientos mov = new ClsTablas.Movimientos();
                mov.registrar(int.Parse(fmr_PantallaInicio.UsuarioActual), "Eliminación de Categoría");
            }
        }


    }
}
