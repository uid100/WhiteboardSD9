using System;

namespace Primes
{
    public class PrimeNumbers
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number-1; i++)
                if (number % i == 0) return false;
            return true;
        }
    }
}
