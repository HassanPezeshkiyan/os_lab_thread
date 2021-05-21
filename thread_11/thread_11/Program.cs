using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread_11
{
    class Program
    {
        static int val1 = 10;
        static int val2 = 0;
        static bool flag_i, flag_j = false;
        static string check_turn = "";
        static int result = 0;

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
            flag_j = true;
            check_turn = "i";
            while (flag_i && check_turn == "i")
            { }
                val2 = 1;
            flag_j = false;
           

        }
        static void test2()
        {
            flag_i = true;
            check_turn = "j";
            if (val2 == 0)

            {
                while (flag_i && check_turn == "i")
                { }
                Console.WriteLine("exit");
            }
            else
            {
                result = val1 / val2;
            }
            flag_i = false;
            Console.WriteLine(result);
        }

    }
}

