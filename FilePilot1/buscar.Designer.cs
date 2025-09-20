namespace FilePilot1
{
    partial class buscar
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
            this.pcb_subir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.dgv_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 65);
            this.label1.TabIndex = 29;
            this.label1.Text = "Busqueda de documentos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pcb_subir
            // 
            this.pcb_subir.BackColor = System.Drawing.Color.Transparent;
            this.pcb_subir.BackgroundImage = global::FilePilot1.Properties.Resources.buscar1;
            this.pcb_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_subir.ErrorImage = null;
            this.pcb_subir.Location = new System.Drawing.Point(999, 2);
            this.pcb_subir.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_subir.Name = "pcb_subir";
            this.pcb_subir.Size = new System.Drawing.Size(95, 78);
            this.pcb_subir.TabIndex = 30;
            this.pcb_subir.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(422, 106);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(408, 34);
            this.txt_busqueda.TabIndex = 32;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_nombre,
            this.dgv_fecha,
            this.Fecha});
            this.dgvBuscar.Location = new System.Drawing.Point(134, 167);
            this.dgvBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.ReadOnly = true;
            this.dgvBuscar.RowHeadersWidth = 51;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(799, 385);
            this.dgvBuscar.TabIndex = 46;
            this.dgvBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_buscar_CellContentClick);
            this.dgvBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvbuscar_MouseClick);
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
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(796, 596);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(137, 43);
            this.btn_regresar.TabIndex = 50;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1095, 681);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcb_subir);
            this.Controls.Add(this.label1);
            this.Name = "buscar";
            this.Text = "Buscar:";
            this.Load += new System.EventHandler(this.buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_subir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btn_regresar;
    }
}