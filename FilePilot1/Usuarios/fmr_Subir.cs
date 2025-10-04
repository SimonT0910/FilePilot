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
    public partial class fmr_subir : System.Windows.Forms.Form
    {

        private Forms resizer;

        public fmr_subir()
        {
            InitializeComponent();
            resizer = new Forms(this);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tlp_subir_docu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog1 = new OpenFileDialog();
           openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_ruta.Text = openFileDialog1.FileName;
            }
        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi();
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            FilePilot1.Forms.FormUtils.LimpiarCampos(this);
        }

        private void fmr_subir_Load(object sender, EventArgs e)
        {
            ClsTablas.categorias cargar = new ClsTablas.categorias();
            cargar.CargarCategorias(cmb_categoria);
        }

        private void btn_Mis_documentos_Click(object sender, EventArgs e)
        {
            misdocumentos docu = new misdocumentos();
            docu.Show();
            this.Hide();
        }

        private void btn_subir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ruta.Text))
            {
                MessageBox.Show("Debes seleccionar un archivo antes de subir. ", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("Debes ingresar un nombre para el documento.", "Nombre requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txt_nombre.Text.Trim();
            string tipo = System.IO.Path.GetExtension(txt_ruta.Text).TrimStart('.');
            string categoria = cmb_categoria.Text;
            string ruta = txt_ruta.Text;
            int idUsuario = int.Parse(fmr_PantallaInicio.UsuarioActual);

            ClsTablas.Documento documento = new ClsTablas.Documento();
            string subir = documento.subirDocumento(nombre, tipo, categoria, ruta, idUsuario);
            MessageBox.Show(subir);

            FilePilot1.Forms.FormUtils.LimpiarCampos(this);

            ClsTablas.Movimientos mov = new ClsTablas.Movimientos();
            mov.registrar(int.Parse(fmr_PantallaInicio.UsuarioActual), "Subida de Documento");
        }

        private void txt_ruta_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_categoria.Items.Count <= 0) 
            {
                MessageBox.Show("Debes crear categorias primero");
            }

            btn_subir.Enabled = (cmb_categoria.SelectedIndex >= 0);
        }   

        

        private void pnl_botones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
