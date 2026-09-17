using Microsoft.AspNetCore.Mvc;
using ProjetoPokemon.Data;
using ProjetoPokemon.Models;

namespace ProjetoPokemon.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PokemonsController : ControllerBase
    {
       private readonly AppDbContext _appDbContext;

       public PokemonsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpPost]
        public async Task<IActionResult> addPokemon(Pokemons pokemonss)
        {
            _appDbContext.pokemons.Add(pokemonss);
            await _appDbContext.SaveChangesAsync();

            return Ok(pokemonss);
        }
    }
}