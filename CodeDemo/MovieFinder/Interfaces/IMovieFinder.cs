using MovieFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder.Interfaces
{
    public interface IMovieFinder
    {
        IList<Movie> FindAll();
    }
}
