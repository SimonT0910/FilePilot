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
    public partial class registroUsuario : Form
    {
        private Forms resizer;

        public registroUsuario()
        {
            InitializeComponent();
            resizer = new Forms(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fmr_PantallaInicio regreso = new fmr_PantallaInicio();
            regreso.Show();
            this.Hide();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text;
            string correo = txtCorreoElectronico.Text;
            string contrasena = txtContrasena.Text;

            ClsTablas.Usuario nuevoUsuario = new ClsTablas.Usuario();
            string registrar = nuevoUsuario.registroUsuario(nombre, correo, contrasena);
            MessageBox.Show(registrar);




            fmr_PantallaInicio pantallaInicio = new fmr_PantallaInicio();
            pantallaInicio.Show();
            this.Hide();
        }
    }
}
