using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static FilePilot1.ClsTablas;

namespace FilePilot1
{
    public partial class fmr_OrgDeArchi : System.Windows.Forms.Form
    {
        private Forms resizer;
        cConexion conexion = new cConexion();
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();


        public fmr_OrgDeArchi()
        {
            InitializeComponent();
            resizer = new Forms(this);
            
            this.Shown += fmr_OrgDeArchi_Shown;



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
            bool hayCategorias = Verificar();

            if (hayCategorias)
            {
                fmr_subir subir = new fmr_subir();
                subir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes categorías creadas. Ve a 'Categorías' para crear algunas.");
                Categorias categorias = new Categorias();
                categorias.Show();
                this.Hide();
            }
        }

        private bool Verificar()
        {
            try
            {
                cConexion conexion = new cConexion();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Categoria WHERE idUsuario = @idUsuario",
                    conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@idUsuario", int.Parse(fmr_PantallaInicio.UsuarioActual));

                int cantidad = (int)cmd.ExecuteScalar();
                conexion.CerrarConexion();

                return cantidad > 0; 
            }
            catch (Exception)
            {
                return false; 
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mis_documentos_Click(object sender, EventArgs e)
        {
            misdocumentos docu = new misdocumentos();
            docu.Show();
            this.Hide();
        }

        private void Btn_categorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        //este metodo se activa cuando se muestra el formulario
        private void fmr_OrgDeArchi_Shown(object sender, EventArgs e)
        {


            if (this.Visible)
            {
                refrescar();
            }

        }

        public void refrescar()
        {
            ClsTablas.Documento documento = new ClsTablas.Documento();
            documento.llenarGrid(dgv_recientes, int.Parse(fmr_PantallaInicio.UsuarioActual));
            int total = documento.contador(int.Parse(fmr_PantallaInicio.UsuarioActual));
            txt_total.Text = total.ToString();

        }


        private void dgv_recientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.menu(dgv_recientes,e);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmr_OrgDeArchi_Load(object sender, EventArgs e)
        {
            ClsTablas.Documento docu = new ClsTablas.Documento();
            int total = docu.contador(int.Parse(fmr_PantallaInicio.UsuarioActual));
            txt_total.Text = total.ToString();
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mirar_respaldos_Click(object sender, EventArgs e)
        {
            respaldos resp = new respaldos();
            resp.Show();
            this.Hide();
        }

        private void dgv_recientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
