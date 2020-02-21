using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaEnlaceDatos
{
    //CONEXION DE DATOS----------------------
    public class clsManejador
    {
        public SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\Optica;Initial Catalog=BdOptica;Integrated Security=True");
        public void Conectar() {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }


        //----CERRAR LA CONEXION------------
        public void Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        //CONEXION DATATABLE SQLADAPTER
        public DataTable Listado(String NombreSP,List<clsParametro>lst) {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar();
                da = new SqlDataAdapter(NombreSP,conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null) {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    } 
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {       
                throw ex;
            }
            Desconectar();
            return dt;
        }


        //CONEXION SQLCOMMAND -------------
        public void EjecutarSP(String NombreSP,ref List<clsParametro>lst) {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP,conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if(lst!=null){
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre,lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre,lst[i].TipoDato,lst[i].Tamaño).Direction=ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {  
                throw ex;
            }
            Desconectar();
        }

    }
}
