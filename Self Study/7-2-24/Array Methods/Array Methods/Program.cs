using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration of array
            String[] strdata = { "abc","bcd" };
            int[] intdata = { 1,2,3,4,5,6,7 };
            int[] unsortedarray = { 56, 78, 4, 66, 10, 2, 6 };


            // Function for printing any kind array  
            void PrintArray<T>(T[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]+" ");
                }
                Console.WriteLine();
               
            }
            /*

                        // Printing length
                        int len = intdata.Length;

                        Console.WriteLine("array is  :");
                        PrintArray(intdata);
                        Console.WriteLine("and the length is " + len);

            */

            /*

                        // Sorting array

                        Console.WriteLine("array is  :");
                        PrintArray(unsortedarray);
                        Array.Sort(unsortedarray);
                        Console.WriteLine("Sorted array is :");
                        PrintArray(unsortedarray);

            */

            /*

                        // Seraching index of an element then printig it's index

                        Console.WriteLine("array is  :");
                        PrintArray(unsortedarray);
                        Console.WriteLine("Index of 66 in above array is " + Array.IndexOf(unsortedarray, 66));

            */



            // Reversing an Array
            Console.WriteLine("array is  :");
            PrintArray(intdata);

            Array.Reverse(intdata);

            Console.WriteLine("Reversed array is  :");
            PrintArray(intdata);







        }
    }
}
