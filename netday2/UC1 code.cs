using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a=rnd.Next(0,1);
            Console.WriteLine(a);
            if (a == 0)
            {
                Console.WriteLine("Absent");

            }
            else
            {
                Console.WriteLine("Present");
            }
        }
    }
}
