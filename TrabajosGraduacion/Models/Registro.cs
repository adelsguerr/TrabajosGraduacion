using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TrabajosGraduacion.Models
{
    public partial class Registro
    {
        [Key]
        public int IdRegistro { get; set; }
        [Required(ErrorMessage = "El típo es requerido")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "El título es requerido")]
        [DisplayName("Título")]
        public string Titulo { get; set; }
        public string Autor { get; set; }
        [DisplayName("Año")]
        public string Anio { get; set; }
        public string Facultad { get; set; }
        public string Carrera { get; set; }
    }
}
