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

        [Required(ErrorMessage = "El tipo de registro es requerido.")]
        public Tipos Tipo { get; set; }

        [Required(ErrorMessage = "El título del registro es requerido.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor del registro es requerido.")]
        [RegularExpression(@"^[A-Z]{1}[a-zA-ZÀ-ÿ\u00f1]{2,50}\s[A-Z]{1}[a-za-zA-ZÀ-ÿ\u00f1]{2,50}$", ErrorMessage = "Formato no válido, Ingrese su Nombre y Apellido.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El año del registro es requerido.")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Formato no válido, sólo se permiten números")]
        [Display(Name = "Año")]
        public string Anio { get; set; }

        public string Facultad { get; set; }

        [Required(ErrorMessage = "La carrera del registro es requerido.")]
        public string Carrera { get; set; }


    }

    public enum Tipos
    {
        Pasantía, Proyecto, Tesis
    }

    public static class HtmlDropDownExtensions
    {
        public static MvcHtmlString EnumDropDownList<TEnum>(this HtmlHelper htmlHelper, string name, TEnum selectedValue) { }

    }
}