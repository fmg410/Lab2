using Lab2;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private Pokedex pokedex;
        public HttpClient client;
        public Form1()
        {
            InitializeComponent();
            pokedex = new Pokedex();
            client = new HttpClient();
            refresh();
            listBoxPokemon.DisplayMember = "Name";
        }

        public void refresh()
        {
            listBoxPokemon.DataSource = pokedex.PokemonEntries.ToList<PokemonEntry>();
            labelName.DataBindings.Clear();
            labelName.DataBindings.Add("Text", listBoxPokemon.DataSource, "Name");
        }

        public async Task GetData(string pokeName)
        {
            string call = "https://pokeapi.co/api/v2/pokemon/charizard/";
            //string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";

            string response = "";
            //Thread.Sleep(2000);
            try
            {
                response = await client.GetStringAsync(call);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //dynamic var = JObject.Parse(response);
            //pokedex.PokemonEntries.Add(new PokemonEntry() { Id = var.id, Name = var.name, FrontDefault = var.sprites.front_default });
            //pokedex.SaveChanges();
            //Console.WriteLine(var.name);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = searchPokemon.Text;
            name = name.ToLower();

            var pokemon = pokedex.PokemonEntries.Where(p => p.Name.ToLower() == name).FirstOrDefault();
            if (pokemon != null)
            {
                listBoxPokemon.SelectedItem = pokemon;
                //pictureBox1.Load(pokemon.FrontDefault);
            }
            else
            {
                string call = "https://pokeapi.co/api/v2/pokemon/" + name;
                string response = "";
                try
                {
                    response = await client.GetStringAsync(call);
                } catch (Exception ex)
                {

                }
                dynamic var = JObject.Parse(response); // wywala
                PokemonEntry p = new PokemonEntry() { Id = var.id, Name = var.name, FrontDefault = var.sprites.front_default };
                pokedex.PokemonEntries.Add(p);
                pokedex.SaveChanges();
                refresh();
                listBoxPokemon.SelectedItem = p;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pokedex.PokemonEntries.Remove((PokemonEntry)listBoxPokemon.SelectedItem);
            pokedex.SaveChanges();


            //listBoxPokemon.DataSource = pokedex.PokemonEntries;
            
            //listBoxPokemon.ValueMember = "Id";
            //listBoxPokemon.SelectedIndex = -1;
            //listBoxPokemon.ClearSelected();
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pokedex.PokemonEntries.RemoveRange(pokedex.PokemonEntries);
            pokedex.SaveChanges();
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 35, Name = "clefairy", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 36, Name = "vulpix", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/36.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 37, Name = "ninetales", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/38.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 38, Name = "jigglypuff", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/39.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 39, Name = "wigglytuff", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/40.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 40, Name = "zubat", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/41.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 41, Name = "golbat", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/42.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 42, Name = "oddish", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/43.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 43, Name = "gloom", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/44.png" });
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 44, Name = "vileplume", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/45.png" });

            pokedex.SaveChanges();
            refresh();
        }

        private void listBoxPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(((PokemonEntry)listBoxPokemon.SelectedItem).FrontDefault);
        }
    }
}
