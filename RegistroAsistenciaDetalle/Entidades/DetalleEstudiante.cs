using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciaDetalle.Entidades
{
    public class DetalleEstudiante
    {
        [key]
        public int id { get; set; }
        public int asistenciaid { get; set;}
        public string Nombre { get; set; }
        public bool Presente { get; set; }

        public DetalleEstudiante() { }
        public DetalleEstudiante(int selectedIndex, string text, bool @checked)
        {
            id = selectedIndex+1;
            Nombre = text;
            Presente = @checked;
        }
        public DetalleEstudiante(string nombre, bool presente, int id, int asistenciaid)
        {
            id = 0;
            Nombre = nombre;
            Presente = presente;
        }

    }
}
