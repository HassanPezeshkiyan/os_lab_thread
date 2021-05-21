using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_7
{
    class Program
    {
        static bool done;
        static readonly object locker = new object();
        static void Main()
        {
            Thread t = new Thread(go);
            t.Start();
            go();
            Console.ReadKey();
        }
        static void go()
        {
            lock (locker)
            {
                if (!done)
                {
                    done = true;
                    Console.WriteLine("done");
                }
            }
        }
    }
}
