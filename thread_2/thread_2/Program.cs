using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_2
{
    class Program
    {

        static void Main()
        {
            Thread t = new Thread(go);
            t.Start();
            for (int i = 0; i < 100; i++)
                Console.Write("*");
            Console.ReadKey();
        }
        static void go()
        {
            for (int i = 0; i < 100; i++)
                Console.Write('?');

        }
    }
}