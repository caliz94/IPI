using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
   public class Cd_Placas
    {
        //hacer referencia a la clase de la conexion con el servidor
        private Da_conex_servidor cadena = new Da_conex_servidor();
        SqlCommand cmd = new SqlCommand();


        //metodo para insertar
        public void insertar(int ID_INTEGRANTE, int R_PLACAS, string MES, string SEMANA)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_reg_placas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_INTEGRANTE", ID_INTEGRANTE);
            cmd.Parameters.AddWithValue("@R_PLACAS", R_PLACAS);
            cmd.Parameters.AddWithValue("@MES", MES);
            cmd.Parameters.AddWithValue("@SEMANA", SEMANA);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();
        }
    }
}
