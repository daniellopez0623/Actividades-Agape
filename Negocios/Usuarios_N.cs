using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Usuarios_N
    {
        Usuarios_D ObjU_D = new Usuarios_D();

        public DataTable MostrandoUsuarios_N()
        {
            return ObjU_D.MostrarUsuarios_D();
        }
        public DataTable BuscandoUsuarios_N()
        {
            return ObjU_D.BuscarUsuarios_D();
        }
        public DataTable BuscandoAdmUsuarios_N()
        {
            return ObjU_D.BuscarAdmUsuarios_D();
        }
        public DataTable MostrandoRoles_D()
        {
            return ObjU_D.MostrarRoles_D();
        }

        public void GuardandoUsuarios_N()
        {
            ObjU_D.GuardarUsuarios_D();
        }

        public void EditandoUsuarios_N()
        {
            ObjU_D.EditarUsuarios_D();
        }

        public void BorrandoUsuarios_N()
        {
            ObjU_D.BorrarUsuarios_D();
        }
        public DataTable LogeandoUsuarios_N()
        {
            return ObjU_D.LogingUsuarios_D();
        }
    }
}
