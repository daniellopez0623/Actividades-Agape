using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RegistroActividades_E
    {
        private int IdRegistro; 
        private int IdEmpleados;
        private int IdActividades;
        private int IdSucursales;
        private int FechaRegistro;

        public int IdRegistro1 { get => IdRegistro; set => IdRegistro = value; }
        public int IdEmpleados1 { get => IdEmpleados; set => IdEmpleados = value; }
        public int IdActividades1 { get => IdActividades; set => IdActividades = value; }
        public int IdSucursales1 { get => IdSucursales; set => IdSucursales = value; }
        public int FechaRegistro1 { get => FechaRegistro; set => FechaRegistro = value; }
    }
}
