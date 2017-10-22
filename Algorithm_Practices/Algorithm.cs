using System.Numerics;

namespace Algorithm_Practices
{
    public class Algorithm
    {
        public static BigInteger Fibonacci(int number)
        {
            //Use memoization
            //memorize previous value after cacualted

            BigInteger result = 0;
            BigInteger first = 0;
            BigInteger second = 1;

            if (number == 0) return 0;
            if (number == 1) return 1;

            for(int index = 2; index <= number; index++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }
    }
}
