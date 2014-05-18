using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    class Program
    {
        public class Tree
        {
            internal const Int32 initialHeight = 1;
            Int32 height = initialHeight;

            public Tree(Int32 numOfCycles)
            {
                for (int i = 0; i < numOfCycles; i++)
                {
                    if ((i - 1) % 2 == 1)
                    {
                        height *= 2;
                    }
                    else height += 1;
                }

                Console.WriteLine(height);
            }
        }

        static void Main(string[] args)
        {
            var numOfTestcases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numOfTestcases; i++)
            {
                new Tree(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
