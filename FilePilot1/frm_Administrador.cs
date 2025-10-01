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
    public partial class frm_Administrador : Form
    {
        public frm_Administrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = Txt_nombre.Text;
            string contrasena = txt_contraseña.Text;
            ClsTablas.usuarios admin = new ClsTablas.usuarios();
            bool esValido = admin.ValidarAdministrador(usuario, contrasena);
            if (esValido)
            {
                MessageBox.Show("Acceso concedido. Bienvenido, Administrador.");
                // Aquí puedes abrir el formulario principal de la aplicación o realizar otras acciones necesarias.
                frm_Admin a = new frm_Admin();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.");
            }
        }
    }
}
