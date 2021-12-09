using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_Datos;
using System.Data;

namespace CL_Logica
{
    public class CL_Ventas
    {
        #region CREACIÓN DE OBJETOS
        CD_Ventas OVentas = new CD_Ventas();
        CD_Clientes OClientes = new CD_Clientes();
        CD_Articulos OArticulo = new CD_Articulos();
        #endregion

        #region CARGAR COMBO CLIENTES
        public DataTable CargarComboClientes()
        {
            DataTable tabla = new DataTable();
            tabla = OClientes.CargarComboClientes();
            return tabla;
        }
        #endregion

        #region CARGAR COMBO PRODUCTOS
        public DataTable CargarComboProductos()
        {
            DataTable tabla = new DataTable();
            tabla = OArticulo.CargarComboArticulos();
            return tabla;
        }
        #endregion

        #region CARGAR INFORMACIÓN PEDIDOS
        public DataTable ObtieneInformacionPedido(int IdPedido)
        {
            DataTable tabla = new DataTable();
            tabla = OVentas.ObtieneInformacionPedido(IdPedido);
            return tabla;
        }
        #endregion

        #region CARGAR DETALLE DE PEDIDOS
        public DataTable ObtieneDetallePedido(int IdPedido)
        {
            DataTable tabla = new DataTable();
            tabla = OVentas.ObtieneDetallePedido(IdPedido);
            return tabla;
        }
        #endregion

        #region CARGAR COMBO DIRECCIONES
        public DataTable CargarComboDirecciones(int IdCliente)
        {
            DataTable tabla = new DataTable();
            tabla = OVentas.CargarComboDirecciones(IdCliente);
            return tabla;
        }
        #endregion

        #region GUARDAR VENTA
        public void GuardarVenta(int IdCliente, int Cantidad, int IdDireccion, byte Activo, int IdArticulo, int IdFabrica)
        {
            OVentas.GuardarVenta(IdCliente, Cantidad, IdDireccion, Activo, IdArticulo, IdFabrica);
        }
        #endregion

        #region AGREGAR PRODUCTO VENTA
        public void AgregarProductoVenta(int IdCliente, int IdDireccion, int IdArticulo, int Cantidad, int IdFabrica)
        {
            OVentas.AgregarProductoVenta(IdCliente, IdDireccion, IdArticulo, Cantidad, IdFabrica);
        }
        #endregion

        #region OBTENER EXISTENCIA ARTICULOS
        public int ObtenerExistenciaArticulos(int IdArticulo)
        {
            int existencia;
            existencia = OArticulo.CargarExistencias(IdArticulo);
            return existencia;
        }
        #endregion

        #region OBTENER PRECIOS ARTICULOS
        public float ObtenerPrecioArticulos(int IdArticulo)
        {
            float existencia;
            existencia = OArticulo.CargarPrecios(IdArticulo);
            return existencia;
        }
        #endregion
        public DataTable optenerPedido(int IdPedido)
        {
            DataTable tabla_p = new DataTable();
            tabla_p = OVentas.ObtieneInformacionPedido(IdPedido);
            return tabla_p;
        }

        public DataTable OptenerDetallePedido(int IdPedido)
        {
            DataTable tabla_p = new DataTable();
            tabla_p = OVentas.ObtieneDetallePedido(IdPedido);
            return tabla_p;
        }

        public DataTable OptenertodosPedido()
        {
            DataTable tabla_p = new DataTable();
            tabla_p = OVentas.ObtienetodosPedido();
            return tabla_p;
        }

    }
}
