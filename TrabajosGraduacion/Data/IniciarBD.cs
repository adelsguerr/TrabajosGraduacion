using TrabajosGraduacion.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace TrabajosGraduacion.Data
{
    public class IniciarBD
    {
        public static void Iniciar(TrabajosGraduacionContext context)
        {
            context.Database.EnsureCreated();

            if (context.Registro.Any())
            {
                return;
            }

            //var registro = new Registro[]
            //{
            //    new Registro{RegistroID=1,Titulo="Ingeniero en sistemas informáticos"
            //    ,Autor="Ricardo Hernandez",Año= new System.DateTime(),Facultad="Ingeniería y Arquitectura",
            //    Carrera="Ingeniería en sistemas informáticos"}
            //};
            //foreach (Registro r in registro)
            //{
            //    context.Registro.Add(r);
            //}

            //context.SaveChanges();
        }
    }
}
