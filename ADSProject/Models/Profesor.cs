using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ADSProject.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        public int id { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public String Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public String Apellidos { get; set; }

        [Display(Name = "Email")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser mayor a 254 caracteres.")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public String Email { get; set; }
    }
}