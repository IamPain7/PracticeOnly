using System;

namespace syntaxsugar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Syntax is the grammar in programming
            //syntax and syntax sugar
            //CCR Clear, Concise, Readable
            //Best practice= not required but is considered the best thing to do
            //infer typing when we are using var to use data type. infer name needs must have variables and values 
            //sample
            var name = "jj";
            // explicit typing is when we want to specify what type of data type we are using
            string name1;
            //inline statement or Inter syntax sugar
            //sample 
            var myNumber = 31;

            var myAge = (myNumber < 31) ? $"{myNumber} is not my age" : $"9 is greater than {myNumber}";//ternary or iflines or syntax sugar


            //String Interpolation

            Console.WriteLine($"{myAge}     {myAge}     {myAge}     {myAge}  ");




            //Syntax and Syntax Sugar
            // CCL Clear, Consise, Readable
            //The Grammar in Programming
            //Infer and impicit
            //String interpolation
            //inline or ternary


            var num = 7;
            var myFavnumber = (num < 10) ? $" {num} is lesser than 10" : $"Its geater than {num}";

            var myresult = (num > 10) ? $"OK {num}": $"ok{num}";

            var myNumber1 = (num == 7) ? $"ok {num}" : $"ok lets go {num}";





        }




        }

    }
}
