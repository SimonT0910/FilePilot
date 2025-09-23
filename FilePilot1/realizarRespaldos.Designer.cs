namespace FilePilot1
{
    partial class realizarRespaldos
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
            this.btnRespaldarTodo = new System.Windows.Forms.Button();
            this.btnRespaldar = new System.Windows.Forms.Button();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_inicio = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcb_subir = new System.Windows.Forms.PictureBox();
            this.dgvMirarRespaldos = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMirarRespaldos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 65);
            this.label1.TabIndex = 33;
            this.label1.Text = "Realizar respaldos";
            // 
            // btnRespaldarTodo
            // 
            this.btnRespaldarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespaldarTodo.Location = new System.Drawing.Point(918, 309);
            this.btnRespaldarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespaldarTodo.Name = "btnRespaldarTodo";
            this.btnRespaldarTodo.Size = new System.Drawing.Size(167, 59);
            this.btnRespaldarTodo.TabIndex = 43;
            this.btnRespaldarTodo.Text = "Respaldar todo";
            this.btnRespaldarTodo.UseVisualStyleBackColor = true;
            this.btnRespaldarTodo.Click += new System.EventHandler(this.btnRespaldarTodo_Click);
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespaldar.Location = new System.Drawing.Point(920, 409);
            this.btnRespaldar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(167, 59);
            this.btnRespaldar.TabIndex = 42;
            this.btnRespaldar.Text = "Respaldar";
            this.btnRespaldar.UseVisualStyleBackColor = true;
            this.btnRespaldar.Click += new System.EventHandler(this.btnRespaldar_Click);
            // 
            // btnRegreso
            // 
            this.btnRegreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegreso.Location = new System.Drawing.Point(918, 218);
            this.btnRegreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(167, 59);
            this.btnRegreso.TabIndex = 45;
            this.btnRegreso.Text = "Mis documentos";
            this.btnRegreso.UseVisualStyleBackColor = true;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::FilePilot1.Properties.Resources.Mis_archivos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(839, 218);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 59);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_inicio
            // 
            this.ptb_inicio.BackColor = System.Drawing.Color.White;
            this.ptb_inicio.BackgroundImage = global::FilePilot1.Properties.Resources.respaldar_todo;
            this.ptb_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_inicio.Location = new System.Drawing.Point(839, 309);
            this.ptb_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_inicio.Name = "ptb_inicio";
            this.ptb_inicio.Size = new System.Drawing.Size(71, 59);
            this.ptb_inicio.TabIndex = 44;
            this.ptb_inicio.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FilePilot1.Properties.Resources.respaldar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(841, 409);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 59);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pcb_subir
            // 
            this.pcb_subir.BackColor = System.Drawing.Color.Transparent;
            this.pcb_subir.BackgroundImage = global::FilePilot1.Properties.Resources.realizar_respaldos1;
            this.pcb_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_subir.ErrorImage = null;
            this.pcb_subir.Location = new System.Drawing.Point(1003, 9);
            this.pcb_subir.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_subir.Name = "pcb_subir";
            this.pcb_subir.Size = new System.Drawing.Size(95, 78);
            this.pcb_subir.TabIndex = 35;
            this.pcb_subir.TabStop = false;
            // 
            // dgvMirarRespaldos
            // 
            this.dgvMirarRespaldos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMirarRespaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMirarRespaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMirarRespaldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion,
            this.idDocumento,
            this.Nombre,
            this.Categoria,
            this.Fecha});
            this.dgvMirarRespaldos.Location = new System.Drawing.Point(37, 96);
            this.dgvMirarRespaldos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMirarRespaldos.Name = "dgvMirarRespaldos";
            this.dgvMirarRespaldos.ReadOnly = true;
            this.dgvMirarRespaldos.RowHeadersWidth = 51;
            this.dgvMirarRespaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMirarRespaldos.Size = new System.Drawing.Size(766, 383);
            this.dgvMirarRespaldos.TabIndex = 47;
            this.dgvMirarRespaldos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMirarRespaldos_CellContentClick);
            this.dgvMirarRespaldos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMirarRespaldos_CellValueChanged);
            this.dgvMirarRespaldos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMirarRespaldos_CurrentCellDirtyStateChanged);
            // 
            // seleccion
            // 
            this.seleccion.HeaderText = "Seleccion";
            this.seleccion.MinimumWidth = 6;
            this.seleccion.Name = "seleccion";
            this.seleccion.ReadOnly = true;
            this.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idDocumento
            // 
            this.idDocumento.HeaderText = "ID";
            this.idDocumento.MinimumWidth = 6;
            this.idDocumento.Name = "idDocumento";
            this.idDocumento.ReadOnly = true;
            this.idDocumento.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.FillWeight = 120F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.FillWeight = 80F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 60F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // realizarRespaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1098, 492);
            this.Controls.Add(this.dgvMirarRespaldos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegreso);
            this.Controls.Add(this.ptb_inicio);
            this.Controls.Add(this.btnRespaldarTodo);
            this.Controls.Add(this.btnRespaldar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcb_subir);
            this.Controls.Add(this.label1);
            this.Name = "realizarRespaldos";
            this.Text = "realizarRespaldos";
            this.Load += new System.EventHandler(this.realizarRespaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMirarRespaldos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_subir;
        private System.Windows.Forms.PictureBox ptb_inicio;
        private System.Windows.Forms.Button btnRespaldarTodo;
        private System.Windows.Forms.Button btnRespaldar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegreso;
        private System.Windows.Forms.DataGridView dgvMirarRespaldos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}