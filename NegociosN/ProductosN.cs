using AccesoDatosD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesE;

namespace NegociosN
{
    public class ProductosN
    {
        public static String InsertarProductos(String Nombre_Producto, String Descripcion_Producto, int Cantidad_Producto, decimal PrecioxUnidad_Producto, int Id_Categoria)
        { 
            ProductosD datos = new ProductosD();
            Productos obj =  new Productos();
            obj.Nombre_Producto = Nombre_Producto;
            obj.Descripcion_Producto = Descripcion_Producto;
            obj.Cantidad_Producto = Cantidad_Producto;
            obj.PrecioxUnidad_Producto = PrecioxUnidad_Producto;
            obj.Id_Categoria = Id_Categoria;
            return datos.InsertarProductos(obj);
        }
    }
}
