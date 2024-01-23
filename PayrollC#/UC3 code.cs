using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc3_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your role either Fulltime or Partime");
            String role = Console.ReadLine();
           
            if (role == "Fulltime" ) {
                Console.WriteLine($"Your daily wage as {role} is : " + 160);
            }
            else
            {
                Console.WriteLine($"Your daily wage as {role} is : " + 80);
            }
            Console.ReadLine();
        }
    }
}
