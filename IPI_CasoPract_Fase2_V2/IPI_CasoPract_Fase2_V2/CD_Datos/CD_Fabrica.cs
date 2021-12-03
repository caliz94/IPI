using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CD_Datos
{
    public class CD_Fabrica
    {
        private CD_Conexion Conexion = new CD_Conexion();

        SqlDataReader leerdata;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        #region Mostrar Fabricas
        public DataTable Mostrar()
        {
            tabla.Clear();
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_mostrarFabricas";
            comando.CommandType = CommandType.StoredProcedure;
            leerdata = comando.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;

        }


        public DataTable MostrarFabActivas()
        {
            tabla.Clear();
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_mostrarFabricasActivas";
            comando.CommandType = CommandType.StoredProcedure;
            leerdata = comando.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }


        public DataTable MostrarFabInactivas()
        {
            tabla.Clear();
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_mostrarFabricasInactivos";
            comando.CommandType = CommandType.StoredProcedure;
            leerdata = comando.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }
        #endregion

        #region Nueva Fabrica
        public void InsertarFabrica(string nombre, string telefono)
        {
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_nuevaFabrica";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreFabrica", nombre);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Conexion.cerrarcadena();
        }
        #endregion

        public DataTable CargarComboFabrica()
        {
            //tabla.Clear();
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_cargarComboFabrica";
            comando.CommandType = CommandType.StoredProcedure;
            leerdata = comando.ExecuteReader();
            tabla.Load(leerdata);
            Conexion.cerrarcadena();
            return tabla;
        }

        public void EliminarFabrica(int IdFabrica)
        {
            comando.Connection = Conexion.abrircadena();
            comando.CommandText = "sp_eliminarFabrica";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdFabrica", IdFabrica);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Conexion.cerrarcadena();
        }
    }
}
