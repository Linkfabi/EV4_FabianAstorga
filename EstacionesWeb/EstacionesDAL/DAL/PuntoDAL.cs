using EstacionesDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL.DAL
{
    public class PuntoDAL
    {
        private static List<Punto> puntos = new List<Punto>();

        public void Add(Punto c)
        {
            puntos.Add(c);
        }

        public List<Punto> GetAll()
        {
            return puntos;
        }

        public List<Punto> GetAll(String tipo)
        {        
           return puntos.FindAll(c => c.Tipo == tipo);
        }

        public void Remove(int id)
        {
            Punto pun = puntos.Find(c => c.Id == id);
            puntos.Remove(pun);
        }        
    }
}
