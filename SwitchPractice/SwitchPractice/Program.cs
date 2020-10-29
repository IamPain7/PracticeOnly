using System;

namespace SwitchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var userResponse = Console.ReadLine();

        

            switch (userResponse.ToLower())

            {
               case "English":
                    Console.WriteLine($"Not a fan but its important");
                    break;

                case "Math":

                    Console.WriteLine($"I rather be a stripper");
                    break;

                case "Science":

                    Console.WriteLine($" God vs science? Good subject!!");
                    break;

                case "History":

                    Console.WriteLine($" Culture culture cultre!");
                    break;

                default:
                    Console.WriteLine("I am bored");
                    break;
            }

        }
    }
}
