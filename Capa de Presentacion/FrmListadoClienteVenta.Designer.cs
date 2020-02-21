namespace Capa_de_Presentacion
{
    partial class FrmListadoClienteVenta
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
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(244, 12);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(488, 21);
            this.txtBuscarCliente.TabIndex = 3;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por Nombre o Apellidos:";
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(708, 412);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            this.FECHAINGRESO.Visible = false;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = false;
            this.EMAIL.Width = 110;
            // 
            // PAIS
            // 
            this.PAIS.HeaderText = "Pais";
            this.PAIS.Name = "PAIS";
            this.PAIS.Visible = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(457, 490);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(166, 23);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "&Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(656, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmListadoClienteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(770, 536);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmListadoClienteVenta";
            this.Text = "LISTADO DE CLIENTES";
            this.Load += new System.EventHandler(this.FrmListadoClienteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
    }
}