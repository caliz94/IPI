using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CD_Datos
{
    public class CD_Direcciones
    {
        CD_Conexion conex_cd = new CD_Conexion();
        SqlCommand cmd = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader leer ;

        public DataTable cliente_direc()
        {
            table.Clear();
            cmd.Connection = conex_cd.abrircadena();
            cmd.CommandText = "sp_clientesActivos_direcio";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            
            conex_cd.cerrarcadena();
            return table;
        }



        //nueva direccion
        public void nuevo_Direcion(int IdCliente,string Calle,string Barrio,string Distrito)
        {
            table.Clear();
            cmd.Connection = conex_cd.abrircadena();
            cmd.CommandText = "sp_direcciones";
            cmd.CommandType = CommandType.StoredProcedure;
       
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
            cmd.Parameters.AddWithValue("@Calle", Calle);
            cmd.Parameters.AddWithValue("@Barrio", Barrio);
            cmd.Parameters.AddWithValue("@Distrito", Distrito);
            cmd.ExecuteNonQuery();            
            conex_cd.cerrarcadena();
        }



        //actualizar direccion
        public void actualizar_Direcion(int IdDireccion, string Calle, string Barrio, string Distrito)
        {
            table.Clear();
            cmd.Connection = conex_cd.abrircadena();
            cmd.CommandText = "sp_actual_direcc";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdDireccion", IdDireccion);
            cmd.Parameters.AddWithValue("@Calle", Calle);
            cmd.Parameters.AddWithValue("@Barrio", Barrio);
            cmd.Parameters.AddWithValue("@Distrito", Distrito);
            cmd.ExecuteNonQuery();
            conex_cd.cerrarcadena();
        }
    }
}
