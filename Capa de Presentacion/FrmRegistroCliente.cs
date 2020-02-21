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
    public partial class FrmRegistroCliente : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCliente C = new clsCliente();
        int Listado = 0;

        //validar si los campo nombre y usuario estan vacios p/ habilitar boton agregar
        private void Validar()
        {
            if (txtCI.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
        //valida directamente cuanto el texto esta cargado

        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            CargarComboBoxPais();
            txtNombres.Focus();
            txtIdCliente.Enabled = false;
  

            //inicializa los botones en false
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;

            //si el campo cliente esta distinto a vacio se bloquea el texbox y habilita el boton modificar
            if (txtCI.Text != "" )
            {
                txtIdCliente.Enabled = false;
                txtCI.Enabled = false;
                btnModificar.Enabled = true;
            }
        }


        public void CargarComboBoxPais()
        {
              txtPais.DataSource = C.ListadoPais();
            txtPais.DisplayMember = "Descripcion"; //se visualiza en el combo
            txtPais.ValueMember = "IdPais";  //lo que tomo del combo
        }
   

        //--VALIDACION DE INGRESO DE DATOS DE FORMULARIO CLIENTE
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //selecciono el id del combobox para cargarlo en el texbox bakcup
                txtPaisInvisible.Text = Convert.ToString(txtPais.SelectedIndex);
                if (txtNombres.Text.Trim() != "")
                {
                    if (txtNombres.Text.Trim() != "")
                    {
                        if (txtApellidos.Text.Trim() != "")
                        {
                            if (txtCI.Text.Trim() != "")
                            {
                                if (txtPaisInvisible.Text.Trim() != "0")
                                {
                                    if (txtTelefono.Text.Trim() != "")
                                    {
                                        if (Program.Evento == 0)
                                        {
                                            //copio los datos de los texbox para guardarlos en los campos
                                            // C.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                                            C.Nombres = txtNombres.Text;
                                            C.Apellidos = txtApellidos.Text;
                                            C.CI = txtCI.Text;
                                            C.Ruc = txtRuc.Text;
                                            C.Direccion = txtDireccion.Text;
                                            C.Telefono = txtTelefono.Text;
                                            C.FechaIngreso = Convert.ToDateTime(dtmFechaIngreso.Value);
                                            C.Email = txtEmail.Text;
                                            C.Pais = Convert.ToInt32(txtPaisInvisible.Text);
                                            DevComponents.DotNetBar.MessageBoxEx.Show(C.RegistrarCliente(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Limpiar();
                                            Close();
                                        }
                                        /* else
                                         {
                                             C.CI = txtIdCliente.Text;
                                             C.Apellidos = txtCI.Text;
                                             C.Nombres = txtNombres.Text;
                                             C.Direccion = txtApellidos.Text;
                                             C.Telefono = txtDireccion.Text;
                                             C.Email = txtEmail.Text;
                                             DevComponents.DotNetBar.MessageBoxEx.Show(C.ActualizarCliente(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                             Limpiar();
                                         Close();
                                     }*/
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese N° de Teléfono o Celular.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtTelefono.Focus();
                                    }
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor seleccione el Pais", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtPais.Focus();
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese la Cedula del Cliente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtCI.Focus();
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Apellido(s) del Cliente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtApellidos.Focus();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Nombre(s) del Cliente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombres.Focus();
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese N° de Cliente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdCliente.Focus();
                }
            }catch
            {
                MessageBoxEx.Show("Error en el registro del Cliente");
            }
       }

        private void Limpiar() {
            txtIdCliente.Text = "";
            txtCI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtRuc.Clear();
            dtmFechaIngreso.Value = DateTime.Now;
            txtEmail.Clear();
            txtPaisInvisible.Clear();
            txtIdCliente.Focus();
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmRegistroCliente_Activated(object sender, EventArgs e)
        {
            txtNombres.Focus();
        }
        //cuando el texto es cambiado se valida
        private void txtCI_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        //valida solo numeros en el texbox
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
                //selecciono el id del combobox para cargarlo en la grilla
                txtPaisInvisible.Text = Convert.ToString(txtPais.SelectedIndex);
                if (txtPaisInvisible.Text != "0")
                {//el cargo debe ser distinto a cero
                 //Valida si los campos del form estan vacios
                    if (this.txtNombres.Text.Trim() != "" && this.txtApellidos.Text.Trim() != "" && this.txtCI.Text.Trim() != ""
                        && this.txtTelefono.Text.Trim() != "" && this.txtCI.Text.Trim() != "")
                    {

                        //copio los datos de los texbox para guardarlos en los campos
                        C.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                        C.Nombres = txtNombres.Text;
                        C.Nombres = txtNombres.Text;
                        C.Apellidos = txtApellidos.Text;
                        C.CI = txtCI.Text;
                        C.Ruc = txtRuc.Text;
                        C.Direccion = txtDireccion.Text;
                        C.Telefono = txtTelefono.Text;
                        C.FechaIngreso = Convert.ToDateTime(dtmFechaIngreso.Value);
                        C.Email = txtEmail.Text;
                        C.Pais = Convert.ToInt32(txtPaisInvisible.Text);
   
                        DevComponents.DotNetBar.MessageBoxEx.Show(C.ActualizarCliente(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                    MessageBox.Show("Seleccione el Pais", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPais.Focus();
                }
            }
            catch (Exception ex)
            {
                txtNombres.Focus();
            }
        }
    }
}
