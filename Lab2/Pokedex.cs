using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Pokedex : DbContext
    {
        public DbSet<PokemonEntry> PokemonEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=pokedex.db");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<PokemonEntry>().HasKey(p => p.Id);
        //    //modelBuilder.Entity<PokemonEntry>().Property(p => p.Name).IsRequired();
        //    modelBuilder.Entity<PokemonEntry>().HasData(
        //        new PokemonEntry() { Id = 1, Name = "Bulbasaur", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png" }
        //        );
        //}
    }
}
