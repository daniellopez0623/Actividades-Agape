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
    public class RegistroActividades_D : Conexion_D
    {
        RegistroActividades_E ObjRgt_E = new RegistroActividades_E();

        public DataTable MostrarRegistros_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_Registros", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }

        public DataTable BuscarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Buscar_Registro", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdRegistro", ObjRgt_E.IdRegistro1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Registro", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdEmpleados", ObjRgt_E.IdEmpleados1);
            cmd.Parameters.AddWithValue("@IdActividades", ObjRgt_E.IdActividades1);
            cmd.Parameters.AddWithValue("@IdSucursales", ObjRgt_E.IdSucursales1);
            cmd.Parameters.AddWithValue("@FechaRegistro", ObjRgt_E.FechaRegistro1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Registro", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdRegistro", ObjRgt_E.IdRegistro1);
            cmd.Parameters.AddWithValue("@IdEmpleados", ObjRgt_E.IdEmpleados1);
            cmd.Parameters.AddWithValue("@IdActividades", ObjRgt_E.IdActividades1);
            cmd.Parameters.AddWithValue("@IdSucursales", ObjRgt_E.IdSucursales1);
            cmd.Parameters.AddWithValue("@FechaRegistro", ObjRgt_E.FechaRegistro1);

            cmd.ExecuteNonQuery();


            cxn.Close();
        }

        public void BorrarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Registro", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdRegistro", ObjRgt_E.IdRegistro1);
            cmd.Parameters.AddWithValue("@IdEmpleados", ObjRgt_E.IdEmpleados1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
