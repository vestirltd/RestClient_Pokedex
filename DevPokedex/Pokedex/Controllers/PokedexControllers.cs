using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Model;
using Pokedex.Services.Interface;

namespace Pokedex.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class PokedexControllers : ControllerBase
    {
        
        private readonly IPokemonServices _pokemonService;
        public PokedexControllers(IPokemonServices pok)
        {
            _pokemonService = pok;
        }
        
        [HttpGet]
        [Route("/GetPokemanNames")]
        public List<PokedexModel.PokemonResult> GetPokemonNames()
        {
            List<PokedexModel.PokemonResult> poks = new List<PokedexModel.PokemonResult>();
            poks = _pokemonService.GetPokemonNames("https://pokeapi.co/api/v2/pokemon-species");
            return poks;
        }
    }
}