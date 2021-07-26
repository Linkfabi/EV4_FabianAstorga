using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesBD.DAL
{
    public class RegionDal
    {
        public EstacionesBDEntities dbEntities = new EstacionesBDEntities();

        public List<REGION> GetAll()
        {
            return dbEntities.REGION.ToList();
        }

        public String GetAllID(String nombre)
        {
            string id = null;
            List<REGION> region = new RegionDal().GetAll();
            for (int i = 0; i < region.Count; i++)
            {
                if(region[i].NombreRegion == nombre)
                {
                    id = region[i].IdRegion;
                }
            }
            return id;
        }

        public String GetAllNombre(string codigo)
        {
            string id = null;
            List<REGION> region = new RegionDal().GetAll();
            for (int i = 0; i < region.Count; i++)
            {
                if (region[i].IdRegion == codigo)
                {
                    id = region[i].NombreRegion;
                }
            }
            return id;
        }

    }
}
