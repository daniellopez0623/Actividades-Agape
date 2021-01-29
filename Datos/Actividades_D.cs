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
        Actividades_E ObjAct_E = new Actividades_E();

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
            SqlCommand cmd = new SqlCommand("SP_Buscar_Actividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@IdActividad", ObjAct_E.IdActividad1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarActividades_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Actividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@DescripcionActividad", ObjAct_E.DescripcionActividad1);
            cmd.Parameters.AddWithValue("@ValorActividad", ObjAct_E.ValorActividad1);
            cmd.Parameters.AddWithValue("@NivelActividad", ObjAct_E.NivelActividad1);
            cmd.Parameters.AddWithValue("@NotaActividad", ObjAct_E.NotaActividad1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarActividades_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Actividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdActividad", ObjAct_E.IdActividad1);
            cmd.Parameters.AddWithValue("@DescripcionActividad", ObjAct_E.DescripcionActividad1);
            cmd.Parameters.AddWithValue("@ValorActividad", ObjAct_E.ValorActividad1);
            cmd.Parameters.AddWithValue("@NivelActividad", ObjAct_E.NivelActividad1);
            cmd.Parameters.AddWithValue("@NotaActividad", ObjAct_E.NotaActividad1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void BorrarActividades_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Actividades", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdActividad", ObjAct_E.IdActividad1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
