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
    using System.ComponentModel.DataAnnotations;

    public partial class Usuarios
    {
        public Usuarios()
        {
            this.Compra = new HashSet<Compra>();
            this.Empresas = new HashSet<Empresas>();
            this.Personas = new HashSet<Personas>();
            this.token_usuario = new HashSet<token_usuario>();
            this.comisiones = new HashSet<comisiones>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "El email tiene un formato incorrecto")]
        [MaxLength(60, ErrorMessage = "El email debe tener 60 caracteres como maximo")]
        public string email { get; set; }

        [Required(ErrorMessage = "El password es requerido")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "El password debe tener entre 8 y 30 caracteres")]
        public string password { get; set; }
        public string rol { get; set; }
        public bool reiniciar_contraseña { get; set; }
        public string token_reinicio { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Empresas> Empresas { get; set; }
        public virtual ICollection<Personas> Personas { get; set; }
        public virtual ICollection<token_usuario> token_usuario { get; set; }
        public virtual ICollection<comisiones> comisiones { get; set; }
    }
}
