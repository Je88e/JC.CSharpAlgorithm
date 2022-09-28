using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.CSharpAlgorithm
{
    public static class FibonacciRecursively
    {
        public static long Calc1(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException("参数需大于0");
            }
            if (n <= 0) return 0;
            if (n <= 2) return 1;
            return checked(Calc1(n - 2) + Calc1(n - 1));
        }

        public static long Calc2(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException("参数需大于0");
            } 
            long a = 1;
            long b = 1;
            for (int i = 3; i <= n; i++)
            {
                b = checked(a + b);
                a = b - a;
            }

            return b;
        }

        public static long Calc3(int n)
        {
            if (n <= 0) return 0;
            if (n <= 2) return 1; 
            var a = 1 / Math.Sqrt(5);
            var b = Math.Pow((1 + Math.Sqrt(5)) / 2, n);
            var c = Math.Pow((1 - Math.Sqrt(5)) / 2, n);
            return checked((long)(a * (b - c)));
        }
    }
}
