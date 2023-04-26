using DL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class PartidaDL : IGenericDL<partidas>
    {
        public bool eliminar(partidas entity)
        {
            throw new NotImplementedException();
        }

        public partidas guardar(partidas entity)
        {
            try
            {
                using (var context = new dbJuegoDoblesEntities())
                {
                    context.partidas.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
