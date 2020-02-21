using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaLogicaNegocio
{
    public class SumaNroRegistrosGridView : ISumaNroRegistrosGridView
    {
        public DataGridView otlGrid;

        public DataGridView GRIDVIED
        {
            get { return this.otlGrid; }
            set
            {
                this.otlGrid = value;
                this.otlGrid.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dg_DataBinddingComplete);
            }
        }

        private void dg_DataBinddingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

       
        }

    }
}
