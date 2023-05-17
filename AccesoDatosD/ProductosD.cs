using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntidadesE;

namespace AccesoDatosD
{
    public class ProductosD
    {
        public String InsertarProductos(Productos obj) 
        {
            string respuesta = "";
            SqlConnection connection = new SqlConnection();
            try 
            {
                connection = Conexion.crearInstancia().crearConexion();
                SqlCommand command = new SqlCommand("sp_Ingreso_Producto",connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@strNombre_Producto", SqlDbType.VarChar).Value = obj.Nombre_Producto;
                command.Parameters.Add("@strDescripcion_Producto", SqlDbType.VarChar).Value = obj.Descripcion_Producto;
                command.Parameters.Add("@strCantidad_Producto", SqlDbType.Int).Value = obj.Cantidad_Producto;
                command.Parameters.Add("@strPrecioxUnidad_Producto", SqlDbType.Decimal).Value = obj.PrecioxUnidad_Producto;
                command.Parameters.Add("@strId_Categoria", SqlDbType.Int).Value = obj.Id_Categoria;
                connection.Open();

                respuesta = command.ExecuteNonQuery() == 1 ? "!OK" : "!NO SE PUDO REALIZAR EL INGRESO";

            }
             catch (Exception e) 
            { 
                respuesta = e.Message;
            }
            finally 
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return respuesta;
        }
    }
}
