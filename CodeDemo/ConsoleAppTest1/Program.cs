using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpGet();

            var id = 0;
            var id2 = id++ + 1;
            var id3 = ++id;
            Console.WriteLine($"id ={id},id1={id2}");

            UnityTest unityTest = new UnityTest();
            unityTest.Show();
            Console.ReadKey();
        }

        private static async Task HttpGet()
        {
            string baseAddress = "http://localhost:8500/";
            var client = new HttpClient()
            {
                BaseAddress = new Uri(baseAddress),
                Timeout = TimeSpan.FromMilliseconds(1000)
            };
            try
            {
                var s = await client.GetAsync(new Uri(@"/YKData/selectOracleXYRYXX?key=", UriKind.Relative));
                s.EnsureSuccessStatusCode();
                var str = await s.Content.ReadAsStringAsync();
                Console.WriteLine($"received string is {str}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }
        }
    }
}
