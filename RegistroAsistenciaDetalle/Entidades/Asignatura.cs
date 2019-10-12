using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciaDetalle.Entidades
{
    public class Asignatura
    {
        [key]
        public int asignaturaid { get; set; }
        public string Nombre { get; set; }

        public Asignatura()
        {
        }
    }
}
