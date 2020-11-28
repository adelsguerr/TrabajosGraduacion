using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabajosGraduacion.Models;

namespace TrabajosGraduacion.Data
{
    public class TrabajosGraduacionContext : DbContext
    {
        public TrabajosGraduacionContext (DbContextOptions<TrabajosGraduacionContext> options)
            : base(options)
        {
        }

        public DbSet<TrabajosGraduacion.Models.Registro> Registro { get; set; }
    }
}
