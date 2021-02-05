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
        Usuarios_D ObjUsr_D = new Usuarios_D();

        public DataTable MostrandoUsuarios_N()
        {
            return ObjUsr_D.MostrarUsuarios_D();
        }
        public DataTable BuscandoUsuarios_N()
        {
            return ObjUsr_D.BuscarUsuarios_D();
        }

        public void GuardandoUsuarios_N()
        {
            ObjUsr_D.GuardarUsuarios_D();
        }

        public void EditandoUsuarios_N()
        {
            ObjUsr_D.EditarUsuarios_D();
        }

        public void BorrandoUsuarios_N()
        {
            ObjUsr_D.BorrarUsuarios_D();
        }
        public DataTable LogeandoUsuarios_N()
        {
            return ObjUsr_D.LogingUsuarios_D();
        }
    }
}
