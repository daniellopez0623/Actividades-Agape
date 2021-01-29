using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class RegistroActividades_N
    {
        RegistroActividades_D ObjDatos = new RegistroActividades_D();

        public DataTable MostrandoRegistros_N()
        {
            return ObjDatos.MostrarRegistros_D();
        }

        public DataTable BuscandoRegistros_N()
        {
            return ObjDatos.BuscarRegistros_D();
        }

        public void GuardandoRegistros_N()
        {
            ObjDatos.GuardarRegistros_D();
        }

        public void EditandoRegistros_N()
        {
            ObjDatos.EditarRegistros_D();
        }

        public void BorrandoRegistros_N()
        {
            ObjDatos.BorrarRegistros_D();
        }
    }
}
