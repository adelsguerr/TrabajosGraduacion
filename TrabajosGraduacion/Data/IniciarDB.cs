using TrabajosGraduacion.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace TrabajosGraduacion.Data
{
    public class IniciarDB
    {
        public static void Iniciar(TrabajosGraduacionBDContext context)
        {
            context.Database.EnsureCreated();

            if (context.Registros.Any())
            {
                return;
            }

            context.SaveChanges();
        }
    }
}
