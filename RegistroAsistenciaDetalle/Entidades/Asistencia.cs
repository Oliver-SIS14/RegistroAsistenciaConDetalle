using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciaDetalle.Entidades
{
    public class Asistencia
    {
        [key]
        public int asistenciaid { get; set; }
        public DateTime Fecha { get; set; }
        public string asignatura { get; set; }
        public virtual List<DetalleEstudiante> estudiantes{ get; set; }
        public int Cantidad { get; set; }
        public Asistencia()
        {

        }
    }
}
