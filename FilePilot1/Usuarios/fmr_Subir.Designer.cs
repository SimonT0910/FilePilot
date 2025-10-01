namespace FilePilot1
{
    partial class fmr_subir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.ptb_inicio = new System.Windows.Forms.PictureBox();
            this.pcb_documentos = new System.Windows.Forms.PictureBox();
            this.btn_inico = new System.Windows.Forms.Button();
            this.btn_Mis_documentos = new System.Windows.Forms.Button();
            this.lbl_recientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_subir = new System.Windows.Forms.Button();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcb_subir = new System.Windows.Forms.PictureBox();
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_botones.Controls.Add(this.ptb_inicio);
            this.pnl_botones.Controls.Add(this.pcb_documentos);
            this.pnl_botones.Controls.Add(this.btn_inico);
            this.pnl_botones.Controls.Add(this.btn_Mis_documentos);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_botones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(267, 554);
            this.pnl_botones.TabIndex = 20;
            this.pnl_botones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_botones_Paint);
            // 
            // ptb_inicio
            // 
            this.ptb_inicio.BackColor = System.Drawing.Color.White;
            this.ptb_inicio.BackgroundImage = global::FilePilot1.Properties.Resources.inicio;
            this.ptb_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_inicio.Location = new System.Drawing.Point(5, 466);
            this.ptb_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptb_inicio.Name = "ptb_inicio";
            this.ptb_inicio.Size = new System.Drawing.Size(71, 59);
            this.ptb_inicio.TabIndex = 7;
            this.ptb_inicio.TabStop = false;
            // 
            // pcb_documentos
            // 
            this.pcb_documentos.BackColor = System.Drawing.Color.White;
            this.pcb_documentos.BackgroundImage = global::FilePilot1.Properties.Resources.Mis_archivos;
            this.pcb_documentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_documentos.ErrorImage = null;
            this.pcb_documentos.Location = new System.Drawing.Point(5, 30);
            this.pcb_documentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_documentos.Name = "pcb_documentos";
            this.pcb_documentos.Size = new System.Drawing.Size(71, 59);
            this.pcb_documentos.TabIndex = 5;
            this.pcb_documentos.TabStop = false;
            // 
            // btn_inico
            // 
            this.btn_inico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inico.Location = new System.Drawing.Point(84, 466);
            this.btn_inico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inico.Name = "btn_inico";
            this.btn_inico.Size = new System.Drawing.Size(167, 59);
            this.btn_inico.TabIndex = 3;
            this.btn_inico.Text = "Inicio";
            this.btn_inico.UseVisualStyleBackColor = true;
            this.btn_inico.Click += new System.EventHandler(this.btn_inico_Click);
            // 
            // btn_Mis_documentos
            // 
            this.btn_Mis_documentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mis_documentos.Location = new System.Drawing.Point(84, 30);
            this.btn_Mis_documentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Mis_documentos.Name = "btn_Mis_documentos";
            this.btn_Mis_documentos.Size = new System.Drawing.Size(167, 59);
            this.btn_Mis_documentos.TabIndex = 0;
            this.btn_Mis_documentos.Text = "Mis documentos";
            this.btn_Mis_documentos.UseVisualStyleBackColor = true;
            this.btn_Mis_documentos.Click += new System.EventHandler(this.btn_Mis_documentos_Click);
            // 
            // lbl_recientes
            // 
            this.lbl_recientes.AutoSize = true;
            this.lbl_recientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recientes.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recientes.Location = new System.Drawing.Point(273, 197);
            this.lbl_recientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recientes.Name = "lbl_recientes";
            this.lbl_recientes.Size = new System.Drawing.Size(108, 29);
            this.lbl_recientes.TabIndex = 28;
            this.lbl_recientes.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 65);
            this.label1.TabIndex = 25;
            this.label1.Text = "Subir documentos nuevos";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(393, 197);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(285, 30);
            this.txt_nombre.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Categoria:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(832, 197);
            this.cmb_categoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(232, 30);
            this.cmb_categoria.TabIndex = 33;
            this.cmb_categoria.Text = "Selecione una categoria";
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(435, 274);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion.Size = new System.Drawing.Size(615, 154);
            this.txt_descripcion.TabIndex = 35;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Location = new System.Drawing.Point(435, 454);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(167, 59);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_subir
            // 
            this.btn_subir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_subir.Location = new System.Drawing.Point(796, 454);
            this.btn_subir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_subir.Name = "btn_subir";
            this.btn_subir.Size = new System.Drawing.Size(167, 59);
            this.btn_subir.TabIndex = 37;
            this.btn_subir.Text = "Subir documento";
            this.btn_subir.UseVisualStyleBackColor = true;
            this.btn_subir.Click += new System.EventHandler(this.btn_subir_Click);
            // 
            // btn_examinar
            // 
            this.btn_examinar.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_examinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_examinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar.Location = new System.Drawing.Point(357, 112);
            this.btn_examinar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(167, 59);
            this.btn_examinar.TabIndex = 40;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.UseVisualStyleBackColor = false;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ruta.Location = new System.Drawing.Point(532, 139);
            this.txt_ruta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.ReadOnly = true;
            this.txt_ruta.Size = new System.Drawing.Size(517, 30);
            this.txt_ruta.TabIndex = 41;
            this.txt_ruta.TextChanged += new System.EventHandler(this.txt_ruta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(532, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ruta:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::FilePilot1.Properties.Resources.seleccionar_archivo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(279, 112);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 59);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FilePilot1.Properties.Resources.subir_documento;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(717, 454);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 59);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FilePilot1.Properties.Resources.cancelar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(356, 454);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 59);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pcb_subir
            // 
            this.pcb_subir.BackColor = System.Drawing.Color.Transparent;
            this.pcb_subir.BackgroundImage = global::FilePilot1.Properties.Resources.Subir_documentos;
            this.pcb_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_subir.ErrorImage = null;
            this.pcb_subir.Location = new System.Drawing.Point(971, 1);
            this.pcb_subir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_subir.Name = "pcb_subir";
            this.pcb_subir.Size = new System.Drawing.Size(95, 78);
            this.pcb_subir.TabIndex = 26;
            this.pcb_subir.TabStop = false;
            // 
            // fmr_subir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_subir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_recientes);
            this.Controls.Add(this.pcb_subir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_botones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmr_subir";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fmr_subir_Load);
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.PictureBox ptb_inicio;
        private System.Windows.Forms.PictureBox pcb_documentos;
        private System.Windows.Forms.Button btn_inico;
        private System.Windows.Forms.Button btn_Mis_documentos;
        private System.Windows.Forms.Label lbl_recientes;
        private System.Windows.Forms.PictureBox pcb_subir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_subir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Label label4;
    }
}