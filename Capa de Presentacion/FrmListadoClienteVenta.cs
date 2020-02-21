using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public partial class FrmListadoClienteVenta : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCliente C = new clsCliente();
        clsVenta V = new clsVenta();

        private List<clsVenta> lst = new List<clsVenta>();

        int Listado = 0;

        public FrmListadoClienteVenta()
        {
            InitializeComponent();
        }

        private void FrmListadoClienteVenta_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            ListarClientes();
            dataGridView1.ClearSelection();

        }
        //despliega la lista de clientes en el datagridview
        private void ListarClientes()
        {
            DataTable dt = new DataTable();
            dt = C.ListadoClientes();
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
                    dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();

                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }

        //busca en el datagrid
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.ClearSelection();
            if (e.KeyChar == 13)
            {
                DataTable dt = new DataTable();
                C.CI = txtBuscarCliente.Text;
                dt = C.BuscarCliente(C.CI);
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
                        dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
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
                ListarClientes();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: ListarClientes(); break;
            }
        }


        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCliente.TextLength > 0)//si el texto esta cargado
            {

                DataTable dt = new DataTable();
                C.Nombres = txtBuscarCliente.Text;//busca a travez de P.Descripcion
                dt = C.BuscarCliente(C.Nombres);//envia el objeto
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
                        dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();

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
                ListarClientes();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Program.IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.CI = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.Apellidos = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.Nombres = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        

    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.CI = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.Apellidos = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.Nombres = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Program.IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.CI = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.Apellidos = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.Nombres = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
