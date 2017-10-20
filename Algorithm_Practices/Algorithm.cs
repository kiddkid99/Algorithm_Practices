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

            double a = 0;
            double b = 1;

            for(int index = 0; index < number; index++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
