using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baithuchanh
{
    public class bai1
    {
        //public bai1() { }
        public static double Power(float x, float n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return x * Power(x, n - 1); // return n * Power(x, n - 1); FALSE
            else return Power(x, n + 1) / x;
        }

    }
}
