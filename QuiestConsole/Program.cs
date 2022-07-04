using System;
using QuestEngine;
namespace QuestConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("bye1");
            Console.WriteLine("bye2");
            Console.WriteLine("bye3");

            int a = 0;
            int b = 2;
            (a, b) = (b, a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("byeeeee");
            Console.WriteLine("byeeeee");
            Console.WriteLine("byeee");
            (b, a) = (a, b);
            Console.ReadKey();
        }
    }
}