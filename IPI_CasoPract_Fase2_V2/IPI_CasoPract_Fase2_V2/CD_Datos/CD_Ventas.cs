using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CD_Datos
{
    public class CD_Ventas
    {
        CD_Conexion Conexion = new CD_Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader leerdata;
        DataTable tabla = new DataTable();

        public void GuardarVenta(int IdCliente, int IdDireccion, byte Activo)
        {
            cmd.Parameters.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_GuardarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
            cmd.Parameters.AddWithValue("@IdDireccion", IdDireccion);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.ExecuteNonQuery();
            cmd.Connection = Conexion.cerrarcadena();
        }


        public DataTable CargarComboDirecciones(int IdCliente)
        {
            tabla.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_cargarComboDirecciones";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(IdCliente));
            leerdata = cmd.ExecuteReader();
            tabla.Load(leerdata);
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
            return tabla;
        }
    }
}
