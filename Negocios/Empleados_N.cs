using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Empleados_N
    {
        Empleados_D ObjEmp_D = new Empleados_D();

        public DataTable MostrandoEmpleados_N()
        {
            return ObjEmp_D.MostrarEmpleados_D();
        }
        public DataTable BuscandoEmpleados_N()
        {
            return ObjEmp_D.BuscarEmpleados_D();
        }

        public void GuardandoEmpleados_N()
        {
            ObjEmp_D.GuardarEmpleados_D();
        }

        public void EditandoEmpleados_N()
        {
            ObjEmp_D.EditarEmpleados_D();
        }

        public void BorrandoEmpleados_N()
        {
            ObjEmp_D.BorrarEmpleados_D();
        }
    }
}
