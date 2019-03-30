using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Array");

            int[] array = new int[] { 1, 25, 6, 3, 5, 6, 9, 6 };
            array = new int[5];
            array = new int[5] { 2, 5, 69, 4, 7 };
            int[] array2 = { 5, 6, 9, 85, 2, 5, 3, 69, 8 };
            //Dispaying array's elements
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }

            //multidimensional
            int[,] arr2 = new int[3, 3];

            //Jagged array
            int[][] arr3 = new int[3][];
            arr3[0] = new int[] { 10, 20 };
            arr3[1] = new int[] { 15, 25, 36, 45 };
            arr3[2] = new int[] { 1, 5, 69, 64, 58, 2, 5, 36 };

            Console.ReadLine();
        }
    }
}
