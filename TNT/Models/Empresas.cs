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
    
    public partial class Empresas
    {
        public Empresas()
        {
            this.Eventos = new HashSet<Eventos>();
            this.comisiones = new HashSet<comisiones>();
        }
    
        public int id { get; set; }
        public string nombre_empresa { get; set; }
        public string nit { get; set; }
        public string direccion { get; set; }
        public string representante_legal { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public int id_usuario { get; set; }
        public string dosificacion_codigo_autorizacion { get; set; }
        public string dosificacion_actividad_comercial { get; set; }
        public string departamento { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<Eventos> Eventos { get; set; }
        public virtual ICollection<comisiones> comisiones { get; set; }
    }
}
