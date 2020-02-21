using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEnlaceDatos;
using System.Windows.Forms;

namespace CapaLogicaNegocio
{
    public class clsCliente
    {
        clsManejador M = new clsManejador();

        public int IdCliente { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String CI { get; set; }
        public String Ruc { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String Email { get; set; }
        public int Pais { get; set; }


        public String RegistrarCliente()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdCliente", IdCliente));
                lst.Add(new clsParametro("@Nombres", Nombres));
                lst.Add(new clsParametro("@Apellidos", Apellidos));
                lst.Add(new clsParametro("@CI", CI));
                lst.Add(new clsParametro("@Ruc", Ruc));
                lst.Add(new clsParametro("@Direccion", Direccion));
                lst.Add(new clsParametro("@Telefono", Telefono));
                lst.Add(new clsParametro("@FechaIngreso", FechaIngreso));
                lst.Add(new clsParametro("@Email", Email));
                lst.Add(new clsParametro("@IdPais", Pais));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarCliente", ref lst);
                Mensaje = lst[10].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarCliente()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdCliente", IdCliente));
                lst.Add(new clsParametro("@Nombres", Nombres));
                lst.Add(new clsParametro("@Apellidos", Apellidos));
                lst.Add(new clsParametro("@CI", CI));
                lst.Add(new clsParametro("@Ruc", Ruc));
                lst.Add(new clsParametro("@Direccion", Direccion));
                lst.Add(new clsParametro("@Telefono", Telefono));
                lst.Add(new clsParametro("@FechaIngreso", FechaIngreso));
                lst.Add(new clsParametro("@Email", Email));
                lst.Add(new clsParametro("@IdPais", Pais));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarCliente", ref lst);
                Mensaje = lst[10].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
        //extrae el procedimiento ListarClientes p/ mostrarlo en la grilla
        public DataTable ListadoClientes() {
           return M.Listado("ListarClientes", null);
        }

        //extrae el procedimiento ListadoPais p/ mostrarlo en la grilla
        public DataTable ListadoPais()
        {
            return M.Listado("ListarPais", null);
        }

        public DataTable BuscarCliente(String objDatos) {
            //declara los elementos
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            //utiliza los elementos
            lst.Add(new clsParametro("@Datos", objDatos));
            return dt = M.Listado("FiltrarDatosClientes", lst);
        
    }

      
        


        public DataTable EliminarClientes(int objCliente)//recibe el objeto objUsuario del frmListadoUsuario en objUsuario
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();

            try
            {
                //recibe el (objUsuario) de EliminarUsuario y elimna con el procedimiento
                lst.Add(new clsParametro("@IdCliente", objCliente));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                //ejecuta el procedimiento
                return dt = M.Listado("EliminarCliente", lst);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
