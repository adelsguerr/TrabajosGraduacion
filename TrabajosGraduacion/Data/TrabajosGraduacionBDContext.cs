using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TrabajosGraduacion.Models;

namespace TrabajosGraduacion.Data
{
    public partial class TrabajosGraduacionBDContext : DbContext
    {
        public TrabajosGraduacionBDContext()
        {
        }

        public TrabajosGraduacionBDContext(DbContextOptions<TrabajosGraduacionBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registros> Registros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; Database=TrabajosGraduacionBD; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registros>(entity =>
            {
                entity.HasKey(e => e.RegistroId)
                    .HasName("PK_RegistroId");

                entity.Property(e => e.Anio)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Autor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Carrera)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Facultad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
