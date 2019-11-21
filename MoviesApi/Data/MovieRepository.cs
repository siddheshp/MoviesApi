using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;

namespace MoviesApi.Data
{
    public class MovieRepository : IRepository
    {
        MovieContext context;
        public MovieRepository(MovieContext context)
        {
            this.context = context;
        }

        public Movie GetMovieById(int movieId)
        {
            return context.Movies.Where(m => m.Id == movieId)
                .FirstOrDefault();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return context.Movies;
        }
    }
}
