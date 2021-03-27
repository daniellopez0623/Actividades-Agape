using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Usuarios_E
    {
        private static int IdUsuario;
        private static int Idrol;
        private static string User;
        private static string Pass;
        private static DateTime FechaCreacion;
      
        public static string NombreRol;

        public static int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public static int Idrol1 { get => Idrol; set => Idrol = value; }
        public static string User1 { get => User; set => User = value; }
        public static string Pass1 { get => Pass; set => Pass = value; }
        public static DateTime FechaCreacion1 { get => FechaCreacion; set => FechaCreacion = value; }
    }
}
