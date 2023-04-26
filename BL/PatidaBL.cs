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
    internal class PatidaBL : IGenericBL<partidas>
    {
        PartidaDL patidaInst = new PartidaDL();
        public bool eliminar(partidas entity)
        {
            throw new NotImplementedException();
        }

        public partidas guardar(partidas entity)
        {
            var partida = obtenerPorID(entity);

            if (partida != null)
            {
                throw new Exception("error");
            }
            return patidaInst.guardar(entity);
        }

        public bool modificar(partidas entity)
        {
            throw new NotImplementedException();
        }

        public partidas obtenerPorID(partidas entity)
        {
            throw new NotImplementedException();
        }

        public List<partidas> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
