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
    using System.ComponentModel;
    
    public partial class Eventos
    {
        public Eventos()
        {
            this.sectores = new HashSet<sectores>();
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int id { get; set; }

        [DisplayName("Evento")]
        public string nombre_evento { get; set; }
        public int id_lugar { get; set; }
        public int id_empresa { get; set; }
        public int id_tipo_evento { get; set; }
        public string img_url { get; set; }

        [DisplayName("Fecha")]
        public string fecha_evento_format
        {
            get
            {
                return this.fecha_evento.ToString("dd/MM/yyyy");
            }
        }

        public System.DateTime fecha_evento { get; set; }

        [DisplayName("Descripción")]
        public string descripcion { get; set; }
        public bool habilitado { get; set; }

        [DisplayName("Hora")]
        public string hora_evento_format
        {
            get
            {
                return this.hora_evento.ToString(@"hh\:mm");
            }
        }

        public System.TimeSpan hora_evento { get; set; }
        public string nit_facturacion { get; set; }
        public string nombre_empresa_facturacion { get; set; }
        public string numero_autorizacion_facturacion { get; set; }
        public string direccion_facturacion { get; set; }
        public string telefono_facturacion { get; set; }
        public string departamento_facturacion { get; set; }
        public string rubro_facturacion { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        public virtual Lugares Lugares { get; set; }
        public virtual Tipos_evento Tipos_evento { get; set; }
        public virtual ICollection<sectores> sectores { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
