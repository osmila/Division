using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    public static class ArithmeticOperation
    {
        public static double Divide (double numerator, double denumerator)
        {
            if (denumerator == 0)
            {
                throw new DivideByZeroException();
            }

            double result = 0;
            result = numerator / denumerator;

            return result;
        }
    }
}
