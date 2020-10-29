using System;

namespace IfElsePractice
{
    class Program
    {

        /* 
         * Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            var r = new Random();
            var favNumber = r.Next(1,1000);

            var userInput = int.Parse(Console.ReadLine());


            The following code will allow the user to guess what your favorite number is:
            var userInput = int.Parse(Console.ReadLine());

            Create an if-statement that if the guessed number is below the initial value, print out “too low”.
            Create an else-if statement that if the number is higher than the initial value, print out “too high”.
            Create an else statement that prints out “Nevermind”.

         */
        static void Main(string[] args)
        {

            Console.WriteLine("Guess my fav number");

            int myNumber = 31;
            // var r = new Random();
            // var favNumber = r.Next(1,40);
            var userInput = int.Parse(Console.ReadLine());
           
   



              if(userInput>myNumber)
            {

                Console.WriteLine($"Good! {myNumber} is my favorite number");
               
                
            }

            else if (userInput > myNumber)
            {
                Console.WriteLine("Too High! Try again!");
            }

            else if (userInput < myNumber)
            {
                Console.WriteLine("Too low. Try again");

            }

            else
            {


                Console.WriteLine("Never mind ");

            }
        }

    }

}