using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CapaLogicaNegocio
{
    public class clsProveedor
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdProveedor;
        private String m_Descripcion;
        private String m_RUC;
        private String m_Direccion;
        private Int32 m_Ciudad;
        private String m_Telefono;
        private String m_NombreContacto;
        private String m_Email;

        public Int32 IdProveedor
        {
            get { return m_IdProveedor; }
            set { m_IdProveedor = value; }
        }
        public String Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }
        public String RUC
        {
            get { return m_RUC; }
            set { m_RUC = value; }
        }
        public String Direccion
        {
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }
        public Int32 Ciudad
        {
            get { return m_Ciudad; }
            set { m_Ciudad = value; }
        }
        public String Telefono
        {
            get { return m_Telefono; }
            set { m_Telefono = value; }
        }
        public String NombreContacto
        {
            get { return m_NombreContacto; }
            set { m_NombreContacto = value; }
        }
        public String Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        public DataTable ListarProveedor()
        {
            return M.Listado("ListarProveedor", null);
        }

        public String RegistrarProveedor()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Descripcion", m_Descripcion));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarCategoria", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

    }
}
