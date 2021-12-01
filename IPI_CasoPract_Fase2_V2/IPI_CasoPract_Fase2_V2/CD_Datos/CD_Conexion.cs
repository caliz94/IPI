using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CD_Datos
{
    public class CD_Conexion
    {
        private SqlConnection cadena = new SqlConnection("server=.;database=IPICASOPRACTICO;integrated security= true");

        public SqlConnection abrircadena()
        {
            if (cadena.State==ConnectionState.Closed)
            
                cadena.Open();
                return cadena;
            
        }

        public SqlConnection cerrarcadena()
        {
            if (cadena.State == ConnectionState.Open)
            
                cadena.Close();             
                return cadena;
        }

    }
}
