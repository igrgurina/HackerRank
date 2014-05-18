using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Fibo
{
    class Program
    {
        /// <summary>
        /// A utility function that returns true if x is perfect square
        /// </summary>
        public static Boolean isPerfectSquare(Int64 x)
        {
            Int64 s = (Int64)Math.Sqrt(x);
            return (s * s == x);
        }

        /// <summary>
        /// Returns true if n is a Fibinacci Number, else false
        /// </summary>
        public static Boolean isFibonacci(Int64 n)
        {
            // n is Fibonacci if one of 5*n*n + 4 or 5*n*n - 4 or both
            // is a perfect square
            return isPerfectSquare(5 * n * n + 4) ||
                isPerfectSquare(5 * n * n - 4);
        }

        /// <summary>
        /// A number is Fibonacci if and only if one or both of (5*n^2 + 4) or (5*n^2 – 4) is a perfect square
        /// </summary>
        static void Main(string[] args)
        {
            Int32 num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(isFibonacci(Convert.ToInt64(Console.ReadLine())) ? "IsFibo" : "IsNotFibo");
            }
        }
    }
}
