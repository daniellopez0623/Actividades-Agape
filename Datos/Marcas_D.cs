using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Marcas_D : Conexion_D
    {
        public DataTable MostrarMarcas_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from vwMarcas", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }
     
        public DataTable BuscarMarcas_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectMarcas", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@AliasMarca", Diviciones_E.AliasMarcas1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarMarcas_D()
        {
            SqlCommand cmd = new SqlCommand("SP_insertMarcas", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@AliasMarca", Diviciones_E.AliasMarcas1);
            cmd.Parameters.AddWithValue("@NombreMarca", Diviciones_E.NombreMarcas1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarMarcas_D()
        {
            SqlCommand cmd = new SqlCommand("SP_updateMarcas", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idMarcas", Diviciones_E.IdMarcas1);
            cmd.Parameters.AddWithValue("@AliasMarca", Diviciones_E.AliasMarcas1);
            cmd.Parameters.AddWithValue("@NombreMarca", Diviciones_E.NombreMarcas1);
          
            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void BorrarMarcas_D()
        {
            SqlCommand cmd = new SqlCommand("SP_deleteMarcas", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idMarcas", Diviciones_E.IdMarcas1);
            cmd.Parameters.AddWithValue("@AliasMarca", Diviciones_E.AliasMarcas1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }      
    }
}
