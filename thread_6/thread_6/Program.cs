using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_6
{
    class Program
    {
        static int x = 100;
        static bool lock1 = false;
        static void Main(string[] args)
        {
            Thread A = new Thread(test1);
            Thread B = new Thread(test2);
            A.Start();
            B.Start();
            
            Console.ReadKey();

        }
        //ناحیه بحرانی A
        static void test1()
        {

            while (lock1)
                goto exit;//entery section
            exit:;
            lock1 = true;
            x = x + 50;
            lock1 = false;//exit section
        }
        // ناحیه ی بحرانی B
        static void test2()
        {
            while (lock1)
                goto exit;//entery section
            exit:;
            lock1 = true;
            x = x - 20;
            lock1 = false;//exit section
            Console.Write(x);
        }
    }
}
