using DL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class JugadoresDL : IGenericDL<tbJugadores>
    {
        public bool eliminar(tbJugadores entity)
        {
            throw new NotImplementedException();
        }

        public tbJugadores guardar(tbJugadores entity)
        {
            try
            {
                using (var context = new dbJuegoDoblesEntities())
                {
                    context.tbJugadores.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool modificar(tbJugadores entity)
        {
            throw new NotImplementedException();
        }

        public tbJugadores obtenerPorID(tbJugadores entity)
        {
            try
            {
                using (var context = new dbJuegoDoblesEntities())
                {
                    return context.tbJugadores.Where(x => x.nickname == entity.nickname && x.contrasena == entity.contrasena).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbJugadores> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
