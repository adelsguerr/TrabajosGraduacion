using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabajosGraduacion.Models;

namespace TrabajosGraduacion.Data
{
    public class InicializarBD
    {
        public static void Inicializar (TrabajosGraduacionBDContext context)
        {
            context.Database.EnsureCreated();

            if (context.Registros.Any())
            {
                return;
            }

            var registros = new Registros[]
            {
                new Registros{Tipo="Tesis", Titulo="Las tecnologías de las BDs", Autor = "Salvador Ramirez", Anio = "2019", Facultad = "Facultad de Ingeniería y Arquitectura", Carrera = "Ingeniería en Sistemas Informáticos"}
            };

            foreach (Registros a in registros)
            {
                context.Registros.Add(a);
            }

            context.SaveChanges();
        }
    }
}
