using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_Datos;
using System.Data;

namespace CL_Logica
{
    public class CL_Direcciones
    {
        CD_Direcciones Direcciones_CD = new CD_Direcciones();

        // Mostrar Clientes Activos
        public DataTable clientes_activos()
        {
            DataTable tabla = new DataTable();
            tabla = Direcciones_CD.cliente_direc();
            return tabla;
        }
        //public DataTable DirecionesCliente(int idcliente)
        //{
        //    DataTable tabla = new DataTable();
        //   tabla= Direcciones_CD.DirecciionesDelCliente(idcliente);
            
        //    return tabla;
        //}


        // Crear nuevo direccion
        public void nueva_direccion( int IdCliente, string Calle, string Barrio, string Distrito)
        {
            Direcciones_CD.nuevo_Direcion(IdCliente,  Calle,  Barrio,  Distrito);
        }
        // actualizar direccion
        public void actualizar_direc(int IdDireccion, string Calle, string Barrio, string Distrito)
        {
            Direcciones_CD.actualizar_Direcion(IdDireccion, Calle, Barrio, Distrito);
        }
    }
}
