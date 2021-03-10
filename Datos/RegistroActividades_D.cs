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
        public DataTable MostrarRegistrosIDScl_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_RegistrosIdScl", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }
        public DataTable MostrarRegistrosIDAct_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_RegistrosIdActividad", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }

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
        public DataTable MostrarAdmRegistros_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_AdmRegistros", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }

        public DataTable BuscarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectRegistroAct", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoEmpleadosFK", RegistroActividades_E.CodeEmpleados1);
            cmd.Parameters.AddWithValue("@IdActividadesFK", RegistroActividades_E.IdActividades1); 
            cmd.Parameters.AddWithValue("@IdSucursalesFK", RegistroActividades_E.IdSucursales1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }
        public DataTable BuscarAdmRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectAdminRegistroAct", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoEmpleadosFK", RegistroActividades_E.CodeEmpleados1);
            cmd.Parameters.AddWithValue("@IdActividadesFK", RegistroActividades_E.IdActividades1);
            cmd.Parameters.AddWithValue("@IdSucursalesFK", RegistroActividades_E.IdSucursales1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_insertRegistroAct", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@Hora", RegistroActividades_E.Hora1);
            cmd.Parameters.AddWithValue("@Fecha", RegistroActividades_E.Fecha1);
            cmd.Parameters.AddWithValue("@CodigoEmpleadosFK", RegistroActividades_E.CodeEmpleados1);
            cmd.Parameters.AddWithValue("@IdActividadesFK", RegistroActividades_E.IdActividades1);
            cmd.Parameters.AddWithValue("@IdSucursalesFK", RegistroActividades_E.IdSucursales1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_updateRegistoAct", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdRegistro", RegistroActividades_E.IdRegistro1);
            cmd.Parameters.AddWithValue("@Hora", RegistroActividades_E.Hora1);
            cmd.Parameters.AddWithValue("@Fecha", RegistroActividades_E.Fecha1);
            cmd.Parameters.AddWithValue("@CodigoEmpleadosFK", RegistroActividades_E.CodeEmpleados1);
            cmd.Parameters.AddWithValue("@IdActividadesFK", RegistroActividades_E.IdActividades1);
            cmd.Parameters.AddWithValue("@IdSucursalesFK", RegistroActividades_E.IdSucursales1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void BorrarRegistros_D()
        {
            SqlCommand cmd = new SqlCommand("SP_deleteRegistroAct", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdRegistro", RegistroActividades_E.IdRegistro1);            
            cmd.Parameters.AddWithValue("@CodigoEmpleadosFK", RegistroActividades_E.CodeEmpleados1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
