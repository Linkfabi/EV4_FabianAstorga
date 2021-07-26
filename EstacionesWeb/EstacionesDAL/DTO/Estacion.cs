using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL.DTO
{
    public class Estacion
    {
        private int id;
        private String fecha;
        private String direccion;
        private String region;


        public Estacion(int id, string fecha, string direccion, string region)
        {
            this.id = id;
            this.fecha = fecha;
            this.direccion = direccion;
            this.region = region;
        }

        public int Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Region { get => region; set => region = value; }
    }
}
