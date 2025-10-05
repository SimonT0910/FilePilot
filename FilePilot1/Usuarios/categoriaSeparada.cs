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
using System.Xml.Linq;

namespace FilePilot1
{
    public partial class categoriaSeparada : System.Windows.Forms.Form
    {
        private Forms resizer;
        public string CategoriaSeleccionada { get; set; }
        public categoriaSeparada()
        {
            InitializeComponent();
            resizer = new Forms(this);
        }

        private void categoriaSeparada_Load(object sender, EventArgs e)
        {
            lblCategoria.Text = CategoriaSeleccionada;
            cargarDocumentos();
            dvgCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cargarDocumentos()
        {
            try
            {
                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.llenarCategoria(dvgCategorias, int.Parse(fmr_PantallaInicio.UsuarioActual), CategoriaSeleccionada);

                total_documentos = dvgCategorias.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar documentos: " + ex.Message);
            }
        }

        public static int total_documentos { get; set; }
        private void dvgCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ClsTablas.Documento documento = new ClsTablas.Documento();
                documento.menu(dvgCategorias, e);
            }
        }

        private void dvgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Categorias regreso = new Categorias();
            regreso.Show();
            this.Hide();
        }
    }
}
