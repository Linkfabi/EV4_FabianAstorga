//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstacionesBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class PUNTO
    {
        public int NumeroPuntoDeCarga { get; set; }
        public string Tipo { get; set; }
        public string Direccion { get; set; }
        public string Region { get; set; }
    
        public virtual REGION REGION1 { get; set; }
        public virtual TIPOESTACION TIPOESTACION { get; set; }
    }
}
