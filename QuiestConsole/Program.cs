using System;
using QuestEngine;
namespace QuestConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
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