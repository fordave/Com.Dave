using ConsoleAppSqliteEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSqliteEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 entities = new Model1();
         var tt=   entities.BaseAreas.ToList();
        }
    }
}
