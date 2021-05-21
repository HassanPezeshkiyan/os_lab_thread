using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(writeY);
            t.Start();
            Thread.Sleep(3000);
            for (int i = 0; i < 100; i++) Console.Write("X");
        }
        static void writeY()
        {
            for (int i=0; i<100; i++) Console.Write("Y");
        }
    }
}
