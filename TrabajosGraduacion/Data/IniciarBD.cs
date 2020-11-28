using TrabajosGraduacion.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using System.Collections.Generic;

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
        }
    }
}
