using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(zh);
            Thread tt = new Thread(hz);
            t.Start();
            tt.Start();
            Console.ReadKey();
        }
        static void zh()
        {
            for (int i = 0; i<=100; i++ )
            {
                Console.Write(i + " ");
            }
        }
        static void hz()
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
}
