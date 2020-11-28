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
        }

        public static void BuscarDatos(string cadena)
        {
            string palabra;
            palabra = "Hola mundo";
            return;
        }
    }
}
