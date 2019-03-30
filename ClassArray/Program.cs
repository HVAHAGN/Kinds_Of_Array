using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //All array derive from class Array
            int[] vector = { 1, 2, 3, 5, 6, 9, 8 };

            //Upcast to Array
            Array arr = vector as Array;
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadLine();
        }
    }
}
