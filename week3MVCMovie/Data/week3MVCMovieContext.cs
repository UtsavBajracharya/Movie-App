using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using week3MVCMovie.Models;

namespace week3MVCMovie.Data
{
    public class week3MVCMovieContext : DbContext
    {
        public week3MVCMovieContext (DbContextOptions<week3MVCMovieContext> options)
            : base(options)
        {
        }

        public DbSet<week3MVCMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<week3MVCMovie.Models.Author> Author { get; set; } = default!;
    }
}
