using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesBD.DAL
{
    public class EstacionDal
    {
        public EstacionesBDEntities dbEntities = new EstacionesBDEntities();        

        public void Add(ESTACION c)
        {
            dbEntities.ESTACION.Add(c);
            dbEntities.SaveChanges();
        }

        public List<ESTACION> GetAll()
        {
            return dbEntities.ESTACION.ToList();
        }

        public void Remove(int id)
        {
            ESTACION c = dbEntities.ESTACION.Find(id);
            dbEntities.ESTACION.Remove(c);
            dbEntities.SaveChanges();
        }
    }
}
