using System;

namespace Asalsayı
{
    class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimeNumber(99))
            {
                Console.WriteLine(" this is prime");
            }
            else
            {
                Console.WriteLine(" this is not prime");
            }
            Console.ReadLine();

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    
                }
            }
            return result;
        }

    }

}



