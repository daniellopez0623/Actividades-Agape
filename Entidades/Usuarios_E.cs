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
        private static string User;
        private static string Pass;
        private static DateTime FechaCreacion;
      
        private static string nombreRol;

        public static int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public static string User1 { get => User; set => User = value; }
        public static string Pass1 { get => Pass; set => Pass = value; }
        public static DateTime FechaCreacion1 { get => FechaCreacion; set => FechaCreacion = value; }
    
        public static string NombreRol { get => nombreRol; set => nombreRol = value; }
    }
}
