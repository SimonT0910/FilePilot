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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            movimientos mov = new movimientos();
            mov.Show();
            this.Hide();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            respaldoGeneral resp = new respaldoGeneral();
            resp.Show();
            this.Hide();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            restaurar rest = new restaurar();
            rest.Show();
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
