using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.      
        /// </summary>
         public static int Evento;

        //Datos del Cliente

        public static int IdCliente;
        public static String Nombres;
        public static String Apellidos;
        public static String CI;
        public static String Ruc;
        public static String Direccion;
        public static String Telefono;
        public static String FechaIngreso;
        public static String Email;
        public static int IdPais;

        //Datos del Articulo
        public static int IdArticulo;
        public static int IdCategoria;
        public static String Descripcion;
        public static String Marca;
        public static Int32 Stock;
        public static String PrecioCostoIVA;
        public static String PrecioVenta;
        public static String FechaRegistro;
        public static int Proveedor;

        //Datos del Usuario
        public static int IdUsuarios;
        public static String NombreUsuario = "";
        public static String NombresUsu = "";
        public static String ApellidosUsu = "";
        public static String Contraseña = "";
        public static int IdPerfil = 0;
        public static string CI_Usu = "";
        public static String FechaIngresoUsu = "";
        public static String Activo = "";
        public static String EmailUsu = "";
        public static String DireccionUsu;

        //Variables de Sesion
        public static int IdUsuarioLogueado;
        public static String NombreUsuarioLogueado;
 
        [STAThread]
        //--ADMINISTRACION DE FORMULARIOS--cual inicia 1ro....
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());      
        }
    }
}
