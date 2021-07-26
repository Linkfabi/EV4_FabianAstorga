using EstacionesDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL.DAL
{
    public class EstacionDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();

        public void Add(Estacion c)
        {
            estaciones.Add(c);
        }

        public List<Estacion> GetAll()
        {
            return estaciones;
        }

        public void Remove(int id)
        {
            Estacion estac = estaciones.Find(c => c.Id == id);
            estaciones.Remove(estac);
        }
    }
}
