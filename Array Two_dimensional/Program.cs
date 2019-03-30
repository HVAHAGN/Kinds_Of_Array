using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Two_dimensional
{
  
        class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                int[,] arr = new int[3, 3];

                //Fill array random valus
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr[i, j] = rnd.Next(1, 50);
                    }

                }

                //Displaying array
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }




                Console.ReadLine();
            }
        }
    }

