using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMain
{
    class Program
    {
        static void Main(string[] args)
        {

            String datenow = System.DateTime.Now.ToLongDateString();
            String datecompare = DateTime.Now.AddHours(3).ToLongDateString();

        }
    }
}
