using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Jars
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = Console.ReadLine().Split(' ');
            dynamic N = Convert.ToInt32(v.First().Trim()),
            M = Convert.ToInt32(v.Last().Trim());

            Double ukupno = 0;

            for (int i = 0; i < M; i++)
            {
                var t = Console.ReadLine().Split(' ');
                dynamic begin = Convert.ToInt32(t[0]),
                    end = Convert.ToInt32(t[1]),
                    num = Convert.ToInt32(t[2]);

                ukupno += (double)(Math.Abs(end - begin) + 1) * num / N;
            }

            Console.WriteLine((UInt64)Math.Floor(ukupno));
            Console.ReadLine();
        }
    }
}