using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_8
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(go);
            t.Start();
            t.Join();
            for (int i = 0; i < 20; i++)
                Console.Write("*");
            Console.ReadKey();
        }
        static void go()

        {
            for (int i = 0; i < 20; i++)

                Console.Write("+");
        }
    }
}

