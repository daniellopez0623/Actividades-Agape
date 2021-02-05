using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios_E
    {
        private int IdUsuario;
        private int IdEmpleados;
        private int IdRoles;
        private string Usuario;
        private string _Password;
        private DateTime FechaCreacion;

        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public int IdEmpleados1 { get => IdEmpleados; set => IdEmpleados = value; }
        public int IdRoles1 { get => IdRoles; set => IdRoles = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public DateTime FechaCreacion1 { get => FechaCreacion; set => FechaCreacion = value; }
    }
}
