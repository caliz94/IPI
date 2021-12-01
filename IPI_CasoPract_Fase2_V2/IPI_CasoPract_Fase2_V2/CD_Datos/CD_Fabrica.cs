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

        public void InsertarFabrica(string nombre, int codArticulo, string descripcionArticulo, int existencias, string telefono)
        {
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_InsertarFabrica";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreFabrica", nombre);
            comando.Parameters.AddWithValue("@CodArticulo", codArticulo);
            comando.Parameters.AddWithValue("@Descripcion_Articulo", descripcionArticulo);
            comando.Parameters.AddWithValue("@Existencias", existencias);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.ExecuteNonQuery();
            Conexion.cerrarcadena();
        }
    }
}
