using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinder.Interfaces;
using MovieFinder.Models;

namespace MovieFinder.Implements
{
    public class MovieLister : Interfaces.IMovieLister
    {
        private  IMovieFinder movieFinder;

        public MovieLister(IMovieFinder movieFinder)
        {
            this.movieFinder = movieFinder ?? throw new ArgumentNullException(nameof(movieFinder));
        }

        public IList<Movie> MoviesDirectedBy(string arg)
        {
            return movieFinder.FindAll();
        }
    }
}
