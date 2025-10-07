namespace FilePilot1
{
    partial class fmr_PantallaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FiletPilot = new System.Windows.Forms.Label();
            this.Lbl_orga = new System.Windows.Forms.Label();
            this.lbl_usu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.btn_trabajador = new System.Windows.Forms.Button();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_contra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FiletPilot
            // 
            this.FiletPilot.AutoSize = true;
            this.FiletPilot.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiletPilot.Location = new System.Drawing.Point(491, -5);
            this.FiletPilot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FiletPilot.Name = "FiletPilot";
            this.FiletPilot.Size = new System.Drawing.Size(326, 89);
            this.FiletPilot.TabIndex = 0;
            this.FiletPilot.Text = "FilePilot";
            this.FiletPilot.Click += new System.EventHandler(this.FiletPilot_Click);
            // 
            // Lbl_orga
            // 
            this.Lbl_orga.AutoSize = true;
            this.Lbl_orga.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_orga.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_orga.Location = new System.Drawing.Point(433, 169);
            this.Lbl_orga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_orga.Name = "Lbl_orga";
            this.Lbl_orga.Size = new System.Drawing.Size(538, 34);
            this.Lbl_orga.TabIndex = 1;
            this.Lbl_orga.Text = "Organizador profesional de archivos";
            this.Lbl_orga.Click += new System.EventHandler(this.Lbl_orga_Click);
            // 
            // lbl_usu
            // 
            this.lbl_usu.AutoSize = true;
            this.lbl_usu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usu.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usu.Location = new System.Drawing.Point(435, 319);
            this.lbl_usu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usu.Name = "lbl_usu";
            this.lbl_usu.Size = new System.Drawing.Size(99, 28);
            this.lbl_usu.TabIndex = 2;
            this.lbl_usu.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 9;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(579, 316);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(335, 30);
            this.txt_usuario.TabIndex = 4;
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.Location = new System.Drawing.Point(579, 402);
            this.txt_contra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(335, 30);
            this.txt_contra.TabIndex = 5;
            // 
            // btn_trabajador
            // 
            this.btn_trabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_trabajador.BackColor = System.Drawing.Color.White;
            this.btn_trabajador.BackgroundImage = global::FilePilot1.Properties.Resources.area_trabajador;
            this.btn_trabajador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_trabajador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_trabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trabajador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trabajador.Location = new System.Drawing.Point(705, 478);
            this.btn_trabajador.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trabajador.Name = "btn_trabajador";
            this.btn_trabajador.Size = new System.Drawing.Size(87, 69);
            this.btn_trabajador.TabIndex = 6;
            this.btn_trabajador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_trabajador.UseVisualStyleBackColor = false;
            this.btn_trabajador.Click += new System.EventHandler(this.btn_trabajador_Click);
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.BackColor = System.Drawing.Color.LightCyan;
            this.btn_registrarse.BackgroundImage = global::FilePilot1.Properties.Resources.registrarse;
            this.btn_registrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarse.Location = new System.Drawing.Point(545, 478);
            this.btn_registrarse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(88, 66);
            this.btn_registrarse.TabIndex = 7;
            this.btn_registrarse.UseVisualStyleBackColor = false;
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.LightCyan;
            this.btn_iniciar.BackgroundImage = global::FilePilot1.Properties.Resources.inicio_sesion;
            this.btn_iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iniciar.Location = new System.Drawing.Point(848, 478);
            this.btn_iniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(84, 70);
            this.btn_iniciar.TabIndex = 8;
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // lbl_contra
            // 
            this.lbl_contra.AutoSize = true;
            this.lbl_contra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contra.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contra.Location = new System.Drawing.Point(435, 407);
            this.lbl_contra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contra.Name = "lbl_contra";
            this.lbl_contra.Size = new System.Drawing.Size(134, 28);
            this.lbl_contra.TabIndex = 10;
            this.lbl_contra.Text = "Contraseña:";
            // 
            // fmr_PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::FilePilot1.Properties.Resources.principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 617);
            this.Controls.Add(this.lbl_contra);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.btn_trabajador);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_usu);
            this.Controls.Add(this.Lbl_orga);
            this.Controls.Add(this.FiletPilot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmr_PantallaInicio";
            this.Text = "Pantalla inicio";
            this.Load += new System.EventHandler(this.fmr_PantallaInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FiletPilot;
        private System.Windows.Forms.Label Lbl_orga;
        private System.Windows.Forms.Label lbl_usu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Button btn_trabajador;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_contra;
    }
}

