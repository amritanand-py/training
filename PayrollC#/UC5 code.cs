using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = 20;
            int rate = 20;
            int hrs = 8;
            Console.WriteLine("Your wage is "+(Convert.ToInt32(days * hrs * rate)));
            Console.ReadLine();

        }
    }
}
