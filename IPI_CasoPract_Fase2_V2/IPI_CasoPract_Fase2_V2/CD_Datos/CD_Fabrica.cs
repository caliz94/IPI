using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CD_Datos
{
    public class CD_Fabrica
    {
        private CD_Conexion Conexion = new CD_Conexion();

        SqlDataReader leerdata;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_mostrarFabricas";
            comando.CommandType = CommandType.StoredProcedure;
            leerdata = comando.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }
    }
}
