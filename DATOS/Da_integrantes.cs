using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DATOS
{
    public class Da_integrantes
    {
        //hacer referencia a la clase de la conexion con el servidor
        private Da_conex_servidor cadena = new Da_conex_servidor();
        SqlCommand cmd = new SqlCommand();


        //metodo para insertar
        public void insertar(string USUARIO,string CELULAR,string PAIS_NACIONALIDAD,DateTime FECHA_INGRESO,string COMENTARIO, string ESTADO)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_insertar_integrante";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", USUARIO);
            cmd.Parameters.AddWithValue("@CELULAR", CELULAR);
            cmd.Parameters.AddWithValue("@PAIS_NACIONALIDAD", PAIS_NACIONALIDAD);
            cmd.Parameters.AddWithValue("@FECHA_INGRESO", FECHA_INGRESO);
            cmd.Parameters.AddWithValue("@COMENTARIO", COMENTARIO);
            cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();                            
        }
    }
}
