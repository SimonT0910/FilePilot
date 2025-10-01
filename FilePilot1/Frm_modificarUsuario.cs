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
    public partial class Frm_modificarUsuario : Form
    {
        cConexion conexion;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private DataGridView miDataGrid;
        private int id;
        public Frm_modificarUsuario(int id, DataGridView midataGrid)
        {
            cConexion conexion = new cConexion();
            this.miDataGrid = midataGrid;
            this.id = id;
            SqlCommand cmd = new SqlCommand("SELECT nombre, correo, contraseña FROM Usuario WHERE idUsuario = @id", conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@id", id);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);


            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;// para que el formulario se abra en el centro de la pantalla
        }

        private void Frm_modificarUsuario_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = dt.Rows[0]["nombre"].ToString();
            txtCorreo.Text = dt.Rows[0]["correo"].ToString();
            txtContraseña.Text = dt.Rows[0]["contraseña"].ToString();
        }

        private void btn_confimar_Click(object sender, EventArgs e)
        {
            cConexion conexion = new cConexion();

            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || (txt_nombre.Text.Equals(dt.Rows[0]["nombre"].ToString()) && txtCorreo.Text.Equals(dt.Rows[0]["correo"].ToString()) && txtContraseña.Text.Equals(dt.Rows[0]["contraseña"].ToString())))
            {
                MessageBox.Show(dt.Rows[0]["nombre"].ToString());
                MessageBox.Show("Por favor, verifique bien todos los campos.");
                return;
            }
            else if (txt_nombre.Text != (dt.Rows[0]["nombre"].ToString()))
            {
                cmd = new SqlCommand("UPDATE Usuario SET nombre = @nombre, fechaRegistro = @fecha WHERE idUsuario = @id", conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", id);
                int filasAfectadas = cmd.ExecuteNonQuery();//no devuelve nada, solo ejecuta la consulta y da el numero de filas afectadas
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario modificado exitosamente.");

                    this.Hide();
                    miDataGrid.Rows.Clear();
                    miDataGrid.Refresh();
                    ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                    usuario.verUsuarios(miDataGrid);


                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario. Inténtalo de nuevo.");
                }
            }
            else if (txtCorreo.Text != (dt.Rows[0]["correo"].ToString()))
            {
                cmd = new SqlCommand("UPDATE Usuario SET correo = @correo, fechaRegistro = @fecha WHERE idUsuario = @id", conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", id);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario modificado exitosamente.");

                    this.Hide();
                    miDataGrid.Rows.Clear();
                    miDataGrid.Refresh();
                    ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                    usuario.verUsuarios(miDataGrid);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario. Inténtalo de nuevo.");
                }
            }

            else if (txtContraseña.Text != (dt.Rows[0]["contraseña"].ToString()))
            {
                cmd = new SqlCommand("UPDATE Usuario SET contraseña = @contraseña, fechaRegistro = @fecha WHERE idUsuario = @id", conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", id);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario modificado exitosamente.");
                    this.Hide();
                    miDataGrid.Rows.Clear();
                    miDataGrid.Refresh();
                    ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                    usuario.verUsuarios(miDataGrid);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario. Inténtalo de nuevo.");
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Usuario SET nombre = @nombre, correo = @correo, contraseña = @contra, fechaRegistro = @fecha WHERE idUsuario = @id", conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@contra", txtContraseña.Text);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", id);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario modificado exitosamente.");

                        this.Hide();
                        miDataGrid.Rows.Clear();
                        miDataGrid.Refresh();
                        ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                        usuario.verUsuarios(miDataGrid);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el usuario. Inténtalo de nuevo.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el usuario: " + ex.Message);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
