using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            //We will print number starting from 1 to 100. When a number is multiple of three,
            //print “Fizz” instead of a number on the console and if multiple of five then print “Buzz” on the console. 
            //For numbers which are multiple of three as well five, print “FizzBuzz” on the console.
            int i;
            for (i = 1; i <= 100; i++)
            {
                string resultado = "";
                if (i % 5 == 0)
                {
                    resultado = "Fizz";
                }

                if (i % 3 == 0)
                {
                    resultado += "Buzz";
                }

                if (resultado.Length == 0)
                {
                    resultado = i.ToString();
                }

                Console.WriteLine(resultado);
            }
        }
    }
}
