using System;

namespace FizzBuzz
{
    class Program
    {
        //We will print number starting from 1 to 100. When a number is multiple of three,
        //print “Fizz” instead of a number on the console and if multiple of five then print “Buzz” on the console. 
        //For numbers which are multiple of three as well five, print “FizzBuzz” on the console.

        static void Main(string[] args)
        {
            //funciones
            void FuncionCadena(string FB)
            {
                Console.WriteLine(FB);
            }

            void FizzBuzz(int comienzo, int vueltas, string FB, string B5, string F3) {

                int i;

                for (i = comienzo; i <= vueltas; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        FuncionCadena(FB);
                    }
                    else

                        if (i % 5 == 0)
                    {
                        FuncionCadena(B5);
                    }
                    else

                            if (i % 3 == 0)
                    {
                        FuncionCadena(F3);
                    }
                    else

                        FuncionCadena(i.ToString());
                }
            }
            // Consola
            int num1, num2; 
            string FB, B5, F3;
            Console.WriteLine("Enter a number to start");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number to finish");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do I have to say when is multiple of three and five?");
            FB = Console.ReadLine();

            Console.WriteLine("What do I have to say when is multiple of five?");
            B5 = Console.ReadLine();

            Console.WriteLine("What do I have to say when is multiple of three?");
            F3 = Console.ReadLine();

            FizzBuzz(num1, num2, FB, B5, F3);
        }
    }
}
