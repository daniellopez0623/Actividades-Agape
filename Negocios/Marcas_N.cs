using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Marcas_N
    {
        Marcas_D objM_D = new Marcas_D();

        public DataTable MostrandoMarcas_N()
        {
            return objM_D.MostrarMarcas_D();
        }
        public DataTable BuscandoMarcas_N()
        {
            return objM_D.BuscarMarcas_D();
        }      
        public void GuardandoMarcas_N()
        {
            objM_D.GuardarMarcas_D();
        }
        public void EditandoMarcas_N()
        {
            objM_D.EditarMarcas_D();
        }
        public void BorrandoMarcas_N()
        {
            objM_D.BorrarMarcas_D();
        }      
    }
}
