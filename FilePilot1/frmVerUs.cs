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
    public partial class frmVerUs : Form
    {
        private Forms resizer;
        public frmVerUs()
        {
            InitializeComponent();
            resizer = new Forms(this);

            this.Shown += frmVerUs_Shown;
            dgv_usuarios.MouseClick += dgv_usuarios_MouseClick;
            this.MouseClick += frmVerUs_MouseClick;
        }

        private void frmVerUs_Shown(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                usuario.verUsuarios(dgv_usuarios);
            }
        }

        private void frmVerUs_Load(object sender, EventArgs e)
        {

        }

        private void dgv_usuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ClsTablas.usuarios usuario = new ClsTablas.usuarios();
                usuario.menu(dgv_usuarios, e);
            }
        }

        private void frmVerUs_MouseClick(object sender, MouseEventArgs e)
        {
            // Aquí puedes agregar la lógica que desees ejecutar al hacer clic en el formulario.
        }
    }
}
