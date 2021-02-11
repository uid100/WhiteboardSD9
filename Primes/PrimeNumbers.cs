using System;

namespace Primes
{
    public class PrimeNumbers
    {
        public static bool IsPrime(int number)
        {
            //int maxRange = (int)Math.Sqrt(number);

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int SumOfPrimes(int maxNumber)
        {
            int sum = 0;

            for (int i = 2; i <= maxNumber; i++)
            {
                //sum += IsPrime(i) ? i : 0;
               
                if( IsPrime(i) )
                {
                    sum += i;
                }
                
            }

            return sum;
        }
    }

}
