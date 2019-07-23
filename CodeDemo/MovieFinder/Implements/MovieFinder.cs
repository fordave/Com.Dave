using MovieFinder.Interfaces;
using MovieFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder.Implements
{
    public class MovieFinder : IMovieFinder
    {
        private readonly string _fileName;
        public MovieFinder(string fileName)
        {
            _fileName = fileName;
        }
        public IList<Movie> FindAll()
        {
            return new List<Movie> { new Movie { MovieName = "ha" } };
        }
    }
}
