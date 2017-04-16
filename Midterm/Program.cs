using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Part1();

        }

        private static void Part1()
        {
             bool goodNumber(string x)
            {
                //converting to integer
                int a = int.Parse(x);

                if ((a % 1000 == 0) && (a % 15 != 0))
                    return true;
                return false;
            }

            for (int i = 0; i < args.Length; i++)
            {
                if (goodNumber(args[i]))
                    Console.WriteLine(args[i]);
            }
        }
    }
}
