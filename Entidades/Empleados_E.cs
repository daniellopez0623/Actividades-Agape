using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Empleados_E
    {
        private static int IdEmpleado;
        private static int CodigoEmpleado;
        private static string Nombre;
        private static string Apellido;
        private static string Email;
        private static string Telefono;

        public static int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public static int CodigoEmpleado1 { get => CodigoEmpleado; set => CodigoEmpleado = value; }
        public static string Nombre1 { get => Nombre; set => Nombre = value; }
        public static string Apellido1 { get => Apellido; set => Apellido = value; }
        public static string Email1 { get => Email; set => Email = value; }
        public static string Telefono1 { get => Telefono; set => Telefono = value; }
    }
}
