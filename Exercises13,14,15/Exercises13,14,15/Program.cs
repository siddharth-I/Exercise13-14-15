using System;

namespace Exercises13_14_15
{
    class Program
    {
        static void Main(string[] args)
        //Exercise 13
        {
            Console.WriteLine("Enter a number: ");
            int numberOne = int.Parse(Console.ReadLine());
            for (int i = numberOne; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            // Exercise 14
            Console.WriteLine("Enter a number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberTwo; i++)
            {
                Console.WriteLine(i * i);
            }

            //Exercise 15
            Console.WriteLine("Enter a number: ");
            int numberThree = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberThree; i++)
            {
                Console.WriteLine(i * i * i);
            }
        }
    }
}
