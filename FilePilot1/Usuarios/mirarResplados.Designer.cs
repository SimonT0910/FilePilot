namespace FilePilot1
{
    partial class respaldos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRestauracion = new System.Windows.Forms.DataGridView();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btn_inico = new System.Windows.Forms.Button();
            this.ptb_inicio = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcb_subir = new System.Windows.Forms.PictureBox();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idRespaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestauracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 65);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mirar respaldos";
            // 
            // dgvRestauracion
            // 
            this.dgvRestauracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestauracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.idRespaldo,
            this.Nombre,
            this.Categoria,
            this.Fecha});
            this.dgvRestauracion.Location = new System.Drawing.Point(51, 104);
            this.dgvRestauracion.Name = "dgvRestauracion";
            this.dgvRestauracion.RowHeadersWidth = 51;
            this.dgvRestauracion.RowTemplate.Height = 24;
            this.dgvRestauracion.Size = new System.Drawing.Size(758, 351);
            this.dgvRestauracion.TabIndex = 32;
            this.dgvRestauracion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(916, 411);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(167, 59);
            this.btnRestaurar.TabIndex = 38;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btn_inico
            // 
            this.btn_inico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inico.Location = new System.Drawing.Point(914, 311);
            this.btn_inico.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inico.Name = "btn_inico";
            this.btn_inico.Size = new System.Drawing.Size(167, 59);
            this.btn_inico.TabIndex = 39;
            this.btn_inico.Text = "Inicio";
            this.btn_inico.UseVisualStyleBackColor = true;
            this.btn_inico.Click += new System.EventHandler(this.btn_inico_Click);
            // 
            // ptb_inicio
            // 
            this.ptb_inicio.BackColor = System.Drawing.Color.White;
            this.ptb_inicio.BackgroundImage = global::FilePilot1.Properties.Resources.inicio;
            this.ptb_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_inicio.Location = new System.Drawing.Point(835, 311);
            this.ptb_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_inicio.Name = "ptb_inicio";
            this.ptb_inicio.Size = new System.Drawing.Size(71, 59);
            this.ptb_inicio.TabIndex = 40;
            this.ptb_inicio.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FilePilot1.Properties.Resources.restaurar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(837, 411);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 59);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pcb_subir
            // 
            this.pcb_subir.BackColor = System.Drawing.Color.Transparent;
            this.pcb_subir.BackgroundImage = global::FilePilot1.Properties.Resources.mirar_respaldos1;
            this.pcb_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_subir.ErrorImage = null;
            this.pcb_subir.Location = new System.Drawing.Point(998, -1);
            this.pcb_subir.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_subir.Name = "pcb_subir";
            this.pcb_subir.Size = new System.Drawing.Size(95, 78);
            this.pcb_subir.TabIndex = 31;
            this.pcb_subir.TabStop = false;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.MinimumWidth = 6;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Width = 80;
            // 
            // idRespaldo
            // 
            this.idRespaldo.HeaderText = "ID";
            this.idRespaldo.MinimumWidth = 6;
            this.idRespaldo.Name = "idRespaldo";
            this.idRespaldo.Visible = false;
            this.idRespaldo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del archivo";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha del respaldo";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 200;
            // 
            // respaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1094, 493);
            this.Controls.Add(this.ptb_inicio);
            this.Controls.Add(this.btn_inico);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvRestauracion);
            this.Controls.Add(this.pcb_subir);
            this.Controls.Add(this.label1);
            this.Name = "respaldos";
            this.Text = "mirarResplados";
            this.Load += new System.EventHandler(this.mirarResplados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestauracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_subir;
        private System.Windows.Forms.DataGridView dgvRestauracion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.PictureBox ptb_inicio;
        private System.Windows.Forms.Button btn_inico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRespaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}