using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CD_Datos
{
    public class CD_Clientes
    {
        private CD_Conexion Conexion = new CD_Conexion();

       
        SqlCommand cmd = new SqlCommand();

        public void nuevo_cliente(string NombreCliente,string Saldo,string LimiteCredito,string Descuento,int Activo )
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "SP_NuevoCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);
            cmd.Parameters.AddWithValue("@LimiteCredito", LimiteCredito);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();            
        }
    }
}
