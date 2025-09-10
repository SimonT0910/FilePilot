namespace FilePilot1
{
    partial class misdocumentos
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
            this.btnRealizarRespaldos = new System.Windows.Forms.Button();
            this.btnSubirDocumentos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pi = new System.Windows.Forms.PictureBox();
            this.ptb_inicio = new System.Windows.Forms.PictureBox();
            this.btn_inico = new System.Windows.Forms.Button();
            this.pcb_subir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMisDocumentos = new System.Windows.Forms.DataGridView();
            this.dgv_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_botones.Controls.Add(this.btnRealizarRespaldos);
            this.pnl_botones.Controls.Add(this.btnSubirDocumentos);
            this.pnl_botones.Controls.Add(this.pictureBox1);
            this.pnl_botones.Controls.Add(this.pi);
            this.pnl_botones.Controls.Add(this.ptb_inicio);
            this.pnl_botones.Controls.Add(this.btn_inico);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_botones.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(267, 554);
            this.pnl_botones.TabIndex = 21;
            // 
            // btnRealizarRespaldos
            // 
            this.btnRealizarRespaldos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarRespaldos.Location = new System.Drawing.Point(83, 442);
            this.btnRealizarRespaldos.Margin = new System.Windows.Forms.Padding(4);
            this.btnRealizarRespaldos.Name = "btnRealizarRespaldos";
            this.btnRealizarRespaldos.Size = new System.Drawing.Size(167, 59);
            this.btnRealizarRespaldos.TabIndex = 11;
            this.btnRealizarRespaldos.Text = "Realizar respaldos";
            this.btnRealizarRespaldos.UseVisualStyleBackColor = true;
            // 
            // btnSubirDocumentos
            // 
            this.btnSubirDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirDocumentos.Location = new System.Drawing.Point(83, 222);
            this.btnSubirDocumentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirDocumentos.Name = "btnSubirDocumentos";
            this.btnSubirDocumentos.Size = new System.Drawing.Size(167, 59);
            this.btnSubirDocumentos.TabIndex = 9;
            this.btnSubirDocumentos.Text = "Subir documentos";
            this.btnSubirDocumentos.UseVisualStyleBackColor = true;
            this.btnSubirDocumentos.Click += new System.EventHandler(this.btnSubirDocumentos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::FilePilot1.Properties.Resources.Subir_documentos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 222);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 59);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.Color.White;
            this.pi.BackgroundImage = global::FilePilot1.Properties.Resources.realizar_respaldos;
            this.pi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pi.Location = new System.Drawing.Point(4, 442);
            this.pi.Margin = new System.Windows.Forms.Padding(4);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(71, 59);
            this.pi.TabIndex = 9;
            this.pi.TabStop = false;
            // 
            // ptb_inicio
            // 
            this.ptb_inicio.BackColor = System.Drawing.Color.White;
            this.ptb_inicio.BackgroundImage = global::FilePilot1.Properties.Resources.inicio;
            this.ptb_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_inicio.Location = new System.Drawing.Point(4, 13);
            this.ptb_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_inicio.Name = "ptb_inicio";
            this.ptb_inicio.Size = new System.Drawing.Size(71, 59);
            this.ptb_inicio.TabIndex = 7;
            this.ptb_inicio.TabStop = false;
            // 
            // btn_inico
            // 
            this.btn_inico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inico.Location = new System.Drawing.Point(83, 13);
            this.btn_inico.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inico.Name = "btn_inico";
            this.btn_inico.Size = new System.Drawing.Size(167, 59);
            this.btn_inico.TabIndex = 3;
            this.btn_inico.Text = "Inicio";
            this.btn_inico.UseVisualStyleBackColor = true;
            this.btn_inico.Click += new System.EventHandler(this.btn_inico_Click);
            // 
            // pcb_subir
            // 
            this.pcb_subir.BackColor = System.Drawing.Color.Transparent;
            this.pcb_subir.BackgroundImage = global::FilePilot1.Properties.Resources.Mis_archivos;
            this.pcb_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_subir.ErrorImage = null;
            this.pcb_subir.Location = new System.Drawing.Point(972, 0);
            this.pcb_subir.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_subir.Name = "pcb_subir";
            this.pcb_subir.Size = new System.Drawing.Size(95, 78);
            this.pcb_subir.TabIndex = 27;
            this.pcb_subir.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 52);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mis documentos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FilePilot1.Properties.Resources.buscar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(518, 109);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 59);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(597, 109);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(167, 59);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvMisDocumentos
            // 
            this.dgvMisDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMisDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMisDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_nombre,
            this.dgv_fecha,
            this.Fecha});
            this.dgvMisDocumentos.Location = new System.Drawing.Point(319, 176);
            this.dgvMisDocumentos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMisDocumentos.Name = "dgvMisDocumentos";
            this.dgvMisDocumentos.ReadOnly = true;
            this.dgvMisDocumentos.RowHeadersWidth = 51;
            this.dgvMisDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMisDocumentos.Size = new System.Drawing.Size(668, 272);
            this.dgvMisDocumentos.TabIndex = 45;
            this.dgvMisDocumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_recientes_CellContentClick);
            this.dgvMisDocumentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMisDocumentos_MouseClick);
            // 
            // dgv_nombre
            // 
            this.dgv_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_nombre.FillWeight = 120F;
            this.dgv_nombre.HeaderText = "Nombre";
            this.dgv_nombre.MinimumWidth = 6;
            this.dgv_nombre.Name = "dgv_nombre";
            this.dgv_nombre.ReadOnly = true;
            // 
            // dgv_fecha
            // 
            this.dgv_fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_fecha.FillWeight = 80F;
            this.dgv_fecha.HeaderText = "Categoria";
            this.dgv_fecha.MinimumWidth = 6;
            this.dgv_fecha.Name = "dgv_fecha";
            this.dgv_fecha.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 60F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // misdocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvMisDocumentos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_subir);
            this.Controls.Add(this.pnl_botones);
            this.Name = "misdocumentos";
            this.Text = "misdocumentos";
            this.Load += new System.EventHandler(this.misdocumentos_Load);
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.PictureBox ptb_inicio;
        private System.Windows.Forms.Button btn_inico;
        private System.Windows.Forms.Button btnSubirDocumentos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pi;
        private System.Windows.Forms.Button btnRealizarRespaldos;
        private System.Windows.Forms.PictureBox pcb_subir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMisDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}