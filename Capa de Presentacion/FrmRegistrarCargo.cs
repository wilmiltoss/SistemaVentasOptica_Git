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
    public partial class FrmRegistrarCargo : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsPefil C = new clsPefil();

        public FrmRegistrarCargo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            try{
                if (txtCargo.Text.Trim() != ""){
                    if (Program.Evento == 0){
                        C.Descripcion = txtCargo.Text;
                        Mensaje = C.RegistrarPerfil();
                        if (Mensaje == "El Cargo ya se Encuentra Registrado."){
                            DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }else{
                            DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        }else{
                        C.IdPerfil = Convert.ToInt32(txtIdC.Text);
                        C.Descripcion = txtCargo.Text;
                        DevComponents.DotNetBar.MessageBoxEx.Show(C.ActualizarPerfil(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese el Cargo a Registrar.","Sistema de Ventas.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtCargo.Focus();
                }
                }catch (Exception ex){
                    DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
            
        }

        private void Limpiar() {
            txtCargo.Text = "";
            txtIdC.Clear();
            txtCargo.Focus();
        }
    }
}
