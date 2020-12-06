using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajosGraduacion.Models
{
    public class Registro
    {
        [Key]
        public int RegistroId { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public string Facultad { get; set; }
        public string Carrera { get; set; }
    }
}
