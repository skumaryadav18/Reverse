using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[100];

       
            Console.Write("Enter the numer in array in print in reverse :");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    
    }
}



