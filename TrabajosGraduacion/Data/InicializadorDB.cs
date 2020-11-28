using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabajosGraduacion.Models;

namespace TrabajosGraduacion.Data
{
    public class InicializadorDB
    {
        public static void Inicializar (TrabajosGraduacionContext context)
        {
            context.Database.EnsureCreated();

            if (context.Registro.Any())
            {
                return;
            }

            var registros = new Registro[]
            {
                new Registro{Tipo = "Tesis", Titulo = "Cómo vemos la pandemia", Autor = "Jorge Mejía", Anio = "2020", Facultad = "Facultad de CIencias de la Salud", Carrera = "Doctorado en Medicina"}
            };

            foreach ( Registro a in registros )
            {
                context.Registro.Add(a);
            }

            context.SaveChanges();
        }
    }
}
