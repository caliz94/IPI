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
        CD_Ventas OVentas = new CD_Ventas();
        CD_Clientes OClientes = new CD_Clientes();
        CD_Articulos OArticulo = new CD_Articulos();

        public DataTable CargarComboClientes()
        {
            DataTable tabla = new DataTable();
            tabla = OClientes.CargarComboClientes();
            return tabla;
        }

        public DataTable CargarComboProductos()
        {
            DataTable tabla = new DataTable();
            tabla = OArticulo.CargarComboArticulos();
            return tabla;
        }

        public DataTable CargarComboDirecciones(int IdCliente)
        {
            DataTable tabla = new DataTable();
            tabla = OVentas.CargarComboDirecciones(IdCliente);
            return tabla;
        }

        public void GuardarVenta(int IdCliente, int IdDireccion, byte Activo)
        {
            OVentas.GuardarVenta(IdCliente, IdDireccion, Activo);
        }


        public int ObtenerExistenciaArticulos(int IdArticulo)
        {
            int existencia;
            existencia = OArticulo.CargarExistencias(IdArticulo);
            return existencia;
        }


        public float ObtenerPrecioArticulos(int IdArticulo)
        {
            float existencia;
            existencia = OArticulo.CargarPrecios(IdArticulo);
            return existencia;
        }
    }
}
