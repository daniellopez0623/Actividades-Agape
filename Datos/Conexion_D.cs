using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class Conexion_D
    {
        private readonly string cnxx;

        protected SqlConnection cxn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public Conexion_D()
        {
            cnxx = (ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        }
        protected SqlConnection GetCnx()
        {
            return new SqlConnection(cnxx);
        }
    }
}
