using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesBD.DAL
{
    public class TipoEstacionDal
    {
        public EstacionesBDEntities dbEntities = new EstacionesBDEntities();
                
        public List<TIPOESTACION> GetAll()
        {
            return dbEntities.TIPOESTACION.ToList();
        }

        public String GetAllID(String nombre)
        {
            string id = null;
            List<TIPOESTACION> estacion = new TipoEstacionDal().GetAll();
            for (int i = 0; i < estacion.Count; i++)
            {
                if (estacion[i].Tipo == nombre)
                {
                    id = estacion[i].IdTipo;
                }
            }
            return id;
        }

        public String GetAllNombre(String id)
        {
            string nombre = null;
            List<TIPOESTACION> estacion = new TipoEstacionDal().GetAll();
            for (int i = 0; i < estacion.Count; i++)
            {
                if (estacion[i].IdTipo == id)
                {
                    nombre = estacion[i].Tipo;
                }
            }
            return nombre;
        }
    }
}
