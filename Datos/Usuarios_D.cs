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
    public class Usuarios_D : Conexion_D
    {
       // Usuarios_E ObjUsrE = new Usuarios_E();

        public DataTable MostrarUsuarios_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from vwUsuarios", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }

        public DataTable BuscarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectUsuario", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }
        public DataTable BuscarAdmUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectAdmUsuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@user", Usuarios_E.User1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_insertUsuario", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idRoles", Usuarios_E.User1);
            cmd.Parameters.AddWithValue("@user", Usuarios_E.User1);
            cmd.Parameters.AddWithValue("@pass", Usuarios_E.Pass1);
            cmd.Parameters.AddWithValue("@FechaCreacion", Usuarios_E.FechaCreacion1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_updateUsuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

             cmd.Parameters.AddWithValue("@idUsuarios", Usuarios_E.IdUsuario1);
             cmd.Parameters.AddWithValue("@idRoles", Usuarios_E.User1);
             cmd.Parameters.AddWithValue("@user", Usuarios_E.User1);
             cmd.Parameters.AddWithValue("@pass", Usuarios_E.Pass1);
             cmd.Parameters.AddWithValue("@FechaCreacion", Usuarios_E.FechaCreacion1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void BorrarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_deleteUsuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idUsuarios", Usuarios_E.IdUsuario1);
            cmd.Parameters.AddWithValue("@user", Usuarios_E.User1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public DataTable LogingUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_LoginUser", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
             cmd.Parameters.AddWithValue("@_user", Usuarios_E.User1);
             cmd.Parameters.AddWithValue("@_pass", Usuarios_E.Pass1);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cxn.Close();

            return dataTable;
        }
    }
}
