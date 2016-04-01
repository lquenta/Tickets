﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TNT.Models
{
    public class NuevoEvento
    {
        public string descripcion { get; set; }
        public DateTime fecha_evento { get; set; }
        public TimeSpan hora_evento { get; set; }
        public int id_empresa { get; set; }
        public int id_lugar { get; set; }
        public int id_tipo_evento { get; set; }
        public string img_url { get; set; }
        public string nombre_evento { get; set; }
        public virtual ICollection<NuevoSector> sectores { get; set; }

    }
    public class NuevoSector
    {
        public string descripcion { get; set; }
        public decimal precio_unitario { get; set; }
        public int id_evento { get; set; }
        public int asientos_disponibles { get; set; }
    }
}