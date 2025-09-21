namespace FilePilot1
{
    partial class fmr_OrgDeArchi
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
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_recientes = new System.Windows.Forms.Label();
            this.dgv_recientes = new System.Windows.Forms.DataGridView();
            this.dgv_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.btn__subir_docum = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_mirar_respaldos = new System.Windows.Forms.Button();
            this.Btn_categorias = new System.Windows.Forms.Button();
            this.btn_Mis_documentos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcb_categorias = new System.Windows.Forms.PictureBox();
            this.pcb_respaldos = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcb_Subir = new System.Windows.Forms.PictureBox();
            this.pcb_documentos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recientes)).BeginInit();
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_categorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_respaldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Subir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_documentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(516, 484);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(132, 22);
            this.txt_total.TabIndex = 24;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(276, 480);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(202, 29);
            this.lbl_total.TabIndex = 23;
            this.lbl_total.Text = "Total de archivos:";
            // 
            // lbl_recientes
            // 
            this.lbl_recientes.AutoSize = true;
            this.lbl_recientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recientes.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recientes.Location = new System.Drawing.Point(276, 130);
            this.lbl_recientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recientes.Name = "lbl_recientes";
            this.lbl_recientes.Size = new System.Drawing.Size(213, 29);
            this.lbl_recientes.TabIndex = 22;
            this.lbl_recientes.Text = "archivos recientes:";
            // 
            // dgv_recientes
            // 
            this.dgv_recientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_recientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_recientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_nombre,
            this.dgv_fecha});
            this.dgv_recientes.Location = new System.Drawing.Point(516, 130);
            this.dgv_recientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_recientes.Name = "dgv_recientes";
            this.dgv_recientes.ReadOnly = true;
            this.dgv_recientes.RowHeadersWidth = 51;
            this.dgv_recientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_recientes.Size = new System.Drawing.Size(536, 298);
            this.dgv_recientes.TabIndex = 21;
            this.dgv_recientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_recientes_MouseClick);
            // 
            // dgv_nombre
            // 
            this.dgv_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_nombre.FillWeight = 150F;
            this.dgv_nombre.HeaderText = "Nombre";
            this.dgv_nombre.MinimumWidth = 6;
            this.dgv_nombre.Name = "dgv_nombre";
            this.dgv_nombre.ReadOnly = true;
            // 
            // dgv_fecha
            // 
            this.dgv_fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_fecha.FillWeight = 50F;
            this.dgv_fecha.HeaderText = "Fecha";
            this.dgv_fecha.MinimumWidth = 6;
            this.dgv_fecha.Name = "dgv_fecha";
            this.dgv_fecha.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 68);
            this.label1.TabIndex = 19;
            this.label1.Text = "Organizador de archivos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_botones.Controls.Add(this.pcb_categorias);
            this.pnl_botones.Controls.Add(this.pcb_respaldos);
            this.pnl_botones.Controls.Add(this.pictureBox3);
            this.pnl_botones.Controls.Add(this.pcb_Subir);
            this.pnl_botones.Controls.Add(this.pcb_documentos);
            this.pnl_botones.Controls.Add(this.btn__subir_docum);
            this.pnl_botones.Controls.Add(this.btn_cerrar);
            this.pnl_botones.Controls.Add(this.btn_mirar_respaldos);
            this.pnl_botones.Controls.Add(this.Btn_categorias);
            this.pnl_botones.Controls.Add(this.btn_Mis_documentos);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_botones.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(267, 554);
            this.pnl_botones.TabIndex = 18;
            // 
            // btn__subir_docum
            // 
            this.btn__subir_docum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn__subir_docum.Location = new System.Drawing.Point(84, 130);
            this.btn__subir_docum.Margin = new System.Windows.Forms.Padding(4);
            this.btn__subir_docum.Name = "btn__subir_docum";
            this.btn__subir_docum.Size = new System.Drawing.Size(167, 59);
            this.btn__subir_docum.TabIndex = 4;
            this.btn__subir_docum.Text = "Subir documentos";
            this.btn__subir_docum.UseVisualStyleBackColor = true;
            this.btn__subir_docum.Click += new System.EventHandler(this.btn__subir_docum_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Location = new System.Drawing.Point(84, 466);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(167, 59);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar sesion";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_mirar_respaldos
            // 
            this.btn_mirar_respaldos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mirar_respaldos.Location = new System.Drawing.Point(84, 350);
            this.btn_mirar_respaldos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mirar_respaldos.Name = "btn_mirar_respaldos";
            this.btn_mirar_respaldos.Size = new System.Drawing.Size(167, 59);
            this.btn_mirar_respaldos.TabIndex = 2;
            this.btn_mirar_respaldos.Text = "Mirar respaldos";
            this.btn_mirar_respaldos.UseVisualStyleBackColor = true;
            this.btn_mirar_respaldos.Click += new System.EventHandler(this.btn_mirar_respaldos_Click);
            // 
            // Btn_categorias
            // 
            this.Btn_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_categorias.Location = new System.Drawing.Point(84, 240);
            this.Btn_categorias.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_categorias.Name = "Btn_categorias";
            this.Btn_categorias.Size = new System.Drawing.Size(167, 59);
            this.Btn_categorias.TabIndex = 1;
            this.Btn_categorias.Text = "Categorias";
            this.Btn_categorias.UseVisualStyleBackColor = true;
            this.Btn_categorias.Click += new System.EventHandler(this.Btn_categorias_Click);
            // 
            // btn_Mis_documentos
            // 
            this.btn_Mis_documentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mis_documentos.Location = new System.Drawing.Point(84, 30);
            this.btn_Mis_documentos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Mis_documentos.Name = "btn_Mis_documentos";
            this.btn_Mis_documentos.Size = new System.Drawing.Size(167, 59);
            this.btn_Mis_documentos.TabIndex = 0;
            this.btn_Mis_documentos.Text = "Mis documentos";
            this.btn_Mis_documentos.UseVisualStyleBackColor = true;
            this.btn_Mis_documentos.Click += new System.EventHandler(this.btn_Mis_documentos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FilePilot1.Properties.Resources.inicio;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(972, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 78);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcb_categorias
            // 
            this.pcb_categorias.BackColor = System.Drawing.Color.White;
            this.pcb_categorias.BackgroundImage = global::FilePilot1.Properties.Resources.categoria;
            this.pcb_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_categorias.Location = new System.Drawing.Point(5, 240);
            this.pcb_categorias.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_categorias.Name = "pcb_categorias";
            this.pcb_categorias.Size = new System.Drawing.Size(71, 59);
            this.pcb_categorias.TabIndex = 9;
            this.pcb_categorias.TabStop = false;
            // 
            // pcb_respaldos
            // 
            this.pcb_respaldos.BackColor = System.Drawing.Color.White;
            this.pcb_respaldos.BackgroundImage = global::FilePilot1.Properties.Resources.mirar_respaldos;
            this.pcb_respaldos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_respaldos.Location = new System.Drawing.Point(5, 350);
            this.pcb_respaldos.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_respaldos.Name = "pcb_respaldos";
            this.pcb_respaldos.Size = new System.Drawing.Size(71, 59);
            this.pcb_respaldos.TabIndex = 8;
            this.pcb_respaldos.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::FilePilot1.Properties.Resources.cerrar_sesion;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(5, 466);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 59);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pcb_Subir
            // 
            this.pcb_Subir.BackColor = System.Drawing.Color.White;
            this.pcb_Subir.BackgroundImage = global::FilePilot1.Properties.Resources.Subir_documentos;
            this.pcb_Subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_Subir.Location = new System.Drawing.Point(5, 130);
            this.pcb_Subir.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_Subir.Name = "pcb_Subir";
            this.pcb_Subir.Size = new System.Drawing.Size(71, 59);
            this.pcb_Subir.TabIndex = 6;
            this.pcb_Subir.TabStop = false;
            // 
            // pcb_documentos
            // 
            this.pcb_documentos.BackColor = System.Drawing.Color.White;
            this.pcb_documentos.BackgroundImage = global::FilePilot1.Properties.Resources.Mis_archivos;
            this.pcb_documentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_documentos.ErrorImage = null;
            this.pcb_documentos.Location = new System.Drawing.Point(5, 30);
            this.pcb_documentos.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_documentos.Name = "pcb_documentos";
            this.pcb_documentos.Size = new System.Drawing.Size(71, 59);
            this.pcb_documentos.TabIndex = 5;
            this.pcb_documentos.TabStop = false;
            // 
            // fmr_OrgDeArchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_recientes);
            this.Controls.Add(this.dgv_recientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_botones);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmr_OrgDeArchi";
            this.Text = "Organizador de archivos";
            this.Load += new System.EventHandler(this.fmr_OrgDeArchi_Load);
            this.Shown += new System.EventHandler(this.fmr_OrgDeArchi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recientes)).EndInit();
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_categorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_respaldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Subir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_documentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_recientes;
        private System.Windows.Forms.DataGridView dgv_recientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.PictureBox pcb_categorias;
        private System.Windows.Forms.PictureBox pcb_respaldos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pcb_Subir;
        private System.Windows.Forms.PictureBox pcb_documentos;
        private System.Windows.Forms.Button btn__subir_docum;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_mirar_respaldos;
        private System.Windows.Forms.Button Btn_categorias;
        private System.Windows.Forms.Button btn_Mis_documentos;
    }
}