using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DATOS
{
    public class Da_conex_servidor
    { 
        //CADENA CON EL SERVIDOR DE BASE DE DATOS
       private SqlConnection Conexion = new SqlConnection("Server=.;database=AMATEURS;INTEGRATED SECURITY=TRUE");

        //ABRIR CONEXION CON SERV_DB

        public SqlConnection ABRIR_SERVER()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        //CERRAR CONEXION CON SERV_DB
        public SqlConnection CERRAR_SERVER()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
