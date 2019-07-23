using ConsoleAppNHibernateDemo.Models;
using ConsoleAppNHibernateDemo.Utils;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace ConsoleAppNHibernateDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            var nHibernateHelper = new NHibernateHelper<Emp>();
            var stopwatch = new Stopwatch();
            var length = 1;
            do
            {
                Console.WriteLine($"**********************************************\r\n");

                stopwatch.Start();

                for (var i = 0; i < length; i++)
                {
                    var emp = new Emp { EmpName = "dave1" };
                    nHibernateHelper.Insert(emp);
                    // Thread.Sleep(300);
                }
                stopwatch.Stop();
                Console.WriteLine($"{length} insert cost time :{stopwatch.ElapsedMilliseconds}");
                stopwatch.Restart();
                var emps = nHibernateHelper.GetAll();
                stopwatch.Stop();
                Console.WriteLine($"{length} select cost time :{stopwatch.ElapsedMilliseconds}");
                length *= 2;
            } while (Console.ReadKey().Key != ConsoleKey.Q);


            Console.ReadKey();
        }

    }
}
