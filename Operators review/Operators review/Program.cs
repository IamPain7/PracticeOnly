using System;

namespace Operators_review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Review Operators Unary!!
            // Pre fix 
            int a = 1;     // 1 increment the value of 2 so the value of a is now 2 
            int b = a++;  //B will take the value of A which is 1 and increment of 1 so the value of B is 2. The new value of a is 2 

            Console.WriteLine($"The result of A {a} , the result B {b}");

            //Pre fix
            int c = 2; // The value of C is now 2 increment with 1 the value now is 3 
            int d = ++c; // The value of D is 2 and the value of A is 2 increment in 1  

            Console.WriteLine($"The result of C is {c} , The result of D is {d}");

            /* Binary or Arthemetic
             * +
             * *
             * /
             * % <---- it will give us the remainder 
             */
            // Sample of Addition 
            int isADd = 2 + 3;
            Console.WriteLine($" The result of Addition sample is {isADd}");
            //Sample of Multiplication
            int isMultiply = 2 * 4;
            Console.WriteLine($"The result of Multiplication {isMultiply}");
            //Sample of Multiplication 
            int isDivision = 10 / 2;
            Console.WriteLine($"The result of Division {isDivision}");
            //Sample of Remainder
            int isRemainder = 10 % 5;
            Console.WriteLine($"The result of Remainder {isRemainder}");

            /* Logical Operators
             * &&
             * ||
             */

            //Sample of Logical Operators
            // This is only for example
            bool test = false;
            bool test1 = false;
            bool result = test ==test1;

            if (test && test1)
            {

                Console.WriteLine($"{result}");
            }


            if (test || test1)
            {

                Console.WriteLine($"{result}");

            }

            //Assigment Operator used to assign a value to a variable
            //= Assignment 
            //+=
            //-=
            //Sample

            //using explicit typing
            // ab= 2 cb=2
            //ab+=cb or ab-cb
            int ab = 2;
            int cb = 2;
            int resultOperator = ab += cb;
<<<<<<< HEAD
=======
            Console.WriteLine($" AB result {ab}  , CB result {cb}");
>>>>>>> reviewbranchonly
            Console.WriteLine($"{resultOperator}");
            

            /* type of Operations 
             * Unary operations post and fix 
             * Relational Operation
             * Logical Operations
             * Assignement Operations
             * Binary or Arithmetics
             */
        }
         
            

    }
}
