using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Refactor_Project_Series.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Serie> Series { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=ProjetoSeries;Database=master;Trusted_Connection=True;");
        }
    }
}
