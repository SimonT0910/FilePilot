using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FilePilot1
{
    public partial class PantallaInicio : Form
    {
        private Size originalFormSize;

        // Diccionario para guardar posición y tamaño original de cada control
        private Dictionary<Control, Rectangle> controlsOriginalRects =
            new Dictionary<Control, Rectangle>();



        public PantallaInicio()
        {
            InitializeComponent();
            

            
            this.Resize += Form1_Resize;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Guardar tamaño inicial del formulario
            originalFormSize = this.Size;

            // Guardar la posición y tamaño original de cada control
            foreach (Control ctrl in this.Controls)
            {
                controlsOriginalRects[ctrl] = new Rectangle(ctrl.Location, ctrl.Size);
            }

            // Abrir maximizado
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Calcular proporciones de cambio
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            // Ajustar cada control según el nuevo tamaño
            foreach (Control ctrl in this.Controls)
            {
                Rectangle originalRect = controlsOriginalRects[ctrl];
                int newX = (int)(originalRect.X * xRatio);
                int newY = (int)(originalRect.Y * yRatio);
                int newWidth = (int)(originalRect.Width * xRatio);
                int newHeight = (int)(originalRect.Height * yRatio);

                ctrl.Location = new Point(newX, newY);
                ctrl.Size = new Size(newWidth, newHeight);
            }

        }
    }
}
