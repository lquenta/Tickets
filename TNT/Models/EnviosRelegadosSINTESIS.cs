//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TNT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnviosRelegadosSINTESIS
    {
        public int id { get; set; }
        public string codigo_recaudacion { get; set; }
        public string email_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string nit_usuario { get; set; }
        public string nombre_evento { get; set; }
        public string nombre_empresa { get; set; }
        public string nit_empresa { get; set; }
        public decimal costo_total { get; set; }
        public decimal total_comision { get; set; }
        public System.DateTime fecha_hora { get; set; }
        public bool pendiente { get; set; }
    }
}
