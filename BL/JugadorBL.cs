using BL.Interfaces;
using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class JugadorBL : IGenericBL<tbJugadores>
    {

        JugadoresDL jugadorInst = new JugadoresDL();
        public bool eliminar(tbJugadores entity)
        {
            throw new NotImplementedException();
        }

        public tbJugadores guardar(tbJugadores entity)
        {
            var jugador = obtenerPorID(entity);

            if(jugador != null)
            {
                throw new Exception("error");
            }
            return jugadorInst.guardar(entity);
        }

        public bool modificar(tbJugadores entity)
        {
            throw new NotImplementedException();
        }

        public tbJugadores obtenerPorID(tbJugadores entity)
        {
            return jugadorInst.obtenerPorID(entity);
        }

        public List<tbJugadores> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
