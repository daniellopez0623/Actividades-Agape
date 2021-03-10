using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class RegistroActividades_E
    {
        private static int IdRegistro; 
        private static int CodeEmpleados;
        private static int IdActividades;
        private static int IdSucursales;
        private static DateTime Fecha;
        private static DateTime Hora;

        public static int IdRegistro1 { get => IdRegistro; set => IdRegistro = value; }
        public static int CodeEmpleados1 { get => CodeEmpleados; set => CodeEmpleados = value; }
        public static int IdActividades1 { get => IdActividades; set => IdActividades = value; }
        public static int IdSucursales1 { get => IdSucursales; set => IdSucursales = value; }
        public static DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public static DateTime Hora1 { get => Hora; set => Hora = value; }
    }
}
