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
    public partial class restaurar : Form
    {
        private Forms resizer;
        public restaurar()
        {
            InitializeComponent();
            resizer = new Forms(this);
        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            frm_Admin admin = new frm_Admin();
            admin.Show();
            this.Hide();
        }

        private void restaurar_Load(object sender, EventArgs e)
        {

        }
    }
}
