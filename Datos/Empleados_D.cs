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
        Empleados_E ObjEmp_E = new Empleados_E();
        
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
            SqlCommand cmd = new SqlCommand("SP_Buscar_Empleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@CodigoEmpleado", ObjEmp_E.CodigoEmpleado1);
           
            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Empleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoEmpleado", ObjEmp_E.CodigoEmpleado1);
            cmd.Parameters.AddWithValue("@Nombre", ObjEmp_E.Nombre1);
            cmd.Parameters.AddWithValue("@Apellido", ObjEmp_E.Apellido1);
            cmd.Parameters.AddWithValue("@Email", ObjEmp_E.Email1);
            cmd.Parameters.AddWithValue("@FechaNacimiento", ObjEmp_E.FechaNacimiento1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Empleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdEmpleado", ObjEmp_E.IdEmpleado1);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", ObjEmp_E.CodigoEmpleado1);
            cmd.Parameters.AddWithValue("@Nombre", ObjEmp_E.Nombre1);
            cmd.Parameters.AddWithValue("@Apellido", ObjEmp_E.Apellido1);
            cmd.Parameters.AddWithValue("@Email", ObjEmp_E.Email1);
            cmd.Parameters.AddWithValue("@FechaNacimiento", ObjEmp_E.FechaNacimiento1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void BorrarEmpleados_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Empleados", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoEmpleado", ObjEmp_E.CodigoEmpleado1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
