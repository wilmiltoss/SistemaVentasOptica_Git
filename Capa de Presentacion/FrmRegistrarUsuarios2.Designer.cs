namespace Capa_de_Presentacion
{
    partial class FrmRegistrarUsuarios2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdC = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtmFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 569);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(183, 523);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 29);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "IdUsuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "C.I.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cargo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdC);
            this.groupBox2.Controls.Add(this.txtIdUsuario);
            this.groupBox2.Controls.Add(this.checkEstado);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.txtCI);
            this.groupBox2.Controls.Add(this.txtContrasena);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtCargo);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.dtmFechaIngreso);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(108, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 480);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuarios";
            // 
            // IdC
            // 
            this.IdC.BackColor = System.Drawing.SystemColors.Control;
            this.IdC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdC.Location = new System.Drawing.Point(242, 37);
            this.IdC.Name = "IdC";
            this.IdC.Size = new System.Drawing.Size(20, 14);
            this.IdC.TabIndex = 29;
            this.IdC.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(11, 20);
            this.txtIdUsuario.MaxLength = 8;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(64, 21);
            this.txtIdUsuario.TabIndex = 1;
            this.txtIdUsuario.Text = "0";
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(11, 363);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(15, 14);
            this.checkEstado.TabIndex = 9;
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(11, 437);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(263, 21);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(11, 279);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(136, 21);
            this.txtCI.TabIndex = 7;
            this.txtCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCI_KeyPress);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(11, 187);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(136, 21);
            this.txtContrasena.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(11, 67);
            this.txtUsuario.MaxLength = 8;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(136, 21);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 21);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCargo
            // 
            this.txtCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCargo.FormattingEnabled = true;
            this.txtCargo.Location = new System.Drawing.Point(11, 233);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(136, 23);
            this.txtCargo.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 397);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 21);
            this.txtEmail.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(11, 146);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(263, 21);
            this.txtApellido.TabIndex = 4;
            // 
            // dtmFechaIngreso
            // 
            this.dtmFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaIngreso.Location = new System.Drawing.Point(11, 320);
            this.dtmFechaIngreso.Name = "dtmFechaIngreso";
            this.dtmFechaIngreso.Size = new System.Drawing.Size(171, 21);
            this.dtmFechaIngreso.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(309, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 29);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(50, 523);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 29);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // timer1
            // 
            // 
            // FrmRegistrarUsuarios2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(481, 614);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarUsuarios2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.FrmRegistrarEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.DateTimePicker dtmFechaIngreso;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox txtCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtCI;
        public System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.TextBox IdC;
    }
}