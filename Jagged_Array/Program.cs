using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][]jagged=new int[3][];
            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 2, 58, 6, 9, 45, 50 };
            jagged[2] = new int[] { 5, 78, 3, 254, 6 };

            //
            Console.WriteLine("Jagged elements are");
            for (int i = 0; i < jagged.Length; ++i)
            {
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write("{0}", jagged[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
