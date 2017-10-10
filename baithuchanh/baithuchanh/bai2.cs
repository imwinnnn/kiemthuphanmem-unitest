using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baithuchanh
{
    public class bai2
    {
        private int n;
        private List<int> a;

        public bai2(int n, List<int> a)//Polynomial
        {
            if (a.Count() != n + 1)
                throw new ArgumentException("Invalid Data");
            this.n = n;
            this.a = a;
        }
        public int Cal(double x)
        {
            int result = 0;
            for (int i = 0; i < this.n; i++)
            {
                result += (int)(a[i] * Math.Pow(x, i));
            }
            return result;
        }
    }
}
