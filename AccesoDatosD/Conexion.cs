using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AccesoDatosD
{
    internal class Conexion
    {
        private string bbd;
        private string serv;
        private string user;
        private string pass;
        private bool security;
        private static Conexion conne = null;

        private Conexion() 
        {
            this.bbd = "Productos";
            this.serv = "MATC21\\ITQ";
            this.user = "Desa";
            this.pass = "m1727577403";
            this.security = true;
        }

        public SqlConnection crearConexion() 
        {
            SqlConnection cadena = new SqlConnection();
            try 
            { 
                cadena .ConnectionString = "Server=" + this.serv + ";Database=" + this.bbd + ";";
                if (this.security) 
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else 
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.user + ";Password=" + this.pass;
                }
            }
            catch (Exception ex) 
            {
                cadena = null;
                throw ex;
            }
            return cadena; 
        }

        public static Conexion crearInstancia() 
        { 
            if(conne == null) 
            { 
                conne = new Conexion();
            }
            return conne;
        }

    }
}
