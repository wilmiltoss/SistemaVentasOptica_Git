using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    public class clsProducto
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdArticulo;
        private Int32 m_IdCategoria;
        private String m_Descripcion;
        private String m_Marca;
        private Int32 m_Stock;
        private String m_PrecioCostoIVA;
        private String m_PrecioVenta;
        private DateTime m_FechaRegistro;
        private Int32 m_Proveedor;

        public Int32 IdArticulo
        {
            get { return m_IdArticulo; }
            set{ m_IdArticulo = value;}
        }

        public Int32 IdCategoria
        {
            get { return m_IdCategoria; }
            set { m_IdCategoria = value; }
        }

        public String Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }

        public String Marca
        {
            get { return m_Marca; }
            set { m_Marca = value; }
        }

        public Int32 Stock
        {
            get { return m_Stock; }
            set { m_Stock = value; }
        }

        public String PrecioCostoIVA
        {
            get { return m_PrecioCostoIVA; }
            set { m_PrecioCostoIVA = value; }
        }

        public String PrecioVenta
        {
            get { return m_PrecioVenta; }
            set { m_PrecioVenta = value; }
        }

        public DateTime FechaRegistro
        {
            get { return m_FechaRegistro; }
            set { m_FechaRegistro = value; }
        }

        public Int32 Proveedor
        {
            get { return m_Proveedor; }
            set { m_Proveedor = value; }
        }

        public DataTable ListarArticulo()
        {
            return M.Listado("ListadoArticulo", null);
        }

        public DataTable BusquedaProductos(String objDatos) {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@Datos", objDatos));
                dt = M.Listado("FiltrarDatosProducto", lst);
            }
            catch (Exception ex)
            {    
                throw ex;
            }
            return dt;
        }

        public String RegistrarProductos()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@IdArticulo", m_IdArticulo));
                lst.Add(new clsParametro("@IdCategoria", m_IdCategoria));
                lst.Add(new clsParametro("@Descripcion", m_Descripcion));
                lst.Add(new clsParametro("@Marca", m_Marca));
                lst.Add(new clsParametro("@Stock", m_Stock));
                lst.Add(new clsParametro("@PrecioCostoIVA", m_PrecioCostoIVA));
                lst.Add(new clsParametro("@PrecioVenta", m_PrecioVenta));
                lst.Add(new clsParametro("@FechaRegistro", m_FechaRegistro));
                lst.Add(new clsParametro("@Proveedor", m_Proveedor));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarArticulo", ref lst);
                Mensaje = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarProductos()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@IdArticulo", m_IdArticulo));
                lst.Add(new clsParametro("@IdCategoria", m_IdCategoria));
                lst.Add(new clsParametro("@Descripcion", m_Descripcion));
                lst.Add(new clsParametro("@Marca", m_Marca));
                lst.Add(new clsParametro("@Stock", m_Stock));
                lst.Add(new clsParametro("@PrecioCostoIVA", m_PrecioCostoIVA));
                lst.Add(new clsParametro("@PrecioVenta", m_PrecioVenta));
                lst.Add(new clsParametro("@FechaRegistro", m_FechaRegistro));
                lst.Add(new clsParametro("@Proveedor", m_Proveedor));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarArticulo", ref lst);
                Mensaje = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable EliminarArticulo(int objArticulo)//recibe el objeto objArticulo del frm
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                //recibe el (objArticulo) de EliminarArticulo y elimna con el procedimiento
                lst.Add(new clsParametro("@IdArticulo", objArticulo));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                //ejecuta el procedimiento
                return dt = M.Listado("EliminarArticulo", lst);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable BuscarArticulo(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@Datos", objDatos));
            return dt = M.Listado("FiltrarDatosArticulo", lst);
        }

    }
}