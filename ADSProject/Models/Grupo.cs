using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ADSProject.Models
{
    [Table("Grupo")]
    public class Grupo
    {
        public int id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public String Nombre { get; set; }

        [Display(Name = "ID Carrera")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public int idCarrera { get; set; }

        [Display(Name = "ID Materia")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public int idMateria { get; set; }

        [Display(Name = "ID Profesor")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public int idProfesor { get; set; }

        [Display(Name = "Ciclo")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public int Ciclo { get; set; }

        [Display(Name = "Año")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public int Anio { get; set; }
    }
}