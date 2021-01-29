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
        Sucursales_E ObjScl_E = new Sucursales_E();

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

        public DataTable BuscarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Buscar_Sucursales", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoSucursal", ObjScl_E.CodigoSucursal1);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;
        }

        public void GuardarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Sucursales", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@CodigoSucursal", ObjScl_E.CodigoSucursal1);
            cmd.Parameters.AddWithValue("@NombreSucursal", ObjScl_E.NombreSucursal1);
            cmd.Parameters.AddWithValue("@IdDiviciones", ObjScl_E.IdDiviciones1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void EditarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Sucursales", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdSucursal", ObjScl_E.IdSucursal1);
            cmd.Parameters.AddWithValue("@CodigoSucursal", ObjScl_E.CodigoSucursal1);
            cmd.Parameters.AddWithValue("@NombreSucursal", ObjScl_E.NombreSucursal1);
            cmd.Parameters.AddWithValue("@IdDiviciones", ObjScl_E.IdDiviciones1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }

        public void BorrarSucursales_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Sucursales", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();

            cmd.Parameters.AddWithValue("@IdSucursal", ObjScl_E.IdSucursal1);
            cmd.Parameters.AddWithValue("@CodigoSucursal", ObjScl_E.CodigoSucursal1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
    }
}
