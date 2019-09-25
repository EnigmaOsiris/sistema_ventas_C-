using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class Conexion
    {
        private SqlConnection Con; 

        public static string Cn = @"Data Source=DESKTOP-83UAHC6; Initial Catalog=Sistemas; Integrated Security=true";

        public bool conectar()
        {
            try
            {
                Con = new SqlConnection(Cn);
                Con.Open();
                return true;               
            }
            catch(Exception ex)
            {
                return false;
            }

        }
        public SqlConnection getConexion()
        {
            return Con;
        }
    }
}
