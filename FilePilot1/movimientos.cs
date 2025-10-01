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

        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            frm_Admin admin = new frm_Admin();
            admin.Show();
            this.Hide();
        }
    }
}
