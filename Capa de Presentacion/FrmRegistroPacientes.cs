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
    public partial class FrmRegistroPacientes : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCliente C = new clsCliente();

        public FrmRegistroPacientes()
        {
            InitializeComponent();
        }

        //--VALIDACION DE INGRESO DE DATOS DE FORMULARIO CLIENTE
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCi.Text.Trim() != "")
            {
                if (txtApellidos.Text.Trim() != "")
                {
                    if (txtNombres.Text.Trim() != "")
                    {
                        if (txtDireccion.Text.Trim() != "")
                        {
                            if (txtTelefono.Text.Trim() != "")
                            {
                                if (Program.Evento == 0)
                                {
                                    C.Ci = txtCi.Text;
                                    C.Apellidos = txtApellidos.Text;
                                    C.Nombres = txtNombres.Text;
                                    C.Direccion = txtDireccion.Text;
                                    C.Telefono = txtTelefono.Text;
                                    C.Email = txtEmail.Text;
                                    DevComponents.DotNetBar.MessageBoxEx.Show(C.RegistrarCliente(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                                else
                                {
                                    C.Ci = txtCi.Text;
                                    C.Apellidos = txtApellidos.Text;
                                    C.Nombres = txtNombres.Text;
                                    C.Direccion = txtDireccion.Text;
                                    C.Telefono = txtTelefono.Text;
                                    C.Email = txtEmail.Text;
                                    DevComponents.DotNetBar.MessageBoxEx.Show(C.ActualizarCliente(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese N° de Teléfono o Celular.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtTelefono.Focus();
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Dirección del Cliente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtDireccion.Focus();
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
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Apellidos del Cliente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApellidos.Focus();
                }
            }
            else {
                DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese N° de C.I del Cliente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCi.Focus();
            }
       }

        private void Limpiar() {
            txtCi.Text = "";
            txtApellidos.Clear();
            txtNombres.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCi.Focus();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            txtCi.Focus();
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
            txtCi.Focus();
        }
    }
}
