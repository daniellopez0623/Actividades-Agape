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
    public class Sucursales_D : Conexion_D
    {

        public DataTable MostrarMarcaSucursales_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_SucursalesMarca", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }
        public DataTable MostrarSucursales_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_Sucursales", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }
        public DataTable MostrarAdmSucursales_D()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_SucursalesAdm", cxn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cxn.Close();
            return dt;
        }

        public DataTable BuscarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectSucursales", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@NombreSucursal", Sucursales_E.NombreSucursal1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }
        public DataTable BuscarAdmSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_selectAdminSucursal", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@NombreSucursal", Sucursales_E.NombreSucursal1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_insertSucursales", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@NombreSucursal", Sucursales_E.NombreSucursal1);
            cmd.Parameters.AddWithValue("@IdMarcas", Sucursales_E.IdDiviciones1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_updateSucursales", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idSucursal", Sucursales_E.IdSucursal1);
            cmd.Parameters.AddWithValue("@NombreSucursal", Sucursales_E.NombreSucursal1);
            cmd.Parameters.AddWithValue("@IdMarcas", Sucursales_E.IdDiviciones1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void BorrarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_deleteSucursal", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@idSucursal", Sucursales_E.IdSucursal1);
            cmd.Parameters.AddWithValue("@IdMarcas", Sucursales_E.IdDiviciones1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
