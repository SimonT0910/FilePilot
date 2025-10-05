namespace FilePilot1
{
    partial class frm_Admin
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pcb_categorias = new System.Windows.Forms.PictureBox();
            this.pcb_respaldos = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcb_Subir = new System.Windows.Forms.PictureBox();
            this.pcb_documentos = new System.Windows.Forms.PictureBox();
            this.btnRespaldos = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_recientes = new System.Windows.Forms.Label();
            this.dvgAdmin = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_categorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_respaldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Subir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_botones.Controls.Add(this.pictureBox2);
            this.pnl_botones.Controls.Add(this.btnCrear);
            this.pnl_botones.Controls.Add(this.pcb_categorias);
            this.pnl_botones.Controls.Add(this.pcb_respaldos);
            this.pnl_botones.Controls.Add(this.pictureBox3);
            this.pnl_botones.Controls.Add(this.pcb_Subir);
            this.pnl_botones.Controls.Add(this.pcb_documentos);
            this.pnl_botones.Controls.Add(this.btnRespaldos);
            this.pnl_botones.Controls.Add(this.btn_cerrar);
            this.pnl_botones.Controls.Add(this.btnVerUsuarios);
            this.pnl_botones.Controls.Add(this.btnRestaurar);
            this.pnl_botones.Controls.Add(this.btnMovimientos);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_botones.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(267, 646);
            this.pnl_botones.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::FilePilot1.Properties.Resources.crearAdministrador;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(5, 458);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 59);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Location = new System.Drawing.Point(84, 458);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(167, 59);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear administrador";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pcb_categorias
            // 
            this.pcb_categorias.BackColor = System.Drawing.Color.White;
            this.pcb_categorias.BackgroundImage = global::FilePilot1.Properties.Resources.restaurar;
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
            this.pcb_respaldos.BackgroundImage = global::FilePilot1.Properties.Resources.ver_usuarios;
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
            this.pictureBox3.Location = new System.Drawing.Point(5, 562);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 59);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pcb_Subir
            // 
            this.pcb_Subir.BackColor = System.Drawing.Color.White;
            this.pcb_Subir.BackgroundImage = global::FilePilot1.Properties.Resources.crear_respaldo1;
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
            this.pcb_documentos.BackgroundImage = global::FilePilot1.Properties.Resources.movimientos;
            this.pcb_documentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_documentos.ErrorImage = null;
            this.pcb_documentos.Location = new System.Drawing.Point(5, 30);
            this.pcb_documentos.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_documentos.Name = "pcb_documentos";
            this.pcb_documentos.Size = new System.Drawing.Size(71, 59);
            this.pcb_documentos.TabIndex = 5;
            this.pcb_documentos.TabStop = false;
            // 
            // btnRespaldos
            // 
            this.btnRespaldos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespaldos.Location = new System.Drawing.Point(84, 130);
            this.btnRespaldos.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespaldos.Name = "btnRespaldos";
            this.btnRespaldos.Size = new System.Drawing.Size(167, 59);
            this.btnRespaldos.TabIndex = 4;
            this.btnRespaldos.Text = "Crear respaldos";
            this.btnRespaldos.UseVisualStyleBackColor = true;
            this.btnRespaldos.Click += new System.EventHandler(this.btnRespaldos_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Location = new System.Drawing.Point(84, 562);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(167, 59);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar sesion";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerUsuarios.Location = new System.Drawing.Point(84, 350);
            this.btnVerUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(167, 59);
            this.btnVerUsuarios.TabIndex = 2;
            this.btnVerUsuarios.Text = "Ver usuarios";
            this.btnVerUsuarios.UseVisualStyleBackColor = true;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(84, 240);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(167, 59);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimientos.Location = new System.Drawing.Point(84, 30);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(167, 59);
            this.btnMovimientos.TabIndex = 0;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 68);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sistema de administrador";
            // 
            // lbl_recientes
            // 
            this.lbl_recientes.AutoSize = true;
            this.lbl_recientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recientes.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recientes.Location = new System.Drawing.Point(302, 160);
            this.lbl_recientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recientes.Name = "lbl_recientes";
            this.lbl_recientes.Size = new System.Drawing.Size(262, 29);
            this.lbl_recientes.TabIndex = 23;
            this.lbl_recientes.Text = "Movimientos recientes:";
            // 
            // dvgAdmin
            // 
            this.dvgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.usuario,
            this.tipo});
            this.dvgAdmin.Location = new System.Drawing.Point(279, 227);
            this.dvgAdmin.Name = "dvgAdmin";
            this.dvgAdmin.RowHeadersWidth = 51;
            this.dvgAdmin.RowTemplate.Height = 24;
            this.dvgAdmin.Size = new System.Drawing.Size(809, 278);
            this.dvgAdmin.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FilePilot1.Properties.Resources.administrador;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(997, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 99);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de realizacion del movimiento";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 200;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.Width = 200;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo de movimiento";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.Width = 300;
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1100, 646);
            this.Controls.Add(this.dvgAdmin);
            this.Controls.Add(this.lbl_recientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_botones);
            this.Name = "frm_Admin";
            this.Text = "frm_Admin";
            this.Load += new System.EventHandler(this.frm_Admin_Load);
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_categorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_respaldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Subir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.PictureBox pcb_categorias;
        private System.Windows.Forms.PictureBox pcb_respaldos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pcb_Subir;
        private System.Windows.Forms.PictureBox pcb_documentos;
        private System.Windows.Forms.Button btnRespaldos;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_recientes;
        private System.Windows.Forms.DataGridView dvgAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}