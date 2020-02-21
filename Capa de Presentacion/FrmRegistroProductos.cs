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
    public partial class FrmRegistroProductos : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCategoria C = new clsCategoria();
        private clsProducto P = new clsProducto();
        private clsProveedor Pv = new clsProveedor();

        //validar si los campos descripcion y usuario estan vacios p/ habilitar boton agregar
        private void Validar()
        {
            if (txtDescripcion.Text != string.Empty && txtMarca.Text != string.Empty && txtStock.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        public FrmRegistroProductos()
        {
            InitializeComponent();
        }

        private void FrmRegistroProductos_Load(object sender, EventArgs e)
        {
            ListarCategoriaCombo();
            ListarProvedorCombo();
            txtDescripcion.Focus();
            txtCodigo.Enabled = false;

            //inicializa los botones en false
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;

            //si el campo txtIdValidacion es distinto a 0 se habilita el btn Modificar sino  habilita el boton btnAgregar

            if (txtCodigo.Text != "0")
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        //cargar combobox categoria
        private void ListarCategoriaCombo()
        {
            if (IdC.Text.Trim() != "")
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.ListarCategoria();
                cbxCategoria.SelectedValue = IdC.Text;
            }
            else
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.ListarCategoria();
            }
        }
        //cargar combobox proveedor
        private void ListarProvedorCombo()
        {
            if (IdC.Text.Trim() != "")
            {
                cmbProveedor.DisplayMember = "Descripcion";
                cmbProveedor.ValueMember = "IdProveedor";
                cmbProveedor.DataSource = Pv.ListarProveedor();
                cmbProveedor.SelectedValue = IdC.Text;
            }
            else
            {
                cmbProveedor.DisplayMember = "Descripcion";
                cmbProveedor.ValueMember = "IdProveedor";
                cmbProveedor.DataSource = Pv.ListarProveedor();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String Mensaje = "";
                if (cbxCategoria.Text.Trim() != "Seleccione")
                {
                    if (cmbProveedor.Text.Trim() != "Seleccione")
                    {
                        if (txtDescripcion.Text.Trim() != "")
                        {
                            if (txtMarca.Text.Trim() != "")
                            {
                                if (txtPCostoIVA.Text.Trim() != "")
                                {
                                    if (txtPVenta.Text.Trim() != "")
                                    {
                                        if (txtStock.Text.Trim() != "")
                                        {
                                            if (cbxCategoria.Text.Trim() != "")
                                            {
                                                if (Program.Evento == 0)
                                                {

                                                    P.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                                                    P.Descripcion = txtDescripcion.Text;
                                                    P.Marca = txtMarca.Text;
                                                    P.Stock = Convert.ToInt32(txtStock.Text);
                                                    P.PrecioCostoIVA = Convert.ToString(txtPCostoIVA.Text);
                                                    P.PrecioVenta = Convert.ToString(txtPVenta.Text);
                                                    P.FechaRegistro = Convert.ToDateTime(dtmFechaRegistro.Value);
                                                    P.Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                                                    Mensaje = P.RegistrarProductos();
                                                    if (Mensaje == "Este Producto ya ha sido Registrado.")
                                                    {
                                                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    }
                                                    else
                                                    {
                                                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        Limpiar();
                                                        Close();
                                                    }
                                                }
                                                /* else
                                                 {
                                                     P.IdP = Convert.ToInt32(txtCodigo.Text);
                                                     P.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                                                     P.Producto = txtDescripcion.Text;
                                                     P.Marca = txtMarca.Text;
                                                     P.PrecioCompra = Convert.ToDecimal(txtPCostoIVA.Text);
                                                     P.PrecioVenta = Convert.ToDecimal(txtPVenta.Text);
                                                     P.Stock = Convert.ToInt32(txtStock.Text);
                                                     P.FechaVencimiento = Convert.ToDateTime(dtmFechaRegistro.Value);
                                                     DevComponents.DotNetBar.MessageBoxEx.Show(P.ActualizarProductos(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                     Limpiar();
                                                 }*/
                                            }
                                            else
                                            {
                                                DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese la Categoria del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                cbxCategoria.Focus();
                                            }
                                        }
                                        else
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese Stock del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtStock.Focus();
                                        }
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese Precio de Venta del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtPVenta.Focus();
                                    }
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese Precio de Compra del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPCostoIVA.Focus();
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese Marca del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMarca.Focus();
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese Nombre del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDescripcion.Focus();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese el Proveedor.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbProveedor.Focus();
                    }
                }

                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Favor Ingrese la Categoria del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxCategoria.Focus();
                }
                FrmListadoProductos LP = new FrmListadoProductos();
                LP.timer1.Start();

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Error en el registro del Producto");
            }

        }
        //-------ESTIRAR FORMULARIO FrmRegistrarCategoria CON BTN
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria C = new FrmRegistrarCategoria();
            C.Show();
        }
        //-----LIMPIAR CAMPOS PRODUCTOS--------
        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtMarca.Clear();
            txtPCostoIVA.Clear();
            txtPVenta.Clear();
            IdC.Clear();
            txtCodigo.Clear();
            txtStock.Clear();
            dtmFechaRegistro.Value = DateTime.Now;
            txtDescripcion.Focus();
        }
        //-------CANCELAR OPRACION-----
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //validar el campo costo
        private void txtPCostoIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPCostoIVA.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        //validar el campo venta
        private void txtPVenta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (this.txtPVenta.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtStock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCategoria.Text != "Seleccione")
                {
                    if (cmbProveedor.Text != "Seleccione")
                    {
                        //Valida si los campos del form estan vacios
                        if (this.txtDescripcion.Text.Trim() != "" && this.txtMarca.Text.Trim() != "" && this.txtStock.Text.Trim() != ""
                        && this.txtPVenta.Text.Trim() != "" && this.txtPCostoIVA.Text.Trim() != "")
                        {

                            //copio los datos de los texbox para guardarlos en los campos
                            P.IdArticulo = Convert.ToInt32(txtCodigo.Text);
                            P.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                            P.Descripcion = txtDescripcion.Text;
                            P.Marca = txtMarca.Text;
                            P.Stock = Convert.ToInt32(txtStock.Text);
                            P.PrecioCostoIVA = Convert.ToString(txtPCostoIVA.Text);
                            P.PrecioVenta = Convert.ToString(txtPVenta.Text);
                            P.FechaRegistro = Convert.ToDateTime(dtmFechaRegistro.Value);
                            P.Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                            DevComponents.DotNetBar.MessageBoxEx.Show(P.ActualizarProductos(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                        MessageBox.Show("Seleccione  el Proveedor", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxCategoria.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la categoria", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxCategoria.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                txtDescripcion.Focus();
            }
        }

    }
}
