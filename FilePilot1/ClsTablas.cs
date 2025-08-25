using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FilePilot1
{
    // ...

    internal class ClsTablas
    {


        public class Usuario
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP_BRY3;Initial Catalog=FilePilot;Integrated Security=True");

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
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(
                        "INSERT INTO Usuario (nombre, correo, rol, contraseña) VALUES (@nombre, @correo, @rol, @contraseña)",
                        conexion);
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
                finally
                {
                    conexion.Close();
                }

            }

            public string validarUsuario(string idUsurio, string contraseña)
            {


                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE idUsuario = @idUsuario", conexion);
                comando.Parameters.AddWithValue("@idUsuario", idUsurio);

                conexion.Open();
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
    }
}

