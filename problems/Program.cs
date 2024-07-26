using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the maximum index of the array .");
            //int max_array = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the numbers ..");
            //var ints = new int[max_array];

            //for (int i = 0; i < max_array; i++)
            //{
            //    Console.WriteLine($"enter the {i + 1} number");
            //    ints[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("enter the sum you want ");
            //int sum_number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] + ints[i + 1] == sum_number)
            //    {
            //        Console.WriteLine($"number matched {ints[i]} & {ints[i + 1]}");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("not matched..");

            //    }
            //}

            //addlist addlist = new addlist();
            //addlist.list_sum();
            longsubstring lss = new longsubstring();
            lss.sub();
        }


    }
}
