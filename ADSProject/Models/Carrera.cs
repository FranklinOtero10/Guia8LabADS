using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADSProject.Models
{
    [Table("Carrera")]
    public class Carrera
    {
        public int id { get; set; }
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]       
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede ser mayor a 3 caracteres.")]
        public String codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]        
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser mayor a 40 caracteres.")]
        public String nombre { get; set; }

    }
}