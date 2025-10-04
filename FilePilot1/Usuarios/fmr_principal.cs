using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FilePilot1
{
    public partial class fmr_PantallaInicio : System.Windows.Forms.Form
    {
        private Forms formsHelper;
        public static string UsuarioActual { get; set; }
        

        public fmr_PantallaInicio()
        {
            InitializeComponent();
            formsHelper = new Forms(this); // Esto adapta y amplía la pantalla automáticamente

            // Habilitar doble buffer y estilos para reducir flickering
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        // Sobrescribir CreateParams para aplicar WS_EX_COMPOSITED
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            ClsTablas.Usuario validar = new ClsTablas.Usuario();
            string usuario = txt_usuario.Text;
            string contrasena = txt_contra.Text;

            string validarUsuario = validar.validarUsuario(usuario, contrasena);

            if (validarUsuario.Equals("Correcto"))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                UsuarioActual = txt_usuario.Text;
                fmr_OrgDeArchi fmrOrg = new fmr_OrgDeArchi();
                fmrOrg.Show();
                this.Hide();
                ClsTablas.Movimientos mov = new ClsTablas.Movimientos();
                mov.registrar(int.Parse(UsuarioActual), "Inicio de Sesión");
            }
            else
            {
                MessageBox.Show(validarUsuario);
            }


           
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            registroUsuario registro = new registroUsuario();
            registro.Show();
            this.Hide();
        }

        private void btn_trabajador_Click(object sender, EventArgs e)
        {
            frm_Administrador administrador = new frm_Administrador();
            administrador.Show();
            
        }

        private void fmr_PantallaInicio_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Day == 15 || DateTime.Now.Day == 30)
            {
                ClsTablas.Movimientos mov = new ClsTablas.Movimientos();
                mov.limpiar(15);
            }
        }

        private void Lbl_orga_Click(object sender, EventArgs e)
        {

        }
    }
}
