using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FilePilot1
{
    internal class Forms
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlsOriginalRects = new Dictionary<Control, Rectangle>();
        private Dictionary<Control, float> controlsOriginalFontSizes = new Dictionary<Control, float>();

        private System.Windows.Forms.Form form; // Guardamos referencia del form

        public Forms(System.Windows.Forms.Form form)
        {
            this.form = form;
            form.Load += Form_Load;
            form.Resize += Form_Resize;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            originalFormSize = form.Size;
            controlsOriginalRects.Clear();
            controlsOriginalFontSizes.Clear();
            SaveControlRectsAndFonts(form);

            // Abrir maximizado
            form.WindowState = FormWindowState.Maximized;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)form.Width / originalFormSize.Width;
            float yRatio = (float)form.Height / originalFormSize.Height;
            float fontRatio = Math.Min(xRatio, yRatio);

            ResizeControlsAndFonts(form, xRatio, yRatio, fontRatio);
        }

        // Guarda posición, tamaño y fuente
        private void SaveControlRectsAndFonts(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                controlsOriginalRects[ctrl] = new Rectangle(ctrl.Location, ctrl.Size);
                controlsOriginalFontSizes[ctrl] = ctrl.Font.Size;
                if (ctrl.Controls.Count > 0)
                    SaveControlRectsAndFonts(ctrl);
            }
        }

        // Redimensiona recursivamente
        private void ResizeControlsAndFonts(Control parent, float xRatio, float yRatio, float fontRatio)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (controlsOriginalRects.TryGetValue(ctrl, out Rectangle originalRect))
                {
                    ctrl.Location = new Point(
                        (int)(originalRect.X * xRatio),
                        (int)(originalRect.Y * yRatio)
                    );
                    ctrl.Size = new Size(
                        (int)(originalRect.Width * xRatio),
                        (int)(originalRect.Height * yRatio)
                    );
                }

                if (controlsOriginalFontSizes.TryGetValue(ctrl, out float originalFontSize))
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, originalFontSize * fontRatio, ctrl.Font.Style);
                }

                if (ctrl.Controls.Count > 0)
                    ResizeControlsAndFonts(ctrl, xRatio, yRatio, fontRatio);
            }
        }

        public static class FormUtils
        {
            public static void LimpiarCampos(Control parent)
            {
                foreach (Control ctrl in parent.Controls)
                {
                    if (ctrl is TextBox)
                        ((TextBox)ctrl).Clear();
                    else if (ctrl is ComboBox)
                        ((ComboBox)ctrl).SelectedIndex = -1;
                    else if (ctrl is CheckBox)
                        ((CheckBox)ctrl).Checked = false;
                    else if (ctrl is RadioButton)
                        ((RadioButton)ctrl).Checked = false;
                    else if (ctrl.HasChildren)
                        LimpiarCampos(ctrl);
                }
            }
        }
    }
}
