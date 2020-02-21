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
    public partial class FrmListadoProductos : DevComponents.DotNetBar.Metro.MetroForm
    {
        int Listado = 0;
        private clsProducto P = new clsProducto();

        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 5000;
            CargarListadoArticulo();
            dataGridView1.ClearSelection();
            txtSumaRegistros.Enabled = false;
        }

        //despliega la lista de productos en el datagridview
        private void CargarListadoArticulo() {
            DataTable dt = new DataTable();
            dt = P.ListarArticulo();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    //cuenta la cantidad de registros
                    this.txtSumaRegistros.Text = this.dataGridView1.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                    timer1.Stop();
                }
            }

        private void _Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroProductos P = new FrmRegistroProductos();
            if (dataGridView1.SelectedRows.Count > 0)
                Program.Evento = 1;
            else
                Program.Evento = 0;
            dataGridView1.ClearSelection();
            P.Show();
            CargarListadoArticulo();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                FrmRegistroProductos Pr = new FrmRegistroProductos();
                Pr.txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Pr.cbxCategoria.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Pr.txtDescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Pr.txtMarca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Pr.txtStock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Pr.txtPCostoIVA.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Pr.txtPVenta.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Pr.dtmFechaRegistro.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                Pr.cmbProveedor.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Pr.Show();
                if (dataGridView1.SelectedRows.Count > 0)
                    Program.Evento = 1;
                else
                    Program.Evento = 0;
                dataGridView1.ClearSelection();
            }
            else {
                DevComponents.DotNetBar.MessageBoxEx.Show("Debe Seleccionar la Fila a Editar.","Sistema de Ventas.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            CargarListadoArticulo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: CargarListadoArticulo(); break;        
            }
        }

        private void BusquedaProductos() {
            DataTable dt = new DataTable();
            try
            {
                P.Marca = txtBuscarProducto.Text;
                dt = P.BusquedaProductos(P.Marca);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BusquedaProductos();
                timer1.Stop();
            }
            else {
                CargarListadoArticulo();
                timer1.Start();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13){
             if(dataGridView1.SelectedRows.Count>0)
            dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea modificar el registro.?", "Sistema de Ventas.", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)

            {

                Program.IdArticulo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                FrmRegistroProductos FrmP = new FrmRegistroProductos();
                FrmP.txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Program.IdCategoria = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                FrmP.txtDescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FrmP.txtMarca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                FrmP.txtStock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                FrmP.txtPCostoIVA.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                FrmP.txtPVenta.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                FrmP.dtmFechaRegistro.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                Program.Proveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                FrmP.Show();

                dataGridView1.ClearSelection();
                timer1.Start();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea eliminar el registro.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();//consulta la tabla
                        //guarda en U.IdUsuarios la grilla seleccionada
                        P.IdArticulo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());//selecciona el id de la tabla
                                                                                                                     //por el DataTable ejecuta el procedimiento EliminarUsuario con el valor (U.IdUsuarios) enviado al proc
                        dt = P.EliminarArticulo(P.IdArticulo);//objeto enviado a clsProducto
                        MessageBox.Show("Eliminado correctamente");
                        CargarListadoArticulo();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puede eliminar la fila");
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.TextLength > 0)//si el texto esta cargado
            {

                DataTable dt = new DataTable();
                P.Descripcion = txtBuscarProducto.Text;//busca a travez de P.Descripcion
                dt = P.BuscarArticulo(P.Descripcion);//envia el objeto
                try
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(dt.Rows[i][0]);
                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                        dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                        dataGridView1.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();

                    }
                    dataGridView1.ClearSelection();
                    timer1.Stop();
                }
                catch (Exception ex)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
                }
            }
            else
            {
                CargarListadoArticulo();
            }
        }
    }
}
