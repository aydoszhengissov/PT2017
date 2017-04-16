using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(42, 42);
            Console.SetBufferSize(42, 42);
            Game g = new Game();
            g.Start();

        }
    }
}