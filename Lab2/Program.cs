using System;
using System.Linq;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            APITest t = new APITest();
            t.GetData().Wait();
            Pokedex pokedex = new Pokedex();
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 35, Name = "Clefairy", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png" });
            pokedex.SaveChanges();
            dynamic list = pokedex.PokemonEntries.ToList<PokemonEntry>();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
