using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciaDetalle.Entidades
{
    public class Estudiante
    {
        [key]
        public int Estudianteid { get; set; }
        public string Nombres { get; set; }

        public Estudiante() { }
    }
}
