using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_4
{
    class Program
    {
        static bool done;
        static void Main()
        {
            Thread t = new Thread(go);
            t.Start();
            go();
            Console.ReadKey();
        }
        static void go()
        {
            if (!done)
            {
                done = true;
                Console.Write("done");
            }
        }
    }
}

