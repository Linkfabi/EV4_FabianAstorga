using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL.DTO
{
    public class Punto
    {
        private int id;
        private String tipo;
        private String direccion;
        private String region;

        public Punto(int id, string tipo, string direccion, string region)
        {
            this.id = id;
            this.tipo = tipo;
            this.direccion = direccion;
            this.region = region;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Region { get => region; set => region = value; }
    }
}
