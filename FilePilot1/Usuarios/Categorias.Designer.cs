namespace FilePilot1
{
    partial class Categorias
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
            this.btnEliminarCate = new System.Windows.Forms.Button();
            this.btnAgregarCate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_inicio = new System.Windows.Forms.PictureBox();
            this.btn_inico = new System.Windows.Forms.Button();
            this.pcb_subir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_botones.Controls.Add(this.btnEliminarCate);
            this.pnl_botones.Controls.Add(this.btnAgregarCate);
            this.pnl_botones.Controls.Add(this.pictureBox2);
            this.pnl_botones.Controls.Add(this.pictureBox1);
            this.pnl_botones.Controls.Add(this.ptb_inicio);
            this.pnl_botones.Controls.Add(this.btn_inico);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(200, 450);
            this.pnl_botones.TabIndex = 21;
            // 
            // btnEliminarCate
            // 
            this.btnEliminarCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCate.Location = new System.Drawing.Point(62, 375);
            this.btnEliminarCate.Name = "btnEliminarCate";
            this.btnEliminarCate.Size = new System.Drawing.Size(125, 48);
            this.btnEliminarCate.TabIndex = 10;
            this.btnEliminarCate.Text = "Eliminar Categoria";
            this.btnEliminarCate.UseVisualStyleBackColor = true;
            this.btnEliminarCate.Click += new System.EventHandler(this.btnEliminarCate_Click);
            // 
            // btnAgregarCate
            // 
            this.btnAgregarCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCate.Location = new System.Drawing.Point(62, 195);
            this.btnAgregarCate.Name = "btnAgregarCate";
            this.btnAgregarCate.Size = new System.Drawing.Size(125, 48);
            this.btnAgregarCate.TabIndex = 9;
            this.btnAgregarCate.Text = "Agregar nueva categoria";
            this.btnAgregarCate.UseVisualStyleBackColor = true;
            this.btnAgregarCate.Click += new System.EventHandler(this.btnAgregarCate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::FilePilot1.Properties.Resources.eliminar_categoria;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 48);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::FilePilot1.Properties.Resources.agregar_categoria;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_inicio
            // 
            this.ptb_inicio.BackColor = System.Drawing.Color.White;
            this.ptb_inicio.BackgroundImage = global::FilePilot1.Properties.Resources.inicio;
            this.ptb_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_inicio.Location = new System.Drawing.Point(3, 20);
            this.ptb_inicio.Name = "ptb_inicio";
            this.ptb_inicio.Size = new System.Drawing.Size(53, 48);
            this.ptb_inicio.TabIndex = 7;
            this.ptb_inicio.TabStop = false;
            // 
            // btn_inico
            // 
            this.btn_inico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inico.Location = new System.Drawing.Point(62, 20);
            this.btn_inico.Name = "btn_inico";
            this.btn_inico.Size = new System.Drawing.Size(125, 48);
            this.btn_inico.TabIndex = 3;
            this.btn_inico.Text = "Inicio";
            this.btn_inico.UseVisualStyleBackColor = true;
            this.btn_inico.Click += new System.EventHandler(this.btn_inico_Click);
            // 
            // pcb_subir
            // 
            this.pcb_subir.BackColor = System.Drawing.Color.Transparent;
            this.pcb_subir.BackgroundImage = global::FilePilot1.Properties.Resources.categoria;
            this.pcb_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_subir.ErrorImage = null;
            this.pcb_subir.Location = new System.Drawing.Point(729, 0);
            this.pcb_subir.Name = "pcb_subir";
            this.pcb_subir.Size = new System.Drawing.Size(71, 63);
            this.pcb_subir.TabIndex = 27;
            this.pcb_subir.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 52);
            this.label1.TabIndex = 28;
            this.label1.Text = "Categorias";
            // 
            // flpCategorias
            // 
            this.flpCategorias.AutoScroll = true;
            this.flpCategorias.Location = new System.Drawing.Point(226, 77);
            this.flpCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpCategorias.Name = "flpCategorias";
            this.flpCategorias.Size = new System.Drawing.Size(565, 363);
            this.flpCategorias.TabIndex = 43;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_subir);
            this.Controls.Add(this.pnl_botones);
            this.Controls.Add(this.flpCategorias);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_subir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.PictureBox ptb_inicio;
        private System.Windows.Forms.Button btn_inico;
        private System.Windows.Forms.Button btnEliminarCate;
        private System.Windows.Forms.Button btnAgregarCate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcb_subir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpCategorias;
    }
}