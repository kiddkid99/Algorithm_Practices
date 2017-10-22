using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Practices
{
    public class Algorithm
    {
        public static double Fibonacci(int number)
        {
            //Use memoization
            //memorize previous value after cacualted

            double result = 0;
            double first = 0;
            double second = 1;

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
