using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab2
{
    public class APITest
    {
        public HttpClient client;

        public APITest()
        {
            client = new HttpClient();
        }
        public async Task GetData(Pokedex pokedex, string name)
        {
            //string call = "https://pokeapi.co/api/v2/pokemon-species/413/";
            string call = "https://pokeapi.co/api/v2/pokemon/charizard/";
            string response = await client.GetStringAsync(call);
            dynamic var = JObject.Parse(response);
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = var.id, Name = var.name, FrontDefault = var.sprites.front_default });
            pokedex.SaveChanges();
        }

    }
}
