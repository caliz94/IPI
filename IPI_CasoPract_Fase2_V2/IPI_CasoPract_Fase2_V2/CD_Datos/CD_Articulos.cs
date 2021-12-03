using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CD_Datos
{
    public  class CD_Articulos
    {
        private CD_Conexion Conexion = new CD_Conexion();
        SqlCommand cmd = new SqlCommand();
        //Metodo Nuevo articulos
        public void nuevo_artic(int IdArticulo,string Descripción_Articulo,int Existencias,Double PrecioUnitario,int IdFabrica,int ArticulosProvistos,int NoFabricasAlternativa)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_nuevoCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            cmd.Parameters.AddWithValue("@Descripción_Articulo", Descripción_Articulo);
            cmd.Parameters.AddWithValue("@Existencias", Existencias);
            cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            cmd.Parameters.AddWithValue("@ArticulosProvistos", ArticulosProvistos);
            cmd.Parameters.AddWithValue("@NoFabricasAlternativa", NoFabricasAlternativa);
         
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
        }

        //Metodo modif articulos
        public void edit_artic(int IdArticulo, string Descripción_Articulo, int Existencias, Double PrecioUnitario, int IdFabrica, int ArticulosProvistos, int NoFabricasAlternativa)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_nuevoCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            cmd.Parameters.AddWithValue("@Descripción_Articulo", Descripción_Articulo);
            cmd.Parameters.AddWithValue("@Existencias", Existencias);
            cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            cmd.Parameters.AddWithValue("@ArticulosProvistos", ArticulosProvistos);
            cmd.Parameters.AddWithValue("@NoFabricasAlternativa", NoFabricasAlternativa);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
        }


    }
}
