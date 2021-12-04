using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_Datos;

namespace CL_Logica
{
    public class CL_Articulos
    {
        CD_Articulos articulos_cd = new CD_Articulos();
        public void NuevoArticulo(string Descripción_Articulo, int Existencias, Double PrecioUnitario, int IdFabrica, int ArticulosProvistos, int NoFabricasAlternativa)
        {
            articulos_cd.nuevo_artic( Descripción_Articulo, Existencias, PrecioUnitario, IdFabrica, ArticulosProvistos, NoFabricasAlternativa);
        }

        public void EditarArticulo(int IdArticulo, string Descripción_Articulo, int Existencias, Double PrecioUnitario, int IdFabrica, int ArticulosProvistos, int NoFabricasAlternativa)
        {
            articulos_cd.edit_artic(IdArticulo, Descripción_Articulo, Existencias, PrecioUnitario, IdFabrica, ArticulosProvistos, NoFabricasAlternativa);
        }
    }
}
