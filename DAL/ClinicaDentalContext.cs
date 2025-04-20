using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public class ClinicaDentalContext : DbContext
    {
        // Definición de las tablas (DbSet) que tendrá el contexto
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        // Configuraciones de mapeo y restricciones de las entidades
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contacto>()
                .Map<Paciente>(m => m.Requires("TipoContacto").HasValue("Paciente"))
                .Map<Empleado>(m => m.Requires("TipoContacto").HasValue("Empleado"));

            // Configuración de propiedades comunes para Contacto
            modelBuilder.Entity<Contacto>()
                .Property(c => c.Nombre).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Contacto>()
                .Property(c => c.Apellido).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Contacto>()
                .Property(c => c.Telefono).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Contacto>()
                .Property(c => c.Correo).HasMaxLength(100);

            // Configuración de propiedades específicas para Paciente
            modelBuilder.Entity<Paciente>()
                .Property(p => p.Nombre).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Paciente>()
                .Property(p => p.Apellido).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Paciente>()
                .Property(p => p.Correo).IsOptional().HasMaxLength(100);

            // Configuración de propiedades específicas para Empleado
            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Empleado>()
                .Property(e => e.Correo).IsOptional().HasMaxLength(100);


            modelBuilder.Entity<Contacto>()
                .Property(c => c.Nombre).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Contacto>()
                .Property(c => c.Apellido).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Contacto>()
                .Property(c => c.Telefono).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Contacto>()
                .Property(c => c.Correo).IsOptional().HasMaxLength(100);
        }
    }
}