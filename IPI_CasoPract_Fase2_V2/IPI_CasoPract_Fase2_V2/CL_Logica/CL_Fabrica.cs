using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CD_Datos;

namespace CL_Logica
{
    public class CL_Fabrica
    {
        private CD_Fabrica OFabrica = new CD_Fabrica();


        public DataTable MostrarFabricas()
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.Mostrar();
            return tabla;
        }

        public DataTable BuscarFabricaxId(int IdFabrica)
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.BuscaFabricaxId(IdFabrica);
            return tabla;
        }

        public DataTable BuscaFabricaxNombre(string Nombre)
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.BuscaFabricaxNombre(Nombre);
            return tabla;
        }


        public DataTable MostrarCamposFabricas()
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.MostrarCamposFabricas();
            return tabla;
        }


        public DataTable MostrarFabricasAct()
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.MostrarFabActivas();
            return tabla;
        }

        public DataTable MostrarFabricasInac()
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.MostrarFabInactivas();
            return tabla;
        }


        public void InsertarFabrica(string nombre, string telefono)
        {
            OFabrica.InsertarFabrica(nombre, telefono);
        }


        public DataTable CargarComboFabrica()
        {
            DataTable tabla = new DataTable();
            tabla = OFabrica.CargarComboFabrica();
            return tabla;
        }


        public void EliminarFabrica(int IdFabrica)
        {
            OFabrica.EliminarFabrica(IdFabrica);
        }

        public void ActualizarFabrica(int IdFabrica, string NombreFabrica, string Telefono, byte Activo)
        {
            OFabrica.ActualizarFabrica(IdFabrica, NombreFabrica, Telefono, Activo);
        }
    }
}
