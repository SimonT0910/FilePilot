using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FilePilot1
{
    public partial class fmr_PantallaInicio : System.Windows.Forms.Form
    {
        private Forms formsHelper;

        public fmr_PantallaInicio()
        {
            
            InitializeComponent();
            formsHelper = new Forms(this); 

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; 
                return cp;
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            ClsTablas.Usuario validar = new ClsTablas.Usuario();
            string usuario = txt_usuario.Text;
            string contrasena = txt_contra.Text;

            string validarUsuario = validar.validarUsuario(usuario, contrasena);

            if (validarUsuario.Equals("Correcto"))
            {
                int usuarioId = obtenerId(usuario);

                // ✅ VALIDAR QUE EL ID SEA VÁLIDO (mayor a 0)
                if (usuarioId <= 0)
                {
                    MessageBox.Show("No se pudo obtener el ID del usuario. Contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener el proceso
                }

                MessageBox.Show($"🎉 Login exitoso! ID: {usuarioId}", "Bienvenido");
                fmr_OrgDeArchi fmrOrg = new fmr_OrgDeArchi(usuarioId);
                fmrOrg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validarUsuario, "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int obtenerId(string usuarioInput)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("server=DESKTOP-D6A13IA;Initial Catalog=FilePilot;Integrated Security=True"))
                {
                    conexion.Open();

                    // ✅ INTENTAR PRIMERO BUSCAR POR ID (si el input es numérico)
                    if (int.TryParse(usuarioInput, out int posibleId))
                    {
                        string query = "SELECT idUsuario FROM Usuario WHERE idUsuario = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", posibleId);
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                return Convert.ToInt32(result);
                            }
                        }
                    }

                    // ✅ SI NO ENCUENTRA POR ID, BUSCAR POR NOMBRE
                    string queryNombre = "SELECT idUsuario FROM Usuario WHERE nombre = @usuario";
                    using (SqlCommand cmd = new SqlCommand(queryNombre, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuarioInput);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }

                    MessageBox.Show($"❌ Usuario '{usuarioInput}' no existe", "Error");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
                return -1;
            }
        }


        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            registroUsuario registro = new registroUsuario();
            registro.Show();
            this.Hide();
        }

        private void fmr_PantallaInicio_Load(object sender, EventArgs e)
        {

        }
    }

}
