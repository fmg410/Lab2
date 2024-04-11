using Lab2;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private Pokedex pokedex;
        public Form1()
        {
            InitializeComponent();
            pokedex = new Pokedex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\WinFormsApp\\WinFormsApp\\bin\\Debug\\net5.0-windows\\dotnet.png");
            pictureBox1.Load("https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png");
            pokedex.PokemonEntries.Add(new PokemonEntry() { Id = 35, Name = "Clefairy", FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png" });
            pokedex.SaveChanges();
            listBoxPokemon.DataSource = pokedex.PokemonEntries.ToList<PokemonEntry>();
        }
    }
}
