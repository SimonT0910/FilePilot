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
    public partial class FtmRgsAdm : Form
    {
        private Forms resizer;
        public FtmRgsAdm()
        {
            InitializeComponent();
            resizer = new Forms(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FtmRgsAdm_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAdm.Text;
            string correo = txtCorreoElectronico.Text;
            string contrasena = txtContrasena.Text;
            string verificar = txtverificar.Text;

            ClsTablas.usuarios nuevoadm = new ClsTablas.usuarios();
            string registrar = nuevoadm.registroAdministrado(nombre, correo, contrasena, verificar);
            MessageBox.Show(registrar);


            this.Hide();
        }
    }
}
