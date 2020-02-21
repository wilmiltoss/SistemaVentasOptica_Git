using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEnlaceDatos;
using System.Windows.Forms;

namespace CapaLogicaNegocio
{
   public class clsUsuarios
    {
       clsManejador M = new clsManejador();
        
        public int IdUsuarios { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Contrasena { get; set; }
        public int IdPerfil { get; set; }
        public string CI { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Activo { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

       public String RegistrarUsuario() {

           List<clsParametro> lst = new List<clsParametro>();
           String Mensaje = "";
           try
            {
                lst.Add(new clsParametro("@IdUsuarios", IdUsuarios));
                lst.Add(new clsParametro("@NombreUsuario", NombreUsuario));
                lst.Add(new clsParametro("@Nombres", Nombres));
                lst.Add(new clsParametro("@Apellidos", Apellidos));
                lst.Add(new clsParametro("@Contrasena", Contrasena));
                lst.Add(new clsParametro("@IdPerfil", IdPerfil));
                lst.Add(new clsParametro("@CI", CI));
                lst.Add(new clsParametro("@FechaIngreso", FechaIngreso));
                lst.Add(new clsParametro("@Activo", Activo));
                lst.Add(new clsParametro("@Email", Email));
                lst.Add(new clsParametro("@Direccion", Direccion));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
               M.EjecutarSP("RegistrarUsuario",ref lst);
               return Mensaje = lst[11].Valor.ToString();
           }catch (Exception ex){
               throw ex;
           }
       }

        public String MantenimientoUsuarios()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try{
                lst.Add(new clsParametro("@IdUsuarios", IdUsuarios));
                lst.Add(new clsParametro("@NombreUsuario", NombreUsuario));
                lst.Add(new clsParametro("@Nombres", Nombres));
                lst.Add(new clsParametro("@Apellidos", Apellidos));
                lst.Add(new clsParametro("@Contrasena", Contrasena));
                lst.Add(new clsParametro("@IdPerfil", IdPerfil));
                lst.Add(new clsParametro("@CI", CI));
                lst.Add(new clsParametro("@FechaIngreso", FechaIngreso));
                lst.Add(new clsParametro("@Activo", Activo));
                lst.Add(new clsParametro("@Email", Email));
                lst.Add(new clsParametro("@Direccion", Direccion));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("MantenimientoUsuarios", ref lst);
                return Mensaje = lst[11].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String IniciarSesion() {
           List<clsParametro> lst = new List<clsParametro>();
           String Mensaje="";
           try{
               lst.Add(new clsParametro("@NombreUsuario", NombreUsuario));
               lst.Add(new clsParametro("@Contrasena", Contrasena));
               lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
               M.EjecutarSP("IniciarSesion", ref lst);
               return Mensaje=lst[2].Valor.ToString();
           }catch (Exception ex){
               throw ex;
           }
       }

       public DataTable DevolverDatosSesion(String objUser,String objPassword) {
           List<clsParametro> lst = new List<clsParametro>();
           try{
               lst.Add(new clsParametro("@NombreUsuario", objUser));
               lst.Add(new clsParametro("@Contrasena", objPassword));
               return M.Listado("DevolverDatosSesion",lst);
           }catch (Exception ex){
               throw ex;
           }
       }


        public DataTable DevolverUsuarios()
        {
            return M.Listado("DevolverDatosSesion", null);
        }



        public DataTable ListadoUsuarios()
        {
            return M.Listado("ListadoUsuarios", null);
        }


        public String GenerarIdUsuarios()
        {
            List<clsParametro> lst = new List<clsParametro>();
            int objIdUsuario;
            try
            {
                lst.Add(new clsParametro("@IdUsuarios", "", SqlDbType.Int, ParameterDirection.Output, 4));
                M.EjecutarSP("GenerarIdUsuarios", ref lst);
                objIdUsuario = Convert.ToInt32(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdUsuario);
        }

        public DataTable BuscarUsuario(String objDatos) //recibe el objeto del frmListadoUsuarios en objDatos
        {
            //declara los elementos
            DataTable dt = new DataTable(); 
            List<clsParametro> lst = new List<clsParametro>();
            //utiliza los elementos
            lst.Add(new clsParametro("@Datos", objDatos));
            return dt = M.Listado("Buscar_Usuario", lst);
        }


        public DataTable EliminarUsuario(int objUsuario)//recibe el objeto objUsuario del frmListadoUsuario en objUsuario
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();

            try
            {
                //recibe el (objUsuario) de EliminarUsuario y elimna con el procedimiento
                lst.Add(new clsParametro("@IdUsuarios", objUsuario));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                //ejecuta el procedimiento
                return dt = M.Listado("EliminarUsuario", lst);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
