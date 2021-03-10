using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sucursales_E
    {
        private static int IdSucursal;
        private static int IdDiviciones; 
        private static string NombreSucursal;

        public static int IdSucursal1 { get => IdSucursal; set => IdSucursal = value; }
        public static int IdDiviciones1 { get => IdDiviciones; set => IdDiviciones = value; }
        public static string NombreSucursal1 { get => NombreSucursal; set => NombreSucursal = value; }
    }
}
