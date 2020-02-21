namespace Capa_de_Presentacion
{
    partial class FrmRegistroProductos
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.IdC = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPCostoIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPVenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(25, 172);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(292, 21);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(25, 229);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(292, 21);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha Registro";
            // 
            // dtmFechaRegistro
            // 
            this.dtmFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaRegistro.Location = new System.Drawing.Point(25, 287);
            this.dtmFechaRegistro.Name = "dtmFechaRegistro";
            this.dtmFechaRegistro.Size = new System.Drawing.Size(140, 21);
            this.dtmFechaRegistro.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(25, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 27);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(271, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(25, 112);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(190, 23);
            this.cbxCategoria.TabIndex = 2;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(230, 112);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(87, 27);
            this.btnCategoria.TabIndex = 3;
            this.btnCategoria.Text = "&Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // IdC
            // 
            this.IdC.BackColor = System.Drawing.SystemColors.Control;
            this.IdC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdC.Location = new System.Drawing.Point(362, 20);
            this.IdC.Name = "IdC";
            this.IdC.Size = new System.Drawing.Size(20, 14);
            this.IdC.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(25, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(48, 21);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Controls.Add(this.IdC);
            this.groupBox1.Controls.Add(this.btnCategoria);
            this.groupBox1.Controls.Add(this.cbxCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtmFechaRegistro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 450);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Productos";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(25, 344);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(199, 23);
            this.cmbProveedor.TabIndex = 27;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(25, 405);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(89, 21);
            this.txtStock.TabIndex = 9;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Proveedor";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(22, 35);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 16);
            this.Codigo.TabIndex = 19;
            this.Codigo.Text = "&Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "P. Costo IVA";
            // 
            // txtPCostoIVA
            // 
            this.txtPCostoIVA.Location = new System.Drawing.Point(25, 47);
            this.txtPCostoIVA.Name = "txtPCostoIVA";
            this.txtPCostoIVA.Size = new System.Drawing.Size(80, 21);
            this.txtPCostoIVA.TabIndex = 10;
            this.txtPCostoIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPCostoIVA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(133, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "P. Venta";
            // 
            // txtPVenta
            // 
            this.txtPVenta.Location = new System.Drawing.Point(136, 47);
            this.txtPVenta.Name = "txtPVenta";
            this.txtPVenta.Size = new System.Drawing.Size(98, 21);
            this.txtPVenta.TabIndex = 11;
            this.txtPVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPVenta_KeyPress_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPCostoIVA);
            this.groupBox2.Controls.Add(this.txtPVenta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(36, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Precios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Location = new System.Drawing.Point(36, 605);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 84);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(147, 32);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 27);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmRegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(465, 718);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmRegistroProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro Productos";
            this.Load += new System.EventHandler(this.FrmRegistroProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCategoria;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.DateTimePicker dtmFechaRegistro;
        public System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.TextBox IdC;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPCostoIVA;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.ComboBox cmbProveedor;
    }
}