using System;
using System.Collections.Generic;
using System.Linq;
using TrabajosGraduacion.Models;
using System.Threading.Tasks;

namespace TrabajosGraduacion.Data
{
    public class DbInitializer
    {
        public static void Initialize(TrabajosGraduacionContext context)
        {
            context.Database.EnsureCreated();

            if (context.Registro.Any())
            {
                return;
            }

            var Registros = new Registro[]
            {
                new Registro{Tipo="Tesis", Titulo="Las tecnologías de las BDs", Autor = "Salvador Ramirez",
                             Anio = "2019", Facultad = "Facultad de Ingeniería y Arquitectura", Carrera = "Ingeniería en Sistemas Informáticos"},
                new Registro{Tipo="Proyecto", Titulo="Machine Learning en La Salud", Autor = "Jorge Gonzáles",
                             Anio = "2018", Facultad = "Facultad de Ingeniería y Arquitectura", Carrera = "Ingeniería en Sistemas Informáticos"},
                new Registro{Tipo="Pasantía", Titulo="Java Developer", Autor = "Ricardo Martínez",
                             Anio = "2019", Facultad = "Facultad de Ingeniería y Arquitectura", Carrera = "Ingeniería de Software"}
            };

            foreach (Registro a in Registros)
            {
                context.Registro.Add(a);
            }

            context.SaveChanges();
        }
    }
}
