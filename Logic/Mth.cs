using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public static class Mth
    {


        private static int CalcFiboReal (int n)
        {
            if ((n == 0) || (n == 1))
                return n;
            else
                return CalcFiboReal(n - 1) + CalcFiboReal(n - 2);
        }

        public static int CalculateFibonacci(int n)
        {

            //restrictions 1 <= N <= 100
            if (n < 1 || n > 100)
                return -1;

            return CalcFiboReal(n);


        }

    }
}