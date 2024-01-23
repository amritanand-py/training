using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your role either Fulltime or Partime");
            String role = Console.ReadLine();
            switch (role)
            {
                case "Fulltime":
                    Console.WriteLine("Your Wage is 160");
                    break;
                case "Partime":
                    Console.WriteLine("Your wage is 80");
                    break;
            }
            Console.ReadLine();
        }
    }
}
