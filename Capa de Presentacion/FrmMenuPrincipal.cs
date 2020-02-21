using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaLogicaNegocio;
using DevComponents.DotNetBar;

namespace Capa_de_Presentacion
{
    public partial class FrmMenuPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsUsuarios U = new clsUsuarios();
        int EnviarFecha = 0;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lparam);

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.NombreUsuarioLogueado;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
            timer1.Interval = 500;
            timer1.Start();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmListadoProductos());
        
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmListadoClientes());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas E = new FrmRegistroVentas();
            E.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmRegistrarUsuarios2());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(EnviarFecha){
                case 0: CapturarFechaSistema(); break;
            }
        }

        private void CapturarFechaSistema() {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmListadoUsuarios());
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconoRestaurar.Visible = true;
            iconoMaximizar.Visible = false ;  
        }

        private void iconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconoRestaurar.Visible = false;
            iconoMaximizar.Visible = true;
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SumMenuReportes.Visible = true;
        }

        private void btnRptVenta_Click(object sender, EventArgs e)
        {
            SumMenuReportes.Visible = false;
        }

        private void btnRptCompras_Click(object sender, EventArgs e)
        {
            SumMenuReportes.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmInicio());
        }

        //----------------pruebas------------------------------------------
        private void MostrarUsuario()
        {
            DataTable dt = new DataTable();
            dt = U.DevolverUsuarios();
            lblUsuario.Text = dt.Rows[0].ToString();

        }
    }
}
