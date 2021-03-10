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
    public class Empleados_D : Conexion_D
    {
       // Empleados_E ObjEmp_E = new Empleados_E();
        
        public DataTable MostrarEmpleados_D()
        {
            cxn.Open();

            SqlCommand cmd = new SqlCommand("Select * from VW_Empleados", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cxn.Close();

            return dt;
        }
        public DataTable BuscarEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectEmpleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@CodigoEmpleado", Empleados_E.CodigoEmpleado1);
           
            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }
        public DataTable BuscarAdmEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectAdmEmpleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@CodigoEmpleado", Empleados_E.CodigoEmpleado1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }
        public void GuardarEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_insertEmpleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoEmpleado", Empleados_E.CodigoEmpleado1);
            cmd.Parameters.AddWithValue("@Nombre", Empleados_E.Nombre1);
            cmd.Parameters.AddWithValue("@Apellido", Empleados_E.Apellido1);
            cmd.Parameters.AddWithValue("@Email", Empleados_E.Email1);
            cmd.Parameters.AddWithValue("@Telefono", Empleados_E.Telefono1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void EditarEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_updateEmpleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idEmpleados", Empleados_E.IdEmpleado1);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", Empleados_E.CodigoEmpleado1);
            cmd.Parameters.AddWithValue("@Nombre", Empleados_E.Nombre1);
            cmd.Parameters.AddWithValue("@Apellido", Empleados_E.Apellido1);
            cmd.Parameters.AddWithValue("@Email", Empleados_E.Email1);
            cmd.Parameters.AddWithValue("@Telefono", Empleados_E.Telefono1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void BorrarEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_deleteEmpleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idEmpleados", Empleados_E.IdEmpleado1);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", Empleados_E.CodigoEmpleado1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
