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
    public partial class mirarResplados : Form
    {
        private Forms resizer;
        public mirarResplados()
        {
            InitializeComponent();
            resizer = new Forms(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi();
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void mirarResplados_Load(object sender, EventArgs e)
        {

        }
    }
}
