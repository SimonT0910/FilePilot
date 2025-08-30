using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FilePilot1
{
    public partial class fmr_OrgDeArchi : System.Windows.Forms.Form
    {
        private Forms resizer;
        private int usuarioId;

        public fmr_OrgDeArchi(int idUsuario)
        {
            InitializeComponent();
            resizer = new Forms(this);
            usuarioId = idUsuario;

            // ✅ DEBUG: Verificar que recibió el ID
            MessageBox.Show($"FormPrincipal - usuarioId recibido: {usuarioId}", "DEBUG");
        }

        private void button5_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            fmr_PantallaInicio pantallaInicio = new fmr_PantallaInicio();
            pantallaInicio.Show();
            this.Hide();
        }

        private void btn__subir_docum_Click(object sender, EventArgs e)
        {
            fmr_subir subir = new fmr_subir(usuarioId);
            subir.Show();
            this.Hide();
        }

        private void fmr_OrgDeArchi_Load_1(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_recientes_Click(object sender, EventArgs e)
        {

        }

        private void dgv_recientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mis_documentos_Click(object sender, EventArgs e)
        {
            misdocumentos docu = new misdocumentos(usuarioId);
            docu.Show();
            this.Hide();
        }

        private void Btn_categorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias(usuarioId);
            categorias.Show();
            this.Hide();
        }
    }
}