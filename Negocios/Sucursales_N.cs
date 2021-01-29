using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Sucursales_N
    {
        Sucursales_D ObjScl_D = new Sucursales_D();

        public DataTable MostrandoSucursales_N()
        {
            return ObjScl_D.MostrarSucursales_D();
        }
        public DataTable BuscandoSucursales_N()
        {
            return ObjScl_D.BuscarSucursales_D();
        }

        public void GuardandoSucursales_N()
        {
            ObjScl_D.GuardarSucursales_D();
        }

        public void EditandoSucursales_N()
        {
            ObjScl_D.EditarSucursales_D();
        }

        public void BorrandoSucursales_N()
        {
            ObjScl_D.BorrarSucursales_D();
        }
    }
}
