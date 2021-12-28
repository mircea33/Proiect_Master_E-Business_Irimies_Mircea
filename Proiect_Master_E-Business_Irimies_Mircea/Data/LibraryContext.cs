using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Master_E_Business_Irimies_Mircea.Models;

namespace Proiect_Master_E_Business_Irimies_Mircea.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) :
base(options)
        {
        }
        public DbSet<Jucator> Jucatori { get; set; }
        public DbSet<Antrenor> Antrenori { get; set; }
        public DbSet<Echipa> Echipe { get; set; }
        public DbSet<Divizie> Divizii { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jucator>().ToTable("Jucator");
            modelBuilder.Entity<Antrenor>().ToTable("Antrenor");
            modelBuilder.Entity<Echipa>().ToTable("Echipa");
            modelBuilder.Entity<Divizie>().ToTable("Divizie");
        }
    }
}
