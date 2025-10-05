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
    public partial class frmVerUs : Form
    {
        cConexion conexion;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
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
            dgv_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            frm_Admin admin = new frm_Admin();
            admin.Show();
            this.Hide();
        }

        private void dgv_usuarios_DoubleClick(object sender, EventArgs e)
        {
            cConexion conexion = new cConexion();
            int id = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value);
            cmd = new SqlCommand("SELECT contraseña FROM Usuario WHERE idUsuario = @id", conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@id", id);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            string contraseña = dt.Rows[0]["contraseña"].ToString();
            ClsTablas.Usuario usuario = new ClsTablas.Usuario();
            string validarUsuario = usuario.validarUsuario(id.ToString(), contraseña);

            if (validarUsuario.Equals("Correcto"))
            {
                MessageBox.Show("Inicio de sesión existoso");
                fmr_PantallaInicio.UsuarioActual = id.ToString();
                fmr_OrgDeArchi org = new fmr_OrgDeArchi();
                org.admin = true;
                org.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validarUsuario);
            }
        }

        private void dgv_usuarios_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgv_usuarios.ClearSelection();
                dgv_usuarios.Rows[e.RowIndex].Selected = true;
                dgv_usuarios.CurrentCell = dgv_usuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
    }
}
