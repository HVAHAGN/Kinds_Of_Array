using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
/*С помощью ключевого слова params можно указать параметр метода, принимающий переменное число аргументов.
Можно отправить список аргументов типа, указанного в объявлении параметра, с разделителями-запятыми, или массив
аргументов указанного типа.Можно также не отправлять аргументы. Если аргументы не отправляются, длина списка params равна нулю.*/
        static void ShowArray(params int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}",arr[i]);
            }
        }
        //params with string
        static void ShowStringParams(string name, params int[] arr)
        {
            Console.Write(name);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
            }
        }

        static void Main(string[] args)
        {
            ShowArray(2, 5, 6, 93, 56, 5, 8, 78);
            ShowStringParams("Numbers ", 1, 2, 3, 6, 5, 6, 9, 8, 40);

            Console.ReadLine(); 
        }
    }
}
