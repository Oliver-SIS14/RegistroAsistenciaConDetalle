using RegistroAsistenciaDetalle.DAL;
using RegistroAsistenciaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciaDetalle.BLL
{
    public class AsistenciaRepositorio : RepositorioBase<Asistencia>
    {
        public override bool Modificar(Asistencia asistencia)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var Anterior = contexto.Asistencias.Find(asistencia.asistenciaid);

                foreach (var item in Anterior.estudiantes)
                {
                    if (!asistencia.estudiantes.Exists(d => d.id == item.id))
                        contexto.Entry(item).State = EntityState.Deleted;
                }
                contexto.Entry(asistencia).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
    }
}
