using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariant
{
    public interface IAnimal
    {
        void Voice();
    }
    public class Dog:IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }
        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.WriteLine(new string('-',10));
            //Covariance for arrays enables implicit conversion of an array of a
            //more derived type to an array of a less derived type

            IAnimal[] animal = dogs; //Covariance or  implicit upcast
            for (int i = 0; i < dogs.Length; i++)
            {
                animal[i].Voice();
                //animal[i].Jump(); cant call this method because animal dont contain it
            }
            //Covariance preserves assignment compatibility and contravariance reverses it.
            Console.WriteLine(new string('-', 10));

            // 
            dogs = (Dog[])animal; //explicit hstak nshum enq
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }



            Console.ReadKey();
        }
    }
}
