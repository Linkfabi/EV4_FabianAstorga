using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesBD.DAL
{
    public class PuntoDal
    {
        public EstacionesBDEntities dbEntities = new EstacionesBDEntities();

        public void Add(PUNTO c)
        {
            dbEntities.PUNTO.Add(c);
            dbEntities.SaveChanges();
        }

        public List<PUNTO> GetAll()
        {
            return dbEntities.PUNTO.ToList();
        }

        public void Remove(int id)
        {
            PUNTO c = dbEntities.PUNTO.Find(id);
            dbEntities.PUNTO.Remove(c);
            dbEntities.SaveChanges();
        }

        public List<PUNTO> GetALL(string tipo)
        {
            var query = from c in dbEntities.PUNTO
                        where c.Tipo == tipo
                        select c;
            return query.ToList();
        }

        public List<PUNTO> GetALLporID(int id)
        {
            var query = from c in dbEntities.PUNTO
                        where c.NumeroPuntoDeCarga == id
                        select c;
            return query.ToList();
        }


        public int GetAllID(String nombre)
        {
            int id = 0;
            List<PUNTO> punto = new PuntoDal().GetAll();
            for (int i = 0; i < punto.Count; i++)
            {
                if (punto[i].Tipo == nombre)
                {
                    id = punto[i].NumeroPuntoDeCarga;
                }
            }
            return id;
        }

        public void Actualizar(PUNTO punto)
        {
            var query = (from c in dbEntities.PUNTO
                         where c.NumeroPuntoDeCarga == punto.NumeroPuntoDeCarga
                         select c).ToList();

            foreach (var item in query)
            {
                item.Tipo = punto.Tipo;
                item.Direccion = punto.Direccion;
                item.Region = punto.Region;
            }

            dbEntities.SaveChanges();
        }

    }
}
