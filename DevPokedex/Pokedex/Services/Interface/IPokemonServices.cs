using Pokedex.Model;

namespace Pokedex.Services.Interface
{
    public interface IPokemonServices
    {
        public List<PokedexModel.PokemonResult> GetPokemonNames(string url);
        // public PokedexModel.PokemonResult GetPokemonNames(string url);
    }
}