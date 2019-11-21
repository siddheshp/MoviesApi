using MoviesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Data
{
    public interface IRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(int movieId);
    }
}
