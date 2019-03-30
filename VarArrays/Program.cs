using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Int32
            var array1 = new [] { 1, 2, 3, 5, 6, 9, 10 };
            Console.WriteLine(array1.GetType());

            //Array Doubles
            var array2 = new[] { 3.14, 1, 6.5 };
            Console.WriteLine(array2.GetType());

            // Different types not compile
            //var array3=new[] {1, "string"};

            Console.ReadKey();
        }
    }
}
