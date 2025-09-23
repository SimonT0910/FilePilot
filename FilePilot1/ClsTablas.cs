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
using System.IO;
using System.Security.Cryptography.X509Certificates;

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
                    string query = "SELECT idDocumento, nombre, fechaSubida, Categoria FROM Documento WHERE usuarioPropietario = @usuarioPropietario";

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

                    foreach (DataRow fila in dt.Rows)
                    {
                        int nuevaFila = midatagrid.Rows.Add();

                        for (int i = 0; i < midatagrid.Columns.Count; i++)
                        {
                            string titulo = midatagrid.Columns[i].HeaderText;
                            string nombreColumna = midatagrid.Columns[i].Name;

                            // BUSCAR POR HeaderText O Name
                            if (titulo.Equals("idDocumento", StringComparison.OrdinalIgnoreCase) ||
                                nombreColumna.Equals("idDocumento", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nuevaFila].Cells[i].Value = fila["idDocumento"];

                            else if (titulo.Equals("Nombre", StringComparison.OrdinalIgnoreCase) ||
                                     nombreColumna.Equals("Nombre", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nuevaFila].Cells[i].Value = fila["nombre"].ToString();

                            else if (titulo.Equals("Fecha", StringComparison.OrdinalIgnoreCase) ||
                                     nombreColumna.Equals("Fecha", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nuevaFila].Cells[i].Value = Convert.ToDateTime(fila["fechaSubida"]).ToShortDateString();

                            else if (titulo.Equals("Categoria", StringComparison.OrdinalIgnoreCase) ||
                                     nombreColumna.Equals("Categoria", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nuevaFila].Cells[i].Value = fila["categoria"].ToString();

                            else if ((titulo.Equals("Seleccion", StringComparison.OrdinalIgnoreCase) ||
                                     nombreColumna.Equals("Seleccion", StringComparison.OrdinalIgnoreCase)) &&
                                     midatagrid.Columns[i] is DataGridViewCheckBoxColumn)
                                midatagrid.Rows[nuevaFila].Cells[i].Value = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el grid: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

            public void sinRespaldos(DataGridView midatagrid, int usuarioPropietario)
            {
                try
                {
                    string query = @"SELECT d.idDocumento, d.nombre, d.fechaSubida, d.categoria FROM Documento d LEFT JOIN Respaldo r ON d.idDocumento = r.idDocumentoOriginal WHERE d.usuarioPropietario = @usuarioPropietario AND r.idRespaldo IS NULL ORDER BY d.nombre";

                    cmd = new SqlCommand(query, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@usuarioPropietario", usuarioPropietario);

                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    midatagrid.Rows.Clear();

                    foreach(DataRow fila in dt.Rows)
                    {
                        int nueva = midatagrid.Rows.Add();

                        for (int i = 0; i < midatagrid.Columns.Count; i++)
                        {
                            string titulo = midatagrid.Columns[i].HeaderText;
                            string nombreColumna = midatagrid.Columns[i].Name;

                            //Asignar valores a las columnas que existan
                            if ((titulo.Equals("idDocumento", StringComparison.OrdinalIgnoreCase) || nombreColumna.Equals("idDocumento", StringComparison.OrdinalIgnoreCase)))
                                midatagrid.Rows[nueva].Cells[i].Value = fila["idDocumento"];

                            else if (titulo.Equals("Nombre", StringComparison.OrdinalIgnoreCase) || nombreColumna.Equals("idDocumento", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nueva].Cells[i].Value = fila["nombre"].ToString();

                            else if (titulo.Equals("Fecha", StringComparison.OrdinalIgnoreCase) || nombreColumna.Equals("Fecha", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nueva].Cells[i].Value = Convert.ToDateTime(fila["fechaSubida"]).ToShortDateString();

                            else if (titulo.Equals("Categoria", StringComparison.OrdinalIgnoreCase) || nombreColumna.Equals("Categoria", StringComparison.OrdinalIgnoreCase))
                                midatagrid.Rows[nueva].Cells[i].Value = fila["categoria"].ToString();

                            else if ((titulo.Equals("Seleccion", StringComparison.OrdinalIgnoreCase) || nombreColumna.Equals("Seleccion", StringComparison.OrdinalIgnoreCase)) && midatagrid.Columns[i] is DataGridViewCheckBoxColumn)
                                midatagrid.Rows[nueva].Cells[i].Value = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el grid de eliminación: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
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
                try
                {
                    //eliminar el documento
                    SqlCommand comando = new SqlCommand("DELETE FROM Documento WHERE idDocumento = @idDocumento", conexion.AbrirConexion());
                    comando.Parameters.AddWithValue("@idDocumento", id);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        miDatagrid.Rows.Clear();
                        llenarGrid(miDatagrid, int.Parse(fmr_PantallaInicio.UsuarioActual));
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar documento: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.CerrarConexion();
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

        public class Respaldo
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

            public string CrearRespaldo(int Documento, int usuario, string tipoRespaldo = "Manual")
            {
                try
                {
                    //Verifica que el documento pertenece al usuario
                    string queryVerificar = @"SELECT COUNT(*) FROM Documento WHERE idDocumento = @Documento AND usuarioPropietario = @usuario";

                    cmd = new SqlCommand(queryVerificar, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@Documento", Documento);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int existe = (int)cmd.ExecuteScalar();
                    if (existe == 0)
                    {
                        return "Error: El documento no existe o  no pertenece al usuario.";
                    }

                    conexion.CerrarConexion();

                    //Obtener informacion del documento
                    string queryInfo = @"SELECT nombre, tipo, categoria, rutaArchivo FROM Documento WHERE idDocumento = @Documento";

                    cmd = new SqlCommand(queryInfo, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@Documento", Documento);

                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0) return "Error: No se pudo leer el documento";

                    string nombreArchivo = dt.Rows[0]["nombre"].ToString();
                    string tipoArchivo = dt.Rows[0]["tipo"].ToString();
                    string categoria = dt.Rows[0]["categoria"].ToString();
                    string rutaArchivo = dt.Rows[0]["rutaArchivo"].ToString();

                    //Leer el contenido del archivo
                    if (!File.Exists(rutaArchivo))
                    {
                        return "Error: El archivo no existe en la ruta especificada";
                    }

                    byte[] contenido = File.ReadAllBytes(rutaArchivo);

                    //Insertar en la tabla Respaldo
                    string queryInsert = @"INSERT INTO Respaldo (fecha, tipo, nombreArchivo, tipoArchivo, contenido, categoria, usuarioResponsable, idDocumentoOriginal) VALUES(GETDATE(), @tipo, @nombreArchivo, @tipoArchivo, @contenido, @categoria, @usuario, @idDocumento)";

                    cmd = new SqlCommand(queryInsert, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@tipo", tipoRespaldo);
                    cmd.Parameters.AddWithValue("@nombreArchivo", nombreArchivo);
                    cmd.Parameters.AddWithValue("@tipoArchivo", tipoArchivo);
                    cmd.Parameters.AddWithValue("@contenido", contenido);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@idDocumento", Documento);
                    cmd.ExecuteNonQuery();

                    return "Respaldo creado exitosamente";
                }
                catch (Exception ex)
                {
                    return "Error al crear el respaldo: " + ex.Message;
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

            public DataTable obtenerRespaldo(int usuario)
            {
                try
                {
                    string query = @"SELECT idRespaldo, nombreArchivo, categoria, fecha, tipo FROM Respaldo WHERE usuarioResponsable = @usuario ORDER BY fecha DESC";

                    cmd = new SqlCommand(query, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los respaldos: " + ex.Message);
                    return new DataTable();
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

            public string restaurarRespaldo(int idRespaldo, int usuario, string nuevaRuta = "")
            {
                try
                {
                    //Verificar que el respaldo pertenece al usuario
                    string queryVeriificar = @"SELECT COUNT(*) FROM Respaldo WHERE  idRespaldo = @idRespaldo AND usuarioResponsable = @usuario";

                    cmd = new SqlCommand(queryVeriificar, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@idRespaldo", idRespaldo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int existe = (int)cmd.ExecuteScalar();
                    if (existe == 0)
                    {
                        return "Error: El respaldo no existe o no pertenece al usuario.";
                    }

                    //Obtener el contenido del respaldo
                    string queryContenido = @"SELECT nombreArchivo, tipoArchivo, contenido FROM Respaldo WHERE idRespaldo = @idRespaldo";

                    cmd = new SqlCommand(queryContenido, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@idRespaldo", idRespaldo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        return "Error: No se pudo leer el respaldo.";
                    }

                    string nombreArchivo = reader["nombreArchivo"].ToString();
                    string tipoArchivo = reader["tipoArchivo"].ToString();
                    byte[] contenido = (byte[])reader["contenido"];

                    reader.Close();

                    //Guardar el archivo en disco
                    string rutaDestino = string.IsNullOrEmpty(nuevaRuta) ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nombreArchivo) : Path.Combine(nuevaRuta, nombreArchivo);

                    File.WriteAllBytes(rutaDestino, contenido);

                    return $"Archivo restaurado correctamento en: {rutaDestino}"; 
                }
                catch (Exception ex)
                {
                    return "Error al restaurar el respaldo: " + ex.Message;
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

            public string restaurarDocumento(int idRespaldo, int usuario)
            {
                try
                {
                    //Verificar que el respaldo pertenece al usuario
                    string queryVerificar = @"SELECT COUNT(*) FROM Respaldo WHERE idRespaldo = @idRespaldo AND usuarioResponsable = @usuario";

                    cmd = new SqlCommand(queryVerificar, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@idRespaldo", idRespaldo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int existe = (int)cmd.ExecuteScalar();
                    if (existe == 0)
                    {
                        return "Error: El respaldo no existe o no pertenece al usuario.";
                    }

                    //Obtener informacion del respaldo 
                    string queryInfo = @"SELECT nombreArchivo, tipoArchivo, contenido, categoria FROM Respaldo WHERE idRespaldo = @idRespaldo";

                    cmd = new SqlCommand(queryInfo, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@idRespaldo", idRespaldo);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        return "Error: No se pudo leer la informacion del respaldo";
                    }

                    string nombreArchivo = reader["nombreArchivo"].ToString();
                    string tipoArchivo = reader["tipoArchivo"].ToString();
                    byte[] contenido = (byte[])reader["contenido"];
                    string categoria = reader["categoria"].ToString();

                    reader.Close();
                    conexion.CerrarConexion();

                    //Guardar el archivo en la carpeta del sistema
                    string carpetaSistema = Path.Combine(Application.StartupPath, "ArchivosSubidos");
                    if (!Directory.Exists(carpetaSistema))
                    {
                        Directory.CreateDirectory(carpetaSistema);
                    }

                    //Generar un nombre unico para el archivo
                    string rutaArchivo = Path.Combine(carpetaSistema, nombreArchivo);
                    int contador = 1;
                    while (File.Exists(rutaArchivo))
                    {
                        string nombre = Path.GetFileNameWithoutExtension(nombreArchivo);
                        string extension = Path.GetExtension(nombreArchivo);
                        rutaArchivo = Path.Combine(carpetaSistema, $"{nombre}({contador}){extension}");
                        contador++;
                    }

                    //Guardar el archivo en disco
                    File.WriteAllBytes(rutaArchivo, contenido);

                    //Insertar en la tabla Documento
                    string queryInsert = @"INSERT INTO Documento (nombre, tipo, categoria, rutaArchivo, usuarioPropietario, fechaSubida) VALUES (@nombre, @tipo, @categoria, @rutaArchivo, @usuarioPropietario, GETDATE())";

                    cmd = new SqlCommand(queryInsert, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@nombre", nombreArchivo);
                    cmd.Parameters.AddWithValue("@tipo", tipoArchivo);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@rutaArchivo", rutaArchivo);
                    cmd.Parameters.AddWithValue("@usuarioPropietario", usuario);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        return "Documento restauradoexitosamente al sistema";
                    }
                    else
                    {
                        return "Error: No se puso insertar el documento en la base de datos";
                    }
                }
                catch (Exception ex)
                {
                    return "Error al restaurar el documento: " + ex.Message;
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        


    }


}
