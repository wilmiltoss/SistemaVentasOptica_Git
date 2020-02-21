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
   public class clsPefil
    {
       private clsManejador M = new clsManejador(); //conexion 

        Int32 m_IdPerfil;
        String m_Descripcion;

        public Int32 IdPerfil
        {
            get { return m_IdPerfil; }
            set { m_IdPerfil = value; }
        }

        public String Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }

        public DataTable ListarPerfil() {
            return M.Listado("ListarPerfil", null);
        }


        //-------------------------- no se usa-------------------------------------
        public String RegistrarPerfil() {
            String Mensaje = "";
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@Descripcion", m_Descripcion));
                lst.Add(new clsParametro("@Mensaje","",SqlDbType.VarChar,ParameterDirection.Output,50));
                M.EjecutarSP("RegistrarPerfil",ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {               
               throw ex;
            }
            return Mensaje;
        }

      public String ActualizarPerfil() {
            String Mensaje = "";
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdPerfil", m_IdPerfil));
                lst.Add(new clsParametro("@Descripcion", m_Descripcion));
                lst.Add(new clsParametro("@Mensaje","",SqlDbType.VarChar,ParameterDirection.Output,100));
                M.EjecutarSP("ActualizarPerfil", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {               
               throw ex;
            }
            return Mensaje;
        }

        public DataTable BusquedaPerfil(String objDescripcion) {
            DataTable dt=new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@Descripcion",objDescripcion));
                return dt = M.Listado("BuscarPefil",lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
