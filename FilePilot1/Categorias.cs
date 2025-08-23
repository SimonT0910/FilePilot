using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FilePilot1
{
    public partial class Categorias : Form
    {
        private List<string> categorias = new List<string>();

        private Forms resizer;

        public Categorias()
        {
            InitializeComponent();
            resizer = new Forms(this);

        }

        private void btn_inico_Click(object sender, EventArgs e)
        {
            fmr_OrgDeArchi fmr_OrgDeArchi = new fmr_OrgDeArchi();
            fmr_OrgDeArchi.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            foreach (string categoria in categorias)
            {
                AgregarCategoria(categoria);
            }

            if (!categorias.Contains("Otros"))
            {
                AgregarCategoria("Otros");
            }
        }

        private void AgregarCategoria(String nombre)
        {
            if(categorias.Contains(nombre))
            {
                MessageBox.Show("La categoría ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            categorias.Add(nombre);

            Panel contenedor = new Panel();
            contenedor.Margin = new Padding(10);
            contenedor.Width = 150;
            contenedor.Height = 150;

            PictureBox pb = new PictureBox();
            pb.Image = Properties.Resources.carpetas;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Width = 100;
            pb.Height = 100;
            pb.Location = new Point((contenedor.Width - pb.Width) / 2, 10);
            pb.Cursor = Cursors.Hand;

            Label lbl = new Label();
            lbl.Text = nombre;
            lbl.TextAlign = ContentAlignment.TopCenter;
            lbl.Width = contenedor.Width - 10;
            lbl.Location = new Point(5, pb.Bottom + 5);
            lbl.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            lbl.MaximumSize = new Size(contenedor.Width - 10, 0);
            lbl.AutoSize = true;

            contenedor.Controls.Add(pb);
            contenedor.Controls.Add(lbl);
            contenedor.Tag = nombre;

            flowLayoutPanel1.Controls.Add(contenedor);
        }

        private void EliminarCategoria(String nombre)
        {
            Control eliminar = null;

            foreach(Control c in flowLayoutPanel1.Controls)
            {
                if(c.Tag != null && c.Tag.ToString() == nombre)
                {
                    eliminar = c;
                    break;
                }
            }
            if(eliminar != null)
            {
                flowLayoutPanel1.Controls.Remove(eliminar);
                eliminar.Dispose();
            }
            else
            {
                MessageBox.Show("No se encontró la categoría a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(categorias.Contains(nombre))
            {
                categorias.Remove(nombre);
            }
        }

        private void btnAgregarCate_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la nueva categoría:", "Nueva Categoría", "Categoria");

            if (!string.IsNullOrEmpty(nombre))
            {
                AgregarCategoria(nombre);
            }
        }

        private void btnEliminarCate_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la categoría a eliminar:", "Eliminar Categoría", "");

            if(!string.IsNullOrEmpty(nombre))
            {
                EliminarCategoria(nombre);
            }
        }
    }
}
