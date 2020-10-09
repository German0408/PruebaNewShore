using Microsoft.EntityFrameworkCore;
using PruebaNewShore.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNewShore.Infraestructura
{
    public class PruebaNewShoreBaseDeDatos : DbContext
    {
        public DbSet<Vuelo> Vuelos { get; set; }
        public DbSet<Transporte> Transportes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PruebaNewShore.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transporte>(builder =>
            {
                builder.HasKey(t => t.NumeroDeVuelo);
            });
        }
    }
}
