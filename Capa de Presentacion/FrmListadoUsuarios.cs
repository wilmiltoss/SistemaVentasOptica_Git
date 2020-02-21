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
    public partial class FrmListadoUsuarios : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsUsuarios U = new clsUsuarios();//importar clase
        int Listado = 0;
     
        public FrmListadoUsuarios()
        {
            InitializeComponent();
            MostrarListadoUsuarios();

        }

        private void FrmListadoEmpleados_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            MostrarListadoUsuarios();       
            txtSumaRegistros.Enabled = false;
       

        }
        //despliega la lista de usuarios
        private void MostrarListadoUsuarios() {
            DataTable dt = new DataTable();
            dt = U.ListadoUsuarios();

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
                    dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                //cuenta la cantidad de registros
                this.txtSumaRegistros.Text = this.dataGridView1.RowCount.ToString();
            }
            dataGridView1.ClearSelection();

            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }
            
        //carga nuevos usuarios en el sistema
        private void btnNuevo_Click(object sender, EventArgs e)
        { 
            FrmRegistrarUsuarios2 E = new FrmRegistrarUsuarios2();
            DataTable dt = new DataTable();

            int countRows = dataGridView1.Rows.Count;
            //string valorCelda = dataGridView1.Rows[countRows].Columns["ID"].ToString();
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            Program.IdPerfil = 0;
            E.txtIdUsuario.Focus();
      
            E.Show();
            dataGridView1.ClearSelection();     
        }

        //muestra en el form todos los datos a editar de la grilla
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    FrmRegistrarUsuarios2 E = new FrmRegistrarUsuarios2();
                    E.txtIdUsuario.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    E.txtUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    E.txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    E.txtApellido.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    E.txtContrasena.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    Program.IdPerfil = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    E.txtCI.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    E.dtmFechaIngreso.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                    E.txtEmail.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    E.txtDireccion.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    E.txtNombre.Focus();
                    E.Show();
                }
                dataGridView1.ClearSelection();
                timer1.Start();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(Listado){
                case 0: MostrarListadoUsuarios(); break;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                timer1.Stop();
            }
        }

        //muestra los datos en la grilla con el doble click
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea modificar el usuario.?","Sistema de Ventas.", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
                        Program.IdUsuarios = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        FrmRegistrarUsuarios2 E = new FrmRegistrarUsuarios2();
                        E.txtIdUsuario.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        E.txtUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        E.txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        E.txtApellido.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        E.txtContrasena.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        Program.IdPerfil = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        E.txtCI.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        E.dtmFechaIngreso.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                        E.txtEmail.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                        E.txtDireccion.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                        E.Show();
                    
                    dataGridView1.ClearSelection();
                    timer1.Start();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           String IdSeleccionado;
            //DialogResult res = MessageBox.Show("tiene registro" + Environment.NewLine + "Primero guarde el registro", "atencion",
            // MessageBoxButtons.OK, MessageBoxIcon.Information);
            //IdSeleccionado = dataGridView1.Rows[e.ToString].Cells["IdUsuario"].Value.ToString();
        }

        private void txtDatos_TextChanged(object sender, EventArgs e)
        {
            if (txtDatos.TextLength>0)//si el texto esta cargado
            {

                DataTable dt = new DataTable();
                U.Nombres = txtDatos.Text;//envia el objeto a travez de U.Nombre rescatando lo q se cargo en el txtDatos.Text
                dt = U.BuscarUsuario(U.Nombres);//envia el objeto
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
                        dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
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
                MostrarListadoUsuarios();
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
                        U.IdUsuarios = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value.ToString());//selecciona el id de la tabla
                                                                                                                     //por el DataTable ejecuta el procedimiento EliminarUsuario con el valor (U.IdUsuarios) enviado al proc
                        dt = U.EliminarUsuario(U.IdUsuarios);
                        MessageBox.Show("Eliminado correctamente");
                        MostrarListadoUsuarios();
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

    }
}
