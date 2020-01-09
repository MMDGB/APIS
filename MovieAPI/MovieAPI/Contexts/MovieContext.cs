using Microsoft.EntityFrameworkCore;

namespace MovieAPI.Contexts
{
    public class MovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        public MovieContext(DbContextOptions<MovieContext> options): base(options)
        {
        }
    }
}