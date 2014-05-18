using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angry_Children
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> LIST = new List<int>();

            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                LIST.Add(Convert.ToInt32(Console.ReadLine()));
            }

            LIST.Sort();
            var min = LIST.Take(k).Max() - LIST.Take(k).Min();
            LIST.ForEach((i) =>
                {
                    try
                    {
                        var h = LIST.GetRange(i, k);
                        if ((h.Max() - h.Min()) < min)
                        {
                            min = h.Max() - h.Min();
                        }
                    }
                    catch (Exception) { }
                });

            Console.WriteLine(min);

            Console.ReadLine();
        }
    }
}
