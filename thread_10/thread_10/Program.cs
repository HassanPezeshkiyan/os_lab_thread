using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_10
{

    public delegate void ParameterizedThreadStart(object obj);
    class Program
    {

        static void Main()
        {
            Thread t = new Thread(go);
            t.Start(true);
            go(false);
            Console.ReadKey();
        }
        static void go(object uppercase)

        {
            bool upper = (bool)uppercase;

            Console.WriteLine(upper ? "hello" : "HELLO");
        }
    }
}

