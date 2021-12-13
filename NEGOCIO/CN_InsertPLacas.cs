using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using System.Data;

namespace NEGOCIO
{
    public class CN_InsertPLacas
    {
        //hacer referencia a la clase de la capa de datos
        private Cd_Placas placas_cd = new Cd_Placas();

        //metodo para insertar integrante
        public void insertar_placas(int ID_INTEGRANTE, int R_PLACAS, string MES, string SEMANA)
        {
            placas_cd.insertar(ID_INTEGRANTE, R_PLACAS, MES, SEMANA);
        }

    }
}
