using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
