using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using System.Data;


namespace NEGOCIO
{
   public class cn_MostrarIntegrantes
    {
        private cd_MostrarIntegrantes mostr_intg_cd = new cd_MostrarIntegrantes();
        public DataTable mostar_integ()
        {
            DataTable tabla = new DataTable();
            tabla = mostr_intg_cd.mostrar_integrantes();
            return tabla;
        }
    }
}
