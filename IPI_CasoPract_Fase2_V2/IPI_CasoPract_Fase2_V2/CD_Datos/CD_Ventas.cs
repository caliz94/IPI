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

        #region GUARDAR VENTA
        public void GuardarVenta(int IdCliente,int Cantidad, int IdDireccion, byte Activo, int IdArticulo, int IdFabrica)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_GuardarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@IdDireccion", IdDireccion);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            cmd.ExecuteNonQuery();
            cmd.Connection = Conexion.cerrarcadena();
        }
        #endregion

        #region AGREGAR PRODUCTOS A UNA VENTA
        public void AgregarProductoVenta(int IdCliente, int IdDireccion, int IdArticulo, int Cantidad, int IdFabrica)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_cargarmasarticulos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
            cmd.Parameters.AddWithValue("@IdDireccion", IdDireccion);
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            cmd.ExecuteNonQuery();
            cmd.Connection = Conexion.cerrarcadena();
        }
        #endregion

        #region CARGA COMBO DIRECCIONES
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
        #endregion

        #region CARGA INFORMACIÓN DEL PEDIDO

        SqlDataReader leerdata_pedido;
        DataTable tabla_pedido = new DataTable();

        public DataTable ObtieneInformacionPedido(int IdPedido)
        {
            tabla_pedido.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_ObtienePedido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
            leerdata_pedido = cmd.ExecuteReader();
            tabla_pedido.Load(leerdata_pedido);
            Conexion.cerrarcadena();
            return tabla_pedido;
        }
        #endregion

        #region CARGA DETALLE DEL PEDIDO
        public DataTable ObtieneDetallePedido(int IdPedido)
        {
            tabla.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_ObtieneDetallePedido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
            leerdata = cmd.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }
        #endregion


        #region CARGA todos los PEDIDOs
        SqlDataReader leer_todos_data_pedido;
        DataTable tabla_todos_pedido = new DataTable();
        public DataTable ObtienetodosPedido()
        {
            tabla_todos_pedido.Clear();
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_Mostrar_Todos_Pedidos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();

            leer_todos_data_pedido = cmd.ExecuteReader();
            tabla_todos_pedido.Load(leer_todos_data_pedido);
            Conexion.cerrarcadena();
            return tabla_todos_pedido;
        }
        #endregion
    }
}
