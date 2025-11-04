using Microsoft.EntityFrameworkCore;
using JoelNdiba_mvc_movies.Models;  // ✅ Make sure this line exists!

namespace JoelNdiba_mvc_movies.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
