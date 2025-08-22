using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FilePilot1
{
    public partial class fmr_PantallaInicio : System.Windows.Forms.Form
    {
        private Forms formsHelper;

        public fmr_PantallaInicio()
        {
            
            InitializeComponent();
            formsHelper = new Forms(this); // Esto adapta y amplía la pantalla automáticamente
        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmrOrg = new fmr_OrgDeArchi();
            fmrOrg.Show();
            this.Hide();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            registroUsuario registro = new registroUsuario();
            registro.Show();
            this.Hide();
        }
    }

}
