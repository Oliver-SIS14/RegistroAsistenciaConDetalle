using RegistroAsistenciaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciaDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        
        public Contexto() : base("ConStr")
        {

        }
    }
}
