using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrabajosGraduacion.Models
{
    public partial class Registros
    {
        public int RegistroId { get; set; }
        [Required(ErrorMessage = "El Tipo es requerido")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "El Título es obligatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Autor es requerido")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El Año es requerido")]
        public string Anio { get; set; }
        public string Facultad { get; set; }
        public string Carrera { get; set; }
    }
}
