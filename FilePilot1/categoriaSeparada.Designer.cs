namespace FilePilot1
{
    partial class categoriaSeparada
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dvgCategorias = new System.Windows.Forms.DataGridView();
            this.dgv_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(447, 9);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(174, 65);
            this.lblCategoria.TabIndex = 29;
            this.lblCategoria.Text = "Diana";
            // 
            // dvgCategorias
            // 
            this.dvgCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_nombre,
            this.dgv_fecha,
            this.Fecha});
            this.dvgCategorias.Location = new System.Drawing.Point(164, 78);
            this.dvgCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dvgCategorias.Name = "dvgCategorias";
            this.dvgCategorias.ReadOnly = true;
            this.dvgCategorias.RowHeadersWidth = 51;
            this.dvgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCategorias.Size = new System.Drawing.Size(799, 419);
            this.dvgCategorias.TabIndex = 47;
            this.dvgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCategorias_CellContentClick);
            this.dvgCategorias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvgCategorias_MouseClick);
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
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(826, 533);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(137, 43);
            this.btnRegresar.TabIndex = 48;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // categoriaSeparada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1095, 601);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dvgCategorias);
            this.Controls.Add(this.lblCategoria);
            this.Name = "categoriaSeparada";
            this.Text = "categoriaSeparada";
            this.Load += new System.EventHandler(this.categoriaSeparada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dvgCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnRegresar;
    }
}