using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace NEGOCIO
{
    public class CN_INTEGRANTES
    {
        //hacer referencia a la clase de la capa de datos
        private Da_integrantes integrantes_da = new Da_integrantes();

        //metodo para insertar integrante
        public void insertar_integrante(string USUARIO, string CELULAR, string PAIS_NACIONALIDAD, DateTime FECHA_INGRESO, string COMENTARIO, string ESTADO)
        {
            integrantes_da.insertar(USUARIO, CELULAR, PAIS_NACIONALIDAD, FECHA_INGRESO, COMENTARIO, ESTADO);
        }

    }
}
