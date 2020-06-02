using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            void FuncionCadena(string FB)
            {
                Console.WriteLine(FB);
            }

            //We will print number starting from 1 to 100. When a number is multiple of three,
            //print “Fizz” instead of a number on the console and if multiple of five then print “Buzz” on the console. 
            //For numbers which are multiple of three as well five, print “FizzBuzz” on the console.

            void FizzBuzz(int comienzo, int vueltas) {

                int i;

                for (i = comienzo; i <= vueltas; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        FuncionCadena("FizzBuzz");
                    }
                    else

                        if (i % 5 == 0)
                    {
                        FuncionCadena("Buzz");
                    }
                    else

                            if (i % 3 == 0)
                    {
                        FuncionCadena("Fizz");
                    }
                    else

                        FuncionCadena(i.ToString());
                }
            }

            FizzBuzz(1, 100);
        }
    }
}
