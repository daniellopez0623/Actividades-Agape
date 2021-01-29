using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados_E
    {
        private int IdEmpleado;
        private int CodigoEmpleado;
        private string Nombre;
        private string Apellido;
        private string Email;
        private DateTime FechaNacimiento;

        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public int CodigoEmpleado1 { get => CodigoEmpleado; set => CodigoEmpleado = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
    }
}
