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

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        // Cargar Combo Articulos
        public DataTable CargarComboArticulos()
        {
            tabla.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_cargarComboArticulo";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            Conexion.cerrarcadena();
            return tabla;
        }

        public int ObtenerExistencias(int IdArticulo)
        {
            int existencia;
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_validarExistenciaArticulo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            existencia = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
            return existencia;
        }

        //cargar grid de articulos
        public DataTable Mostrar_articulos()
        {
            tabla.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_mostrar_artic";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);            
            Conexion.cerrarcadena();
            return tabla; 
        }



        //Metodo Nuevo articulos
        public void nuevo_artic(string Descripción_Articulo,int Existencias,Double PrecioUnitario,int IdFabrica,int ArticulosProvistos,int NoFabricasAlternativa)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_nuevo_articulo";
            cmd.CommandType = CommandType.StoredProcedure;
            
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
            cmd.CommandText = "sp_actualizar_articulo";
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

        //Metodo eliminar articulos
        public void eliminar_articulo(int IdArticulo)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_eliminar_articulo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
          
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
        }

    }
}
