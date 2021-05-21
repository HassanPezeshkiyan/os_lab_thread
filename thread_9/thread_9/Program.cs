using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_9
{
    class Program
    {
        static bool flag_i, flag_j = false;
        static string check_turn = "";
        static int x = 100;
        static void Main()
        {
            Thread i = new Thread(test1);
            Thread j = new Thread(test2);
            i.Start();
            j.Start();
            Console.ReadKey();
        }
        static void test1()
        {
            flag_i = true;
            check_turn = "j";
            while (flag_j && check_turn == "j")
                goto exit;
            exit:;
            x = x + 50;
            flag_i = false;
        }
        static void test2()
        {
            flag_j = true;
            check_turn = "i";
            while (flag_i && check_turn == "i")
                goto exit; //busy_waiting
            exit:;
            x = x - 20;
            flag_j = false;
            Console.WriteLine(x);
        }
    }
}
