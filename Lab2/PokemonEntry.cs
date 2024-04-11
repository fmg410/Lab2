using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PokemonEntry
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string FrontDefault { get; set; }

        public override string ToString()
        {
            return $"Id: {Id },\tName: {Name,-15},\tFrontDefault: {FrontDefault} ";
        }
    }
}
