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

        public void nuevo_cliente(string NombreCliente, string Saldo, string LimiteCredito, string Descuento, int Activo)
        {
            clientes_cd.nuevo_cliente(NombreCliente, Saldo, LimiteCredito, Descuento, Activo);
        }
            
    }
}
