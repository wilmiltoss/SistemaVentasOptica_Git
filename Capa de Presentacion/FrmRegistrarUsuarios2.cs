using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CapaLogicaNegocio;

namespace Capa_de_Presentacion
{
    public partial class FrmRegistrarUsuarios2 : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsPefil C = new clsPefil();
        clsUsuarios U = new clsUsuarios();
        int Listado = 0;

        //validar si los campo idUsuario y usuario estan vacios p/ habilitar boton agregar
        private void Validar()
        {
            if (txtIdUsuario.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
               btnAgregar.Enabled = false;                                
            }
        }
        //valida directamente cuanto el texto esta cargado
        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        //valida directamente cuanto el texto esta cargado
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Validar();       
        }

        public FrmRegistrarUsuarios2()
        {    
            InitializeComponent();
     
        }

        private void FrmRegistrarEmpleados_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            CargarComboBox();
            txtUsuario.Focus();
            txtIdUsuario.Enabled = false;

            //inicializa los botones en false
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;


            //si el campo usuario esta distinto a vacio se bloquea el texbox idusuario
            if (txtUsuario.Text != "")
            {
                txtIdUsuario.Enabled = false;
                txtUsuario.Enabled = false;
                btnModificar.Enabled = true;
            }
        }

        //lo que va desplegar en el comboBox

        private void CargarComboBox()
        {
            if (IdC.Text.Trim() != "")
            {
                txtCargo.DisplayMember = "Descripcion";
                txtCargo.ValueMember = "IdPerfil";
                txtCargo.DataSource = C.ListarPerfil();
                txtCargo.SelectedValue = IdC.Text;
            }
            else
            {
                txtCargo.DisplayMember = "Descripcion";//se visualiza en el combo
                txtCargo.ValueMember = "IdPerfil";//lo que tomo del combo
                txtCargo.DataSource = C.ListarPerfil();
            }
        }
 
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            { 
                if (txtCargo.Text != "Seleccione")//el cargo debe ser distinto a cero
                {
                 //Valida si los campos del form estan vacios
                    if (this.txtNombre.Text.Trim() != "" && this.txtApellido.Text.Trim() != ""
                        && this.txtContrasena.Text.Trim() != "" && this.txtCI.Text.Trim() != "")
                    {

                        //copio los datos de los texbox para guardarlos en los campos
                       // U.IdUsuarios = Convert.ToInt32(txtIdUsuario.Text);
                        U.NombreUsuario = txtUsuario.Text;
                        U.Nombres = txtNombre.Text;
                        U.Apellidos = txtApellido.Text;
                        U.Contrasena = txtContrasena.Text;
                        U.IdPerfil = Convert.ToInt32(txtCargo.SelectedValue);
                        U.CI = txtCI.Text;
                        U.FechaIngreso = Convert.ToDateTime(dtmFechaIngreso.Value);
                        U.Activo = checkEstado.Checked == true;
                        U.Email = txtEmail.Text;
                        U.Direccion = txtDireccion.Text;
                        DevComponents.DotNetBar.MessageBoxEx.Show(U.RegistrarUsuario(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Limpiar();
                        Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Existen Campos Vacios, Favor completarlo", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el Cargo", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCargo.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show("Error en la carga del usuario");

               txtIdUsuario.Focus();
            }
        }

        private void Limpiar() {
            txtNombre.Clear();
            txtApellido.Clear();
            txtContrasena.Clear();
            txtCI.Clear();
            txtUsuario.Clear();
            dtmFechaIngreso.Value = DateTime.Now;
            checkEstado.Checked = false;
            txtEmail.Clear();
            txtDireccion.Clear();
            txtIdUsuario.Focus();

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void FrmRegistrarEmpleados_Activated(object sender, EventArgs e)
        {
            if (Program.IdPerfil != 0)
                txtCargo.SelectedValue = Program.IdPerfil;
            else
                checkEstado.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Registro de Empleados.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //validar solo ingreso de numeros en la celda txtIdUsuario
        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar)){
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }
        //validar solo ingreso de numeros en la celda txtCI
        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
    
                if (txtCargo.Text != "Seleccione")
                {//el cargo debe ser distinto a cero
                 //Valida si los campos del form estan vacios
                    if (this.txtUsuario.Text.Trim() != "" && this.txtNombre.Text.Trim() != "" && this.txtApellido.Text.Trim() != ""
                        && this.txtContrasena.Text.Trim() != "" && this.txtCI.Text.Trim() != "")
                    {

                        //copio los datos de los texbox para guardarlos en los campos
                        U.IdUsuarios = Convert.ToInt32(txtIdUsuario.Text);
                        U.NombreUsuario = txtUsuario.Text;
                        U.Nombres = txtNombre.Text;
                        U.Apellidos = txtApellido.Text;
                        U.Contrasena = txtContrasena.Text;
                        U.IdPerfil = Convert.ToInt32(txtCargo.SelectedValue);
                        U.CI = txtCI.Text;
                        U.FechaIngreso = Convert.ToDateTime(dtmFechaIngreso.Value);
                        U.Activo = checkEstado.Checked == true;
                        U.Email = txtEmail.Text;
                        U.Direccion = txtDireccion.Text;
                        DevComponents.DotNetBar.MessageBoxEx.Show(U.MantenimientoUsuarios(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Limpiar();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Existen Campos Vacios, Favor completarlo", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el Cargo", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCargo.Focus();
                }
            }
            catch (Exception ex)
            {
                txtUsuario.Focus();
            }
        }

    }   
}
