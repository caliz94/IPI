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

//        @IdCliente INT,
//@IdDireccion INT,
//@Cantidad INT,
//@Activo BIT,
//@IdArticulo INT,
//@IdFabrica INT

        //********************************* aqui tambien agrege cantidad
        public void GuardarVenta(int IdCliente,int Cantidad, int IdDireccion, byte Activo, int IdArticulo, int IdFabrica)
        {
            //tabla.Clear();
            //cmd.Parameters.Clear();

            //tabla.Columns.Add("IdArticulo");
            ////tabla.Columns.Add("IdPedido");
            //tabla.Columns.Add("Cantidad");
            //tabla.Columns.Add("Fabrica");

            //foreach (var elemento in LstDetalleVenta)
            //{
            //    tabla.Rows.Add(elemento.IdArticulo, /*elemento.IdPedido,*/ elemento.Cantidad, elemento.IdFabrica);
            //}

            cmd.Connection = Conexion.abrircadena();
            cmd.CommandText = "sp_GuardarVenta";
            //var parametroLista = new SqlParameter("@LstDetalles", SqlDbType.Structured);
            //parametroLista.TypeName = "dbo.detalleVenta";
            //parametroLista.Value = tabla;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@IdDireccion", IdDireccion);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            cmd.Parameters.AddWithValue("@IdFabrica", IdFabrica);

            //cmd.Parameters.Add(parametroLista);

            cmd.ExecuteNonQuery();
            cmd.Connection = Conexion.cerrarcadena();
        }


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



        #region COMBO DIRECCIONES
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
    }
}
