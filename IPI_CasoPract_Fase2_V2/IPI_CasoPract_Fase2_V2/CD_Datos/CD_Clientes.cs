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


        //Metodo Nuevo Cliente
        public void nuevo_cliente(string NombreCliente, string Saldo, string LimiteCredito, string Descuento)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_nuevoCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);
            cmd.Parameters.AddWithValue("@LimiteCredito", LimiteCredito);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
        }


        //Editar Cliente
        public void act_cliente(int IdCliente, string NombreCliente, string Saldo, string @Limite, string Descuento, int activo)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_ActualizarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
            cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);
            cmd.Parameters.AddWithValue("@@Limite", @Limite);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@activo", activo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
        }


        //Eliminar Cliente
        public void del_client(int @IdCliente)
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_eliminarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Conexion.cerrarcadena();
        }


        //Mostrar Todos los Clientes 
        SqlDataReader leerdata;
        DataTable tabla = new DataTable();
        public DataTable MostrarClientes()
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_mostrarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            leerdata = cmd.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }


        //Mostrar Clientes Inactivos
        public DataTable ClientesInactivos()
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_mostrarClientesInactivos";
            cmd.CommandType = CommandType.StoredProcedure;
            leerdata = cmd.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }
        //mostrar clientes activos     

        public DataTable ClientesActivos()
        {
            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_mostrarClientesActivos";
            cmd.CommandType = CommandType.StoredProcedure;
            leerdata = cmd.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }
    }
}
