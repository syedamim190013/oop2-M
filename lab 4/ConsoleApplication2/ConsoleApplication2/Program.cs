using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //...............Program 1

            int n;//used in every program
            Console.WriteLine("\nProgram 5\n");
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array5 = new int[n];
            Console.WriteLine("Enter Array {0} Element(not negative numburs): ", n);
            for (int i = 0; i < n; i++)
            {
                array5[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < array5.Length; i++)
            {
                int num = array5[i];
                if (num != -1)
                {
                    for (int j = i + 1; j < array5.Length; j++)
                    {
                        if (num == array5[j])
                        {
                            array5[j] = -1;
                        }
                    }
                }

            }
            Console.Write("Eunique Elements: ");
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] != -1)
                {
                    Console.Write(array5[i] + " ");
                }
            }
            Console.WriteLine();

            //...............END
            Console.WriteLine("\nEND\n");
            Console.ReadLine();

        }
    }
}
