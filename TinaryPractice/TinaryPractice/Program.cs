using System;

namespace TinaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = 31;

            var num1 = (num >20) ? $"{num} is greater than 20" : $" 20 is lesser than {num}";

            Console.WriteLine($"{num1}");

            }
    }
}
