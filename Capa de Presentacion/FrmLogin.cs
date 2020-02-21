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
using System.Runtime.InteropServices;

namespace Capa_de_Presentacion
{
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsUsuarios U = new clsUsuarios();

        public FrmLogin()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lparam);

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();

        }

        private void 
            _Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                Application.Exit();
            }
               
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "")
            {
                if (txtPassword.Text.Trim() != "")
                {
                    String Mensaje = "";
                    U.NombreUsuario = txtUser.Text;
                    U.Contrasena = txtPassword.Text;
                    Mensaje = U.IniciarSesion();
                    if (Mensaje == "Su Contrasena es Invalida.")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                    else
                        if (Mensaje == "El Nombre de Usuario no Existe.")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser.Focus();
                    }
                    else
                    {
                         DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        FrmMenuPrincipal MP = new FrmMenuPrincipal();
                        RecuperarDatosSesion();
                        MP.Show();
                        this.Hide();
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese su Contraseña.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Nombre de Usuario.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
        }

        private void RecuperarDatosSesion() {
            DataRow row ;
            DataTable dt = new DataTable();
            dt = U.DevolverDatosSesion(txtUser.Text,txtPassword.Text);//ejecuta el procedimiento segun el t
            if (dt.Rows.Count == 1) {
                row = dt.Rows[0];
                //carga los datos en los siguientes campos
                Program.IdUsuarioLogueado = Convert.ToInt32(row[0].ToString());
                Program.NombreUsuarioLogueado = row[1].ToString();

     
            }
        }

        //muestra letras en el texbox
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }
        //muestra letras en el texbox
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text=="")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.LightGray;              
            }
        }
        //muestra letras en el texbox al dar enter
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text=="")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
