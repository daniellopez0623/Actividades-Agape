using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Actividades_E
    {
        private static int IdActividad;
        private static string DescripcionActividad;
        private static decimal ValorActividad;
        private static string NivelActividad;
        private static string NotaActividad;

        public static int IdActividad1 { get => IdActividad; set => IdActividad = value; }
        public static string DescripcionActividad1 { get => DescripcionActividad; set => DescripcionActividad = value; }
        public static decimal ValorActividad1 { get => ValorActividad; set => ValorActividad = value; }
        public static string NivelActividad1 { get => NivelActividad; set => NivelActividad = value; }
        public static string NotaActividad1 { get => NotaActividad; set => NotaActividad = value; }
    }
}
