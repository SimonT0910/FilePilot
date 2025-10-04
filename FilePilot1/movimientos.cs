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
    public partial class movimientos : Form
    {
        private Forms resizer;
        public movimientos()
        {
            InitializeComponent();
            resizer = new Forms(this);
        }

        private void movimientos_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
            CargarFiltros();
        }

        private void CargarFiltros()
        {
            cmbFiltrado.Items.Add("Todos");
            cmbFiltrado.Items.Add("Inicio de Sesión");
            cmbFiltrado.Items.Add("Cierre de Sesión");
            cmbFiltrado.Items.Add("Subida de Documento");
            cmbFiltrado.Items.Add("Eliminación de Documento");
            cmbFiltrado.Items.Add("Creación de Categoría");
            cmbFiltrado.Items.Add("Eliminación de Categoría");
            cmbFiltrado.SelectedIndex = 0;
        }

        private void CargarMovimientos(string usuarioFiltro = "", string tipoFiltro = "")
        {
            try
            {
                ClsTablas.Movimientos movi = new ClsTablas.Movimientos();
                DataTable dt = movi.Obtener(usuarioFiltro, tipoFiltro);

                dvgMovimientos.Rows.Clear();

                foreach (DataRow fila in dt.Rows)
                {
                    int nueva = dvgMovimientos.Rows.Add();

                    dvgMovimientos.Rows[nueva].Cells["fecha"].Value = Convert.ToDateTime(fila["fechaMovimiento"]).ToString("dd/MM/yyyy HH:mm");

                    dvgMovimientos.Rows[nueva].Cells["nombre"].Value = fila["usuario"].ToString();

                    dvgMovimientos.Rows[nueva].Cells["tipo"].Value = fila["tipoMovimiento"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar movimientos: " + ex.Message);
            }
        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            frm_Admin admin = new frm_Admin();
            admin.Show();
            this.Hide();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            FiltrarMovimientos();
        }

        private void cmbFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarMovimientos();
        }

        private void FiltrarMovimientos()
        {
            string usuarioFiltro = txt_busqueda.Text;
            string tipoFiltro = cmbFiltrado.SelectedItem?.ToString() ?? "";
            CargarMovimientos(usuarioFiltro, tipoFiltro);
        }

        private void cmbFiltrado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
