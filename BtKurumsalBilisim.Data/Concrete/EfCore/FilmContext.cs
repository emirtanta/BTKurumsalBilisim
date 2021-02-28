using BTKurumsalBilisim.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BtKurumsalBilisim.Data.Concrete.EfCore
{
    public class FilmContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QVN1TMN;Database=FilmDB;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmCategory>().
             HasKey(c => new { c.CategoryId, c.FilmId });
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Film> Films { get; set; }

    }
}
