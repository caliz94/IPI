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

        public int ObtenerExistenciaArticulos(int IdArticulo)
        {
            int existencia;
            existencia = OArticulo.ObtenerExistencias(IdArticulo);
            return existencia;
        }

    }
}
