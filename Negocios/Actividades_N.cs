using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Actividades_N
    {
        Actividades_D ObjAct_D = new Actividades_D();

        public DataTable MostrandoActividades_N()
        {
            return ObjAct_D.MostrarActividades_D();
        }
        public DataTable BuscandoActividades_N()
        {
            return ObjAct_D.BuscarActividades_D();
        }

        public void GuardandoActividades_N()
        {
            ObjAct_D.GuardarActividades_D();
        }

        public void EditandoActividades_N()
        {
            ObjAct_D.EditarActividades_D();
        }

        public void BorrandoActividades_N()
        {
            ObjAct_D.BorrarActividades_D();
        }
    }
}
