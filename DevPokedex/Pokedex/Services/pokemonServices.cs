using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using static Pokedex.Model.PokedexModel;
using Pokedex.Model;
using System.IO.Compression;
namespace Pokedex.Services
{
    public class pokemonServices : Interface.IPokemonServices
    {
        public List<PokedexModel.PokemonResult> GetPokemonNames(string url)
        {  
             List<PokedexModel.PokemonResult> pokedexs = new List<PokedexModel.PokemonResult>();
            var client = new RestClient(url);
            var request = new RestRequest(); // wecan change into http Req
            var response = client.Get(request);
            string responses = response.Content.ToString();
            PokemonListResponse ResponseContent = JsonConvert.DeserializeObject<PokemonListResponse>(responses);
            PokemonResult pokedex = new PokemonResult();
            foreach(var i in ResponseContent.Results)
            {
                pokedex.Name = i.Name;
                pokedex.Url = i.Url;
                System.Console.WriteLine(pokedex.Name);
                
                pokedexs.Add(pokedex);
            }
            return pokedexs;
        }
    }
}