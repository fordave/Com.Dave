using MovieFinder.Implements;
using MovieFinder.Models;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = ContextRegistry.GetContext();
            var lister = (MovieLister)ctx.GetObject("MyMovieLister");
            var movies = lister.MoviesDirectedBy("Roberto Benigni");
            Console.WriteLine("\nSearching for movie...\n");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(
                    string.Format("Movie name = '{0}'",
                    movie.MovieName));
            }
            Console.WriteLine("\nMovieApp Done.\n\n");
            Console.ReadLine();
        }
    }
}
