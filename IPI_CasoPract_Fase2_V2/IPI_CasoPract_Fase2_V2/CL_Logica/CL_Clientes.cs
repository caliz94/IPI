using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CD_Datos;
    
namespace CL_Logica
{
    
   public class CL_Clientes
    {
        private CD_Clientes clientes_cd = new CD_Clientes();


        // Crear nuevo cliente
        public void nuevo_cliente(string NombreCliente, string Saldo, string LimiteCredito, string Descuento)
        {
            clientes_cd.nuevo_cliente(NombreCliente, Saldo, LimiteCredito, Descuento);
        }


        // Actualizar Cliente
        public void act_cliente(int IdCliente, string NombreCliente, string Saldo, string Limite, string Descuento, int activo)
        {
            clientes_cd.act_cliente(IdCliente, NombreCliente, Saldo, Limite, Descuento, activo);
        }


        // Eliminar Clientes
        public void eliminar_cliente(int IdCliente)
        {
            clientes_cd.del_client(IdCliente);
        }


        // Mostrar Clientes Activos
        public DataTable clientes_activos()
        {
            DataTable tabla = new DataTable();
            tabla = clientes_cd.ClientesActivos();
            return tabla;
        }

        // Mostrar Clientes Inactivos
        public DataTable clientes_inactivos()
        {
            DataTable tabla = new DataTable();
            tabla = clientes_cd.ClientesInactivos();
            return tabla;
        }
        //mostarr cliente activos
        public DataTable mostrarclientes()
        {
            DataTable tabla = new DataTable();
            tabla = clientes_cd.MostrarClientes();
            return tabla;
        }
    }
}
