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
        private Forms resizer;
        public frm_Admin()
        {
            InitializeComponent();
            resizer = new Forms(this);
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
        fmr_PantallaInicio inicio = new fmr_PantallaInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            frmVerUs us = new frmVerUs();
            us.Show();
            this.Hide();
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FtmRgsAdm crear = new FtmRgsAdm();
            crear.Show();
            this.Hide();
        }
    }
}
