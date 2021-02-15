using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //...............Program 1

            int n;//used in every program
            Console.WriteLine("\nProgram 1\n");
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array1 = new int[n];
            Console.WriteLine("Enter Array {0} Element: ", n);
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.Write("Revers of the Array: ");
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

            