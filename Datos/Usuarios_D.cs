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
        Usuarios_E ObjEntidades = new Usuarios_E();

        public DataTable MostrarUsuarios_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_Usuarios", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }

        public DataTable BuscarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Buscar_Usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoEmpleado", ObjEntidades.IdEmpleados1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdEmpleados", ObjEntidades.IdEmpleados1);
            cmd.Parameters.AddWithValue("@IdRoles", ObjEntidades.IdRoles1);
            cmd.Parameters.AddWithValue("@_Password", ObjEntidades.Password);
            cmd.Parameters.AddWithValue("@FechaCreacion", ObjEntidades.FechaCreacion1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdUsuario", ObjEntidades.IdUsuario1);
            cmd.Parameters.AddWithValue("@IdEmpleados", ObjEntidades.IdEmpleados1);
            cmd.Parameters.AddWithValue("@IdRoles", ObjEntidades.IdRoles1);
            cmd.Parameters.AddWithValue("@_Password", ObjEntidades.Password);
            cmd.Parameters.AddWithValue("@FechaCreacion", ObjEntidades.FechaCreacion1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void BorrarUsuarios_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdUsuario", ObjEntidades.IdUsuario1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public DataTable LogingUsuarios_D()
        {
            SqlCommand Command = new SqlCommand("SP_Loging", cxn);
            Command.CommandType = CommandType.StoredProcedure;

            cxn.Open();
             Command.Parameters.AddWithValue("@_user", ObjEntidades.Usuario1);
             Command.Parameters.AddWithValue("@_pass", ObjEntidades.Password);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cxn.Close();

            return dataTable;
        }
    }
}
