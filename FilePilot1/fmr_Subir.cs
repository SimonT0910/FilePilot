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

        }

        private void btn_Mis_documentos_Click(object sender, EventArgs e)
        {
            misdocumentos docu = new misdocumentos();
            docu.Show();
            this.Hide();
        }
    }
}
