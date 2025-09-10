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
   
    public partial class frm_Modificar : Form
    {
        cConexion conexion;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private DataGridView miDataGrid;
        public frm_Modificar(int id, DataGridView midataGrid)
        {   cConexion conexion = new cConexion();
            this.miDataGrid = midataGrid;
            SqlCommand cmd = new SqlCommand("SELECT idDocumento, nombre, categoria FROM Documento WHERE idDocumento = @id", conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@id", id);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;// para que el formulario se abra en el centro de la pantalla
        }


        private void frm_Modificar_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = dt.Rows[0]["nombre"].ToString();
            cmb_categoria.Text = dt.Rows[0]["categoria"].ToString();
            ClsTablas.categorias categoria = new ClsTablas.categorias();
            categoria.CargarCategorias(cmb_categoria);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_confimar_Click(object sender, EventArgs e)
        {
            cConexion conexion = new cConexion();

            if(string.IsNullOrWhiteSpace(txt_nombre.Text) || (txt_nombre.Text.Equals(dt.Rows[0]["nombre"].ToString()) && cmb_categoria.Text.Equals(dt.Rows[0]["categoria"].ToString())))
            {
                MessageBox.Show(dt.Rows[0]["nombre"].ToString());
                MessageBox.Show("Por favor, verifique bien todos los campos.");
                return;
            }
            else if (txt_nombre.Text != (dt.Rows[0]["nombre"].ToString()))
            {
                cmd = new SqlCommand("UPDATE Documento SET nombre = @nombre, fechaSubida = @fecha WHERE idDocumento = @id", conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", dt.Rows[0]["idDocumento"].ToString());
                int filasAfectadas = cmd.ExecuteNonQuery();//no devuelve nada, solo ejecuta la consulta y da el numero de filas afectadas
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Documento modificado exitosamente.");
                    
                    this.Hide();
                    miDataGrid.Rows.Clear();
                    miDataGrid.Refresh();
                    ClsTablas.Documento documento = new ClsTablas.Documento();
                    documento.llenarGrid(miDataGrid, int.Parse(fmr_PantallaInicio.UsuarioActual));

                    
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el documento. Inténtalo de nuevo.");
                }
            }
            else if (cmb_categoria.Text != (dt.Rows[0]["categoria"].ToString()))
            {
                cmd = new SqlCommand("UPDATE Documento SET categoria = @categoria, fechaSubida = @fecha WHERE idDocumento = @id", conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@categoria", cmb_categoria.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", dt.Rows[0]["idDocumento"].ToString());
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Documento modificado exitosamente.");
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el documento. Inténtalo de nuevo.");
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Documento SET nombre = @nombre, categoria = @categoria WHERE idDocumento = @id", conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@categoria", cmb_categoria.Text);
                    cmd.Parameters.AddWithValue("@id", dt.Rows[0]["idDocumento"].ToString());
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Documento modificado exitosamente.");
                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el documento. Inténtalo de nuevo.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el documento: " + ex.Message);
                }
            }
        }
    }
}
