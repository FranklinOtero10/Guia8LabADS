using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADSProject.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        public int id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        [MaxLength(length: 12, ErrorMessage = "La longitud del campo no puede ser mayor a 12 caracteres.")]
        public string codigo { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser mayor a 254 caracteres.")]
        public string email { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string nombres { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string apellidos { get; set; }

    }
}