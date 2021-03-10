using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;


namespace Datos
{
    public class Actividades_D : Conexion_D
    {

        public DataTable MostrarActividades_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_Actividades", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }

        public DataTable BuscarActividades_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectAdmActividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@DescripcionActividad", Actividades_E.DescripcionActividad1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarActividades_D()
        {
            SqlCommand cmd = new SqlCommand("SP_insertActividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@DescripcionActividad", Actividades_E.DescripcionActividad1);
            cmd.Parameters.AddWithValue("@ValorActividad", Actividades_E.ValorActividad1);
            cmd.Parameters.AddWithValue("@NivelActividad", Actividades_E.NivelActividad1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void EditarActividades_D()
        {
            SqlCommand cmd = new SqlCommand("SP_updateActividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idActividades", Actividades_E.IdActividad1);
            cmd.Parameters.AddWithValue("@DescripcionActividad", Actividades_E.DescripcionActividad1);
            cmd.Parameters.AddWithValue("@ValorActividad", Actividades_E.ValorActividad1);
            cmd.Parameters.AddWithValue("@NivelActividad", Actividades_E.NivelActividad1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void BorrarActividades_D()
        {
            SqlCommand cmd = new SqlCommand("SP_deleteActividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idActividades", Actividades_E.IdActividad1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
