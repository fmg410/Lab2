using Lab2;
using Newtonsoft.Json.Linq;

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
            listBoxPokemon.DataSource = pokedex.PokemonEntries.ToList<PokemonEntry>();
            listBoxPokemon.DisplayMember = "Name";
            labelName.DataBindings.Add("Text", listBoxPokemon.DataSource, "Name");
        }

        public async Task GetData(string pokeName)
        {
            string call = "https://pokeapi.co/api/v2/pokemon/charizard/";
            string response = "";
            try
            {
                response = await client.GetStringAsync(call);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //dynamic var = JObject.Parse(response);
            //pokedex.PokemonEntries.Add(new PokemonEntry() { Id = var.id, Name = var.name, FrontDefault = var.sprites.front_default });
            //pokedex.SaveChanges();
            //Console.WriteLine(var.name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = searchPokemon.Text;
            name = name.ToLower();
            APITest t = new APITest();
            t.GetData(pokedex, name).Wait();
            //GetData(name).Wait();

            //pictureBox1.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\WinFormsApp\\WinFormsApp\\bin\\Debug\\net5.0-windows\\dotnet.png");
            //pictureBox1.Load("https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png");
            //pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 35, Name = "Clefairy", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png" });
            //pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 36, Name = "Vulpix", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/36.png" });
            //pokedex.SaveChanges();
            listBoxPokemon.DataSource = pokedex.PokemonEntries.ToList<PokemonEntry>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pokedex.PokemonEntries.Remove((PokemonEntry)listBoxPokemon.SelectedItem);
            pokedex.SaveChanges();


            //listBoxPokemon.DataSource = pokedex.PokemonEntries;
            
            //listBoxPokemon.ValueMember = "Id";
            //listBoxPokemon.SelectedIndex = -1;
            //listBoxPokemon.ClearSelected();
            listBoxPokemon.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pokedex.PokemonEntries.RemoveRange(pokedex.PokemonEntries);
            pokedex.SaveChanges();
            listBoxPokemon.DataSource = pokedex.PokemonEntries.ToList<PokemonEntry>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void listBoxPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(((PokemonEntry)listBoxPokemon.SelectedItem).FrontDefault);
        }
    }
}
