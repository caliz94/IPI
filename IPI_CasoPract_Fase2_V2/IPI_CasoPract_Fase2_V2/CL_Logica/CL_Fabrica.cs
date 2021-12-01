using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CD_Datos;

namespace CL_Logica
{
    public class CL_Fabrica
    {
        private CD_Fabrica OFabrica = new CD_Fabrica();


        public DataTable MostrarFabricas()
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.Mostrar();
            return tabla;
        }


        public void InsertarFabrica(string nombre, int codArticulo, string descripcionArticulo, int existencias, string telefono)
        {
            OFabrica.InsertarFabrica(nombre, Convert.ToInt32(codArticulo), descripcionArticulo, Convert.ToInt32(existencias), telefono);
        }
    }
}
