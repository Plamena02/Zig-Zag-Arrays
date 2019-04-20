using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var number = int.Parse(Console.ReadLine());
            var arr1 = new int[number];
            var arr2 = new int[number];
            
            for (int i = 0; i < number; i++)
            {
                var ar1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    arr1[i] = ar1[0];
                    arr2[i] = ar1[1];
                }
                else
                { arr1[i] = ar1[1];
                  arr2[i] = ar1[0]; }
                
            }
            foreach (var item in arr1)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
           

        }
    }
}



