using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDim =
            {
                {{1,2,9},{3,4,8} },
                {{5,6,44}, {7,65,9}}
            };

            // Get subarray in array GetLength(0)
            for (int i = 0; i < threeDim.GetLength(0); i++)
            {
                //Get count of elements of subArray
                for (int j = 0; j < threeDim.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDim.GetLength(2); k++)
                    {
                        Console.Write(threeDim[i,j,k]+" ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Length of array");
            Console.WriteLine(threeDim.Length);
            Console.ReadKey();
        }
    }
}
