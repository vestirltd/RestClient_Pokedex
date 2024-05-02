using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Model
{
    public class PokedexModel
    {
        public class PokemonListResponse
        {
            public int Count { get; set; }
            public string Next { get; set; }
            public string Previous { get; set; }
            public List<PokemonResult> Results { get; set; }
        }

        public class PokemonResult
        {
            public string Name { get; set; }
            public string Url { get; set; }

            // public static implicit operator PokemonResult(PokemonResult v)
            // {
            //     throw new NotImplementedException();
            // }

            // public static explicit operator PokemonResult(List<PokemonResult> v)
            // {
            //     throw new NotImplementedException();
            // }
        }
    }
}