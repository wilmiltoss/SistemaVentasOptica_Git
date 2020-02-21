namespace Capa_de_Presentacion
{
    partial class FrmListadoClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtSumaRegistros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Nombre o Apellidos:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(300, 22);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(488, 21);
            this.txtBuscarCliente.TabIndex = 1;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(53, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 434);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NOMBRE,
            this.APELLIDO,
            this.CI,
            this.RUC,
            this.DIRECCION,
            this.TELEFONO,
            this.FECHAINGRESO,
            this.EMAIL,
            this.PAIS});
            this.dataGridView1.Location = new System.Drawing.Point(25, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(891, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdCliente.FillWeight = 30F;
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 41;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombres";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "Apellidos";
            this.APELLIDO.Name = "APELLIDO";
            // 
            // CI
            // 
            this.CI.HeaderText = "C.I.";
            this.CI.Name = "CI";
            // 
            // RUC
            // 
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "Direccion";
            this.DIRECCION.Name = "DIRECCION";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "Telefono";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // FECHAINGRESO
            // 
            this.FECHAINGRESO.HeaderText = "Fecha Ingreso";
            this.FECHAINGRESO.Name = "FECHAINGRESO";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 110;
            // 
            // PAIS
            // 
            this.PAIS.HeaderText = "Pais";
            this.PAIS.Name = "PAIS";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(811, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(895, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(895, 518);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(796, 518);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtSumaRegistros
            // 
            this.txtSumaRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaRegistros.Location = new System.Drawing.Point(216, 518);
            this.txtSumaRegistros.Name = "txtSumaRegistros";
            this.txtSumaRegistros.Size = new System.Drawing.Size(43, 24);
            this.txtSumaRegistros.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad de Registros :";
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1003, 600);
            this.Controls.Add(this.txtSumaRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListado de Clientes";
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtSumaRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAIS;
    }
}