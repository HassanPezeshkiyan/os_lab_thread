using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread_14
{
    class Program
    {
        static int x = 0;
        static Semaphore s = new Semaphore(3, 3);//Available=3,capacity=3;
        static void Main()
        {

            for (int i = 0; i < 10; i++)
                new Thread(go).Start();
            // Console.Write(x);
            Console.ReadKey();
        }
        static void go()
        {
            //while (true)
            //{
            s.WaitOne();
            {
                // Thread.Sleep(100); // only 3 threads can get here at once
                x++;
            }
            s.Release();
            Console.WriteLine(x);
            //}

        }
    }
}



