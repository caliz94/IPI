using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CD_Datos
{
    public class CD_Articulos
    {
        private CD_Conexion Conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlDataReader leerCBX;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        #region CARGAR COMBO ARTICULOS
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
        #endregion

        #region CARGAR EXISTENCIAS ARTICULOS
        public int CargarExistencias(int IdArticulo)
        {
            cmd.Parameters.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_validarExistenciaArticulo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            return (int)cmd.ExecuteScalar();
            Conexion.cerrarcadena();
        }
        #endregion

        #region CARGAR PRECIO PRODUCTOS
        public float CargarPrecios(int IdArticulo)
        {
            cmd.Parameters.Clear();
            //int existencia;
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_validarPrecioArticulo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);          
            return (int)(decimal)cmd.ExecuteScalar();
            Conexion.cerrarcadena();
        }
        #endregion

        #region OBTENER ARTICULOS PROVISTOS
        public int Art_Provistos(int IdFabrica)
        {
            cmd.Parameters.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_ArticulosProvistosxIdFabrica";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            return (int)cmd.ExecuteScalar();           
        }
        #endregion

        #region CARGA GRID DE ARTICULOS
        public DataTable Mostrar_articulos()
        {
            cmd.Connection = Conexion.abrircadena();
            tabla.Clear();
            cmd.CommandText = "sp_mostrar_artic";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            return tabla;
            Conexion.cerrarcadena();
        }
        #endregion

        #region CREA NUEVO ARTICULO
        public void nuevo_artic(string Descripción_Articulo,int Existencias,Double PrecioUnitario,int IdFabrica,int ArticulosProvistos,int NoFabricasAlternativa)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_nuevo_articulo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descripción_Articulo", Descripción_Articulo);
            cmd.Parameters.AddWithValue("@Existencias", Existencias);
            cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            cmd.Parameters.AddWithValue("@ArticulosProvistos", ArticulosProvistos);
            cmd.Parameters.AddWithValue("@NoFabricasAlternativas", NoFabricasAlternativa);
            cmd.ExecuteNonQuery();
            Conexion.cerrarcadena();
        }
        #endregion

        #region MODIFICAR ARTICULO
        public void edit_artic(int IdArticulo, string Descripción_Articulo, int Existencias, Double PrecioUnitario, int IdFabrica, int ArticulosProvistos, int NoFabricasAlternativa)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_actualizar_articulo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            cmd.Parameters.AddWithValue("@Descripción_Articulo", Descripción_Articulo);
            cmd.Parameters.AddWithValue("@Existencias", Existencias);
            cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            cmd.Parameters.AddWithValue("@ArticulosProvistos", ArticulosProvistos);
            cmd.Parameters.AddWithValue("@NoFabricasAlternativas", NoFabricasAlternativa);
            cmd.ExecuteNonQuery();
            Conexion.cerrarcadena();
        }
        #endregion

        #region METODO ELIMINAR ARTICULOS
        public void eliminar_articulo(int IdArticulo)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_eliminar_articulo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            cmd.ExecuteNonQuery();
            Conexion.cerrarcadena();
        }
        #endregion

        #region CARGAR COMBO FABRICA
        public DataTable CargarComboFabrica()
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_cargarComboFabrica";
            cmd.CommandType = CommandType.StoredProcedure;
            leerCBX = cmd.ExecuteReader();
            tabla.Load(leerCBX);
            Conexion.cerrarcadena();
            return tabla;
        }
        #endregion
    }
}
