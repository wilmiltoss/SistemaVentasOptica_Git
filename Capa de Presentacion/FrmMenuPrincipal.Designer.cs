namespace Capa_de_Presentacion
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SumMenuReportes = new System.Windows.Forms.Panel();
            this.btnRptCompras = new System.Windows.Forms.Button();
            this.btnRptVenta = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.iconoRestaurar = new System.Windows.Forms.PictureBox();
            this.iconoMinimizar = new System.Windows.Forms.PictureBox();
            this.iconoMaximizar = new System.Windows.Forms.PictureBox();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.btnSide = new System.Windows.Forms.PictureBox();
            this.btnAdministradores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.SumMenuReportes.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(694, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblFecha.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblFecha.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(769, 5);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(694, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblHora.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(769, 28);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(94, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuVertical.Controls.Add(this.SumMenuReportes);
            this.MenuVertical.Controls.Add(this.btnAdministradores);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.btnVentas);
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.btnPacientes);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 5;
            // 
            // SumMenuReportes
            // 
            this.SumMenuReportes.Controls.Add(this.btnRptCompras);
            this.SumMenuReportes.Controls.Add(this.btnRptVenta);
            this.SumMenuReportes.Location = new System.Drawing.Point(45, 545);
            this.SumMenuReportes.Name = "SumMenuReportes";
            this.SumMenuReportes.Size = new System.Drawing.Size(200, 100);
            this.SumMenuReportes.TabIndex = 0;
            this.SumMenuReportes.Visible = false;
            // 
            // btnRptCompras
            // 
            this.btnRptCompras.FlatAppearance.BorderSize = 0;
            this.btnRptCompras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRptCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptCompras.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRptCompras.ForeColor = System.Drawing.Color.White;
            this.btnRptCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptCompras.Location = new System.Drawing.Point(3, 46);
            this.btnRptCompras.Name = "btnRptCompras";
            this.btnRptCompras.Size = new System.Drawing.Size(197, 40);
            this.btnRptCompras.TabIndex = 2;
            this.btnRptCompras.Text = "&Reporte Compras";
            this.btnRptCompras.UseVisualStyleBackColor = true;
            this.btnRptCompras.Click += new System.EventHandler(this.btnRptCompras_Click);
            // 
            // btnRptVenta
            // 
            this.btnRptVenta.FlatAppearance.BorderSize = 0;
            this.btnRptVenta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRptVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRptVenta.ForeColor = System.Drawing.Color.White;
            this.btnRptVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptVenta.Location = new System.Drawing.Point(0, 0);
            this.btnRptVenta.Name = "btnRptVenta";
            this.btnRptVenta.Size = new System.Drawing.Size(197, 40);
            this.btnRptVenta.TabIndex = 1;
            this.btnRptVenta.Text = "&Reporte Ventas ";
            this.btnRptVenta.UseVisualStyleBackColor = true;
            this.btnRptVenta.Click += new System.EventHandler(this.btnRptVenta_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(-7, 436);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(250, 40);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "&Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario Activo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuario.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(119, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(185, 23);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.barraTitulo.Controls.Add(this.iconoRestaurar);
            this.barraTitulo.Controls.Add(this.iconoMinimizar);
            this.barraTitulo.Controls.Add(this.iconoMaximizar);
            this.barraTitulo.Controls.Add(this.iconoCerrar);
            this.barraTitulo.Controls.Add(this.btnSide);
            this.barraTitulo.Controls.Add(this.lblUsuario);
            this.barraTitulo.Controls.Add(this.label4);
            this.barraTitulo.Controls.Add(this.lblFecha);
            this.barraTitulo.Controls.Add(this.lblHora);
            this.barraTitulo.Controls.Add(this.label3);
            this.barraTitulo.Controls.Add(this.label2);
            this.barraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.barraTitulo.TabIndex = 8;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 9;
            // 
            // iconoRestaurar
            // 
            this.iconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoRestaurar.Image = global::Capa_de_Presentacion.Properties.Resources.res;
            this.iconoRestaurar.Location = new System.Drawing.Point(979, 10);
            this.iconoRestaurar.Name = "iconoRestaurar";
            this.iconoRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoRestaurar.TabIndex = 11;
            this.iconoRestaurar.TabStop = false;
            this.iconoRestaurar.Visible = false;
            this.iconoRestaurar.Click += new System.EventHandler(this.iconoRestaurar_Click);
            // 
            // iconoMinimizar
            // 
            this.iconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMinimizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMinimizar.Image = global::Capa_de_Presentacion.Properties.Resources.minimazar;
            this.iconoMinimizar.Location = new System.Drawing.Point(953, 10);
            this.iconoMinimizar.Name = "iconoMinimizar";
            this.iconoMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMinimizar.TabIndex = 10;
            this.iconoMinimizar.TabStop = false;
            this.iconoMinimizar.Click += new System.EventHandler(this.iconoMinimizar_Click);
            // 
            // iconoMaximizar
            // 
            this.iconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMaximizar.Image")));
            this.iconoMaximizar.Location = new System.Drawing.Point(979, 10);
            this.iconoMaximizar.Name = "iconoMaximizar";
            this.iconoMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMaximizar.TabIndex = 9;
            this.iconoMaximizar.TabStop = false;
            this.iconoMaximizar.Click += new System.EventHandler(this.iconoMaximizar_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            this.iconoCerrar.Location = new System.Drawing.Point(1005, 10);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrar.TabIndex = 8;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // btnSide
            // 
            this.btnSide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSide.Image = ((System.Drawing.Image)(resources.GetObject("btnSide.Image")));
            this.btnSide.Location = new System.Drawing.Point(3, 7);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(35, 35);
            this.btnSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSide.TabIndex = 0;
            this.btnSide.TabStop = false;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // btnAdministradores
            // 
            this.btnAdministradores.FlatAppearance.BorderSize = 0;
            this.btnAdministradores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministradores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministradores.ForeColor = System.Drawing.Color.White;
            this.btnAdministradores.Image = global::Capa_de_Presentacion.Properties.Resources.empleados;
            this.btnAdministradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministradores.Location = new System.Drawing.Point(-1, 267);
            this.btnAdministradores.Name = "btnAdministradores";
            this.btnAdministradores.Size = new System.Drawing.Size(250, 40);
            this.btnAdministradores.TabIndex = 1;
            this.btnAdministradores.Text = "&Usuarios";
            this.btnAdministradores.UseVisualStyleBackColor = true;
            this.btnAdministradores.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::Capa_de_Presentacion.Properties.Resources.reportes;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(-7, 499);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(250, 40);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Text = "&Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::Capa_de_Presentacion.Properties.Resources.venta;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(-1, 313);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(250, 40);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "&Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Image = global::Capa_de_Presentacion.Properties.Resources.clientes;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(-1, 175);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(250, 40);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "&Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::Capa_de_Presentacion.Properties.Resources.producto;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(-1, 221);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(250, 40);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "&Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.MenuVertical.ResumeLayout(false);
            this.SumMenuReportes.ResumeLayout(false);
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAdministradores;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnSide;
        private System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.PictureBox iconoMinimizar;
        private System.Windows.Forms.PictureBox iconoMaximizar;
        private System.Windows.Forms.PictureBox iconoRestaurar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel SumMenuReportes;
        private System.Windows.Forms.Button btnRptCompras;
        private System.Windows.Forms.Button btnRptVenta;
    }
}