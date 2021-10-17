using Microsoft.EntityFrameworkCore;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\RegistroDetalle.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 1, Nombre = "Permiso para Vacacionar", Descripcion = "Permiso otorgado para que el trabajador pueda descansar"
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 2, Nombre = "Permiso de Emergencia", Descripcion = "Permiso otorgado para que el trabajador pueda salir por cualquier inconveniente"
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 3, Nombre = "Permiso de Salud", Descripcion = "Permiso otorgado para que el trabajador salga de licencia hasta que se recupere"
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 4, Nombre = "Permiso por Fallecimiento", Descripcion = "Permiso otorgado al trabajador por la muerte de un familiar"
            });
        }
    }
}
