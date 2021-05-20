using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ADSProject.Models
{
    [Table("Materia")]
    public class Materia
    {
        public int id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public String Nombre { get; set; }
    }
}