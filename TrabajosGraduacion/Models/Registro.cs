using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajosGraduacion.Models
{
    public class Registro
    {
        public int RegistroID { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Año { get; set; }
        public string Facultad { get; set; }
        public string Carrera { get; set; }
    }
}
