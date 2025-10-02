namespace FilePilot1
{
    partial class movimientos
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
            this.btn_inico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_subir = new System.Windows.Forms.PictureBox();
            this.ptb_inicio = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inico
            // 
            this.btn_inico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inico.Location = new System.Drawing.Point(92, 475);
            this.btn_inico.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inico.Name = "btn_inico";
            this.btn_inico.Size = new System.Drawing.Size(167, 59);
            this.btn_inico.TabIndex = 8;
            this.btn_inico.Text = "Inicio";
            this.btn_inico.UseVisualStyleBackColor = true;
            this.btn_inico.Click += new System.EventHandler(this.btn_inico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 65);
            this.label1.TabIndex = 26;
            this.label1.Text = "Movimientos del sistema";
            // 
            // pcb_subir
            // 
            this.pcb_subir.BackColor = System.Drawing.Color.Transparent;
            this.pcb_subir.BackgroundImage = global::FilePilot1.Properties.Resources.movimientos1;
            this.pcb_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_subir.ErrorImage = null;
            this.pcb_subir.Location = new System.Drawing.Point(999, -1);
            this.pcb_subir.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_subir.Name = "pcb_subir";
            this.pcb_subir.Size = new System.Drawing.Size(95, 78);
            this.pcb_subir.TabIndex = 27;
            this.pcb_subir.TabStop = false;
            // 
            // ptb_inicio
            // 
            this.ptb_inicio.BackColor = System.Drawing.Color.White;
            this.ptb_inicio.BackgroundImage = global::FilePilot1.Properties.Resources.administrador;
            this.ptb_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_inicio.Location = new System.Drawing.Point(13, 475);
            this.ptb_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_inicio.Name = "ptb_inicio";
            this.ptb_inicio.Size = new System.Drawing.Size(71, 59);
            this.ptb_inicio.TabIndex = 9;
            this.ptb_inicio.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.correo,
            this.tipo,
            this.fecha});
            this.dataGridView1.Location = new System.Drawing.Point(144, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 278);
            this.dataGridView1.TabIndex = 28;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(167, 118);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(354, 34);
            this.txt_busqueda.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 38);
            this.label2.TabIndex = 33;
            this.label2.Text = "Buscar:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(699, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 37);
            this.comboBox1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 38);
            this.label3.TabIndex = 36;
            this.label3.Text = "Filtrar:";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre de usuario";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo de movimiento";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.Width = 200;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de realizacion del movimiento";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 200;
            // 
            // movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1094, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcb_subir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_inicio);
            this.Controls.Add(this.btn_inico);
            this.Name = "movimientos";
            this.Text = "movimientos";
            this.Load += new System.EventHandler(this.movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_inicio;
        private System.Windows.Forms.Button btn_inico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_subir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}