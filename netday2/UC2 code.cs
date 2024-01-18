using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc2_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wageRate = 20;
            int dayHrs = 8;
            Console.WriteLine("Your daily wage is : " + (Convert.ToInt32(wageRate*dayHrs)));
            Console.ReadLine();
            
        }
    }
}
