using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FilePilot1.ClsTablas;

namespace FilePilot1
{
    // ...

    internal class ClsTablas
    {


        cConexion conexion;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;



        public class Usuario
        {
            cConexion conexion = new cConexion();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            private int idUsuario;
            private string nombre;
            private string correo;
            private string rol;
            private string contrasena;

            public int IdUsuario { get => idUsuario; set => idUsuario = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Correo { get => correo; set => correo = value; }
            public string Rol { get => rol; set => rol = value; }
            public string Contrasena { get => contrasena; set => contrasena = value; }


            // Modifica el método para recibir los datos del usuario como parámetros
            public string registroUsuario(string nombre, string correo, string contrasena)
            {
                try
                {
                    cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE correo = @correo", conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    int count = (int)cmd.ExecuteScalar(); //.ExecuteScalar();  Ejecuta la consulta y obtiene el número de filas que coinciden

                    if (count > 0)
                    {
                        return "Este correo ya esta registrado.";
                    }

                    SqlCommand comando = new SqlCommand("INSERT INTO Usuario (nombre, correo, rol, contraseña) VALUES (@nombre, @correo, @rol, @contraseña)", conexion.AbrirConexion());
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@rol", "General");
                    comando.Parameters.AddWithValue("@contraseña", contrasena);
                    comando.ExecuteNonQuery();
                    return "Usuario registrado correctamente";


                }
                catch (Exception ex)
                {
                    return "Error al registrar usuario: " + ex.Message;
                }


            }

            public string validarUsuario(string idUsurio, string contraseña)
            {


                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE idUsuario = @idUsuario", conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idUsuario", idUsurio);


                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Contraseña = reader["contraseña"].ToString();
                        if (Contraseña == contraseña)
                        {
                            return "Correcto";
                        }
                        else
                        {
                            return "Contraseña incorrecta";
                        }
                    }
                    else
                    {
                        return "Usuario no encontrado";

                    }




                }


            }

        }

        public class Documento
        {

            cConexion conexion = new cConexion();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            private string nombre;
            private string tipo;
            private string categoria;
            private string rutaArchivo;
            private int usuarioPropietario;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Tipo { get => tipo; set => tipo = value; }
            public string Categoria { get => categoria; set => categoria = value; }
            public string RutaArchivo { get => rutaArchivo; set => rutaArchivo = value; }
            public int UsuarioPropietario { get => usuarioPropietario; set => usuarioPropietario = value; }

            public string subirDocumento(string nombre, string tipo, string categoria, string rutaArchivo, int usuarioPropietario)
            {

                try
                {

                    cmd = new SqlCommand("SELECT COUNT(*) FROM Documento WHERE nombre = @nombre AND usuarioPropietario = @usuarioPropietario", conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@usuarioPropietario", usuarioPropietario);
                    int count = (int)cmd.ExecuteScalar(); //.ExecuteScalar();  Ejecuta la consulta y obtiene el número de filas que coinciden

                    if (count > 0)
                    {
                        return "Ya existe un documento con ese nombre.";
                    }
                    else
                    {
                        SqlCommand comando = new SqlCommand("INSERT INTO Documento (nombre, tipo, categoria, rutaArchivo, usuarioPropietario) VALUES (@nombre, @tipo, @categoria, @rutaArchivo, @usuarioPropietario)", conexion.AbrirConexion());
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@Tipo", tipo);
                        comando.Parameters.AddWithValue("@categoria", categoria);
                        comando.Parameters.AddWithValue("@rutaArchivo", rutaArchivo);
                        comando.Parameters.AddWithValue("@usuarioPropietario", usuarioPropietario);
                        comando.ExecuteNonQuery();
                        return ("el archivo fue subido exitosamente");
                    }
                }
                catch (Exception ex)
                {
                    return "Error al subir el archivo: " + ex.Message;
                }


            }

            public void llenarGrid(DataGridView midatagrid, int usuarioPropietario, String texto = "")
            {
                try
                {
                    //Implementacion de busqueda
                    string query = "SELECT nombre, fechasubida, categoria FROM Documento WHERE usuarioPropietario = @usuarioPropietario";

                    if (!string.IsNullOrEmpty(texto))
                    {
                        query += @" AND (nombre LIKE @busqueda OR categoria LIKE @busqueda OR CONVERT(VARCHAR, fechasubida, 103) LIKE @busqueda)";
                    }

                    query += " ORDER BY nombre";

                    cmd = new SqlCommand(query, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@usuarioPropietario", usuarioPropietario);

                    if (!string.IsNullOrEmpty(texto))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", "%" + texto + "%");
                    }

                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    midatagrid.Rows.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el grid: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }

                foreach (DataRow fila in dt.Rows)//recore cada fila del datatable que se lleno con los documentos del usuario
                {
                    int nuevaFila = midatagrid.Rows.Add(); // Agrega una nueva fila vacía y guarda su índice para llenarlo después

                    // Recorrer cada columna del DataGridView
                    for (int i = 0; i < midatagrid.Columns.Count; i++)
                    {

                        string titulo = midatagrid.Columns[i].HeaderText;// Obtener el título de la columna actual

                        if (titulo.Equals("Nombre", StringComparison.OrdinalIgnoreCase))
                            midatagrid.Rows[nuevaFila].Cells[i].Value = fila["nombre"].ToString();//nuevaFila es la fila que se acaba de agregar y i es la columna actual

                        else if (titulo.Equals("Fecha", StringComparison.OrdinalIgnoreCase))
                            midatagrid.Rows[nuevaFila].Cells[i].Value = Convert.ToDateTime(fila["fechaSubida"]).ToShortDateString();//cells[i] es la celda actual en la fila nueva

                        else if (titulo.Equals("Categoria", StringComparison.OrdinalIgnoreCase))
                            midatagrid.Rows[nuevaFila].Cells[i].Value = fila["categoria"].ToString();//fila["categoria"] es el valor de la columna "categoria" en la fila actual del DataTable
                    }
                }
            }

            private DataGridView miDatagrid;//solucionar problema de racargar la pantalla para volvar a actualizar el txt

            public void menu(DataGridView midatagrid, MouseEventArgs e)
            {
                this.miDatagrid = midatagrid;
                
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = midatagrid.HitTest(e.X, e.Y).RowIndex;//obtine las cordenadas de  donde se dio clic y con vase a esas cordenadas obtiene la fila a la que le dio clic
                if (posicion > -1)
                {
                    menu.Items.Add("Abrir").Name = "Abrir" + posicion;
                    menu.Items.Add("Modificar").Name = "Modificar" + posicion;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + posicion;
                }
                menu.Show(midatagrid, new Point(e.X, e.Y));
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuClick);
            }

            private void menuClick(object sender, ToolStripItemClickedEventArgs e)
            {


                string click = e.ClickedItem.Name.ToString();

                if (click.Contains("Abrir"))
                {
                    click = click.Replace("Abrir", "");

                    try
                    {

                        cmd = new SqlCommand("Select rutaArchivo from Documento where nombre = @nombre and usuarioPropietario = @usuarioPropietario", conexion.AbrirConexion());
                        cmd.Parameters.AddWithValue("@nombre", miDatagrid.Rows[int.Parse(click)].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@usuarioPropietario", int.Parse(fmr_PantallaInicio.UsuarioActual));
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string rutaArchivo = reader.GetString(0);
                            abrir(rutaArchivo);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conexion.CerrarConexion();
                    }




                }
                if (click.Contains("Modificar"))
                {
                    click = click.Replace("Modificar", "");
                    try
                    {
                        cmd = new SqlCommand("Select idDocumento from Documento where nombre = @nombre and usuarioPropietario = @usuarioPropietario", conexion.AbrirConexion());
                        cmd.Parameters.AddWithValue("@nombre", miDatagrid.Rows[int.Parse(click)].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@usuarioPropietario", int.Parse(fmr_PantallaInicio.UsuarioActual));
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            reader.Close();
                            frm_Modificar modificar = new frm_Modificar(id, miDatagrid);
                            modificar.Show();


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conexion.CerrarConexion();
                    }

                }
                if (click.Contains("Eliminar"))
                {
                    click = click.Replace("Eliminar", "");

                    try
                    {
                        cmd = new SqlCommand("Select idDocumento from Documento where nombre = @nombre and usuarioPropietario = @usuarioPropietario", conexion.AbrirConexion());
                        cmd.Parameters.AddWithValue("@nombre", miDatagrid.Rows[int.Parse(click)].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@usuarioPropietario", int.Parse(fmr_PantallaInicio.UsuarioActual));
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            reader.Close();

                            if (eliminar(id)) 
                            {
                                Form activeForm = Application.OpenForms["fmr_OrgDeArchi"];
                                if (activeForm != null)
                                {
                                    ((fmr_OrgDeArchi)activeForm).refrescar();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conexion.CerrarConexion();
                    }
                }






            }

            private void abrir(string ruta)
            {
                Process.Start(ruta);
            }

            private bool eliminar(int id)
            {
                SqlCommand comando = new SqlCommand("DELETE FROM Documento WHERE idDocumento = @idDocumento;", conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idDocumento", id);

                try
                {
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        miDatagrid.Rows.Clear();
                        miDatagrid.Refresh();
                        llenarGrid(miDatagrid, int.Parse(fmr_PantallaInicio.UsuarioActual));
                        return true; 
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }


            public static int total {  get; set; }


            public int contador(int usuarioPropietario)
            {
                try
                {
                    cmd = new SqlCommand("SELECT COUNT (*) FROM Documento WHERE usuarioPropietario = @usuarioPropietario", conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@usuarioPropietario", usuarioPropietario);

                    int total = Convert.ToInt32(cmd.ExecuteScalar());
                    return total;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar documentos: " + ex.Message);
                    return 0;
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

            public void llenarCategoria(DataGridView midatagrid, int usuarioPropietario, string categoria)
            {
                try
                {
                    string query = "SELECT nombre, fechaSubida, categoria FROM Documento " + "WHERE usuarioPropietario = @usuarioPropietario " + "AND categoria = @categoria " + "ORDER BY nombre";

                    cmd = new SqlCommand(query, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@usuarioPropietario", usuarioPropietario);
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    midatagrid.Rows.Clear();

                    foreach (DataRow fila in dt.Rows)
                    {
                        int nuevaFila = midatagrid.Rows.Add();

                        for (int i = 0; i < midatagrid.Columns.Count; i++)
                        {
                            string titulo = midatagrid.Columns[i].HeaderText;
                            if (titulo.Equals("Nombre", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nuevaFila].Cells[i].Value = fila["nombre"].ToString();
                            else if (titulo.Equals("Fecha", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nuevaFila].Cells[i].Value = Convert.ToDateTime(fila["fechaSubida"]).ToShortDateString();
                            else if (titulo.Equals("Categoria", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nuevaFila].Cells[i].Value = fila["categoria"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el grid por categoría: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }




        }

        public class categorias
        {
            cConexion conexion = new cConexion();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            private string idCategoria;
            private string nombre;
            private string idUsuario;

            public string IdCategoria { get => idCategoria; set => idCategoria = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string IdUsuario { get => idUsuario; set => idUsuario = value; }

            public void CargarCategorias(ComboBox micombo)
            {
                try
                {
                    micombo.Items.Clear();

                    cConexion conexion = new cConexion(); // ✅ Usamos tu clase personalizada

                    SqlCommand cmd = new SqlCommand(
                        "SELECT nombre FROM Categoria WHERE idUsuario = @idUsuario ORDER BY nombre",
                        conexion.AbrirConexion()); // ✅ Abre la conexión usando tu clase

                    cmd.Parameters.AddWithValue("@idUsuario", int.Parse(fmr_PantallaInicio.UsuarioActual)); // ✅ Corregido 'pasrse' y ':'

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        micombo.Items.Add(reader["nombre"].ToString());
                    }

                    reader.Close(); // ✅ Cerramos el lector
                    conexion.CerrarConexion(); // ✅ Cerramos la conexión

                    if (micombo.Items.Count > 0)
                    {
                        micombo.SelectedIndex = 0;
                    }
                    else
                    {
                        micombo.Items.Add("No hay categorías");
                        micombo.SelectedIndex = 0;
                        MessageBox.Show("No tienes categorías creadas. Ve a 'Categorías' para crear algunas.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


    }


}
