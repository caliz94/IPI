using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_Datos;
using System.Data;

namespace CL_Logica
{
    public class CL_Articulos
    {
        CD_Articulos articulos_cd = new CD_Articulos();

        //mostrar articulos
        public DataTable Mostrar_articulos()
        {
            DataTable tabla = new DataTable();
            tabla = articulos_cd.Mostrar_articulos();
            return tabla;
        }
        //nuevo articulo
        public void NuevoArticulo(/*int IdArticulo,*/string Descripción_Articulo, int Existencias, Double PrecioUnitario, int IdFabrica, int ArticulosProvistos, int NoFabricasAlternativa)
        {
            articulos_cd.nuevo_artic(/*IdArticulo,*/ Descripción_Articulo, Existencias, PrecioUnitario, IdFabrica, ArticulosProvistos, NoFabricasAlternativa);
        }
        //actualizar articulo

        public void EditarArticulo(int IdArticulo, string Descripción_Articulo, int Existencias, Double PrecioUnitario, int IdFabrica, int ArticulosProvistos, int NoFabricasAlternativa)
        {
            articulos_cd.edit_artic(IdArticulo, Descripción_Articulo, Existencias, PrecioUnitario, IdFabrica, ArticulosProvistos, NoFabricasAlternativa);
        }

        //eliminar articulo
        public void Eliminar_articulo(string IdArticulo)
        {
            articulos_cd.eliminar_articulo(Convert.ToInt32(IdArticulo));
        }
    }
}
