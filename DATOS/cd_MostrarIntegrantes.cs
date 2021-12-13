using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class cd_MostrarIntegrantes
    {

        public Da_conex_servidor cadena = new Da_conex_servidor();
        SqlDataReader leer;
        DataTable tabla_integrantes = new DataTable();
        private SqlCommand cmd = new SqlCommand();        
        
        public DataTable mostrar_integrantes()
        {
            //tabla_integrantes.Clear();
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_MostrarIntegrantes";
            cmd.CommandType = CommandType.StoredProcedure;
                  
            leer = cmd.ExecuteReader();
            tabla_integrantes.Load(leer);
            cadena.CERRAR_SERVER();
            return tabla_integrantes; 
        }
        

    }
}
