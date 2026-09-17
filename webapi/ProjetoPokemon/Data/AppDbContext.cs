using Microsoft.EntityFrameworkCore;
using ProjetoPokemon.Models;

namespace ProjetoPokemon.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}

        public DbSet<Pokemons> pokemons {get; set;}
    }
}