using System;
using QuestEngine;
namespace QuestConsole
{
    class Program
    {
        private static void PrintAsterix(string s)
        {
            if (s != "")
            {
                var countOfAsterisks = "";
                foreach(var chr in s)
                    countOfAsterisks+="*";
                Console.WriteLine(countOfAsterisks);
            }
        }

        private static void PrintGreeting()
        {
            Console.WriteLine("Добро пожаловать в квест!!!\nВыбирайте действия, чтобы взаимодействовать с персонажами, и команды Reset или Exit, чтобы начать игру сначала или выйти из неё соотственно.\n");
            Console.WriteLine("Для начала игры нажмите Enter!");
            var s = ConsoleKey.A;
            bool isExit = false; 
            while (!isExit)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write("\r");
                Console.Write("   \r");
                if (Console.KeyAvailable)
                    if((s = Console.ReadKey().Key) == ConsoleKey.Enter)
                        isExit = true;
            }
        }

        private static void PrintSelectionOfActivities() =>
            Console.WriteLine("Пожалуйста, выберете тип взаимодействия с помощью tab и нажмите enter:");

        public static void Main(string[] args)
        {
            GameController gameController = new GameController();
            string[] actions = {"Агрессивный", "Дружелюбный" , "Игнорироющий", "Reset", "Exit"};
            var s = "";
            PrintGreeting();

            while (true)
            {
                PrintSelectionOfActivities();

                var key = ConsoleKey.A;
                int numberOfAction = -1;
                while ((key = Console.ReadKey().Key) == ConsoleKey.Tab || (key != ConsoleKey.Enter || numberOfAction == -1))
                {
                    if (key == ConsoleKey.Tab)
                        numberOfAction++;
                    Console.Write("\r            \r");
                    if (numberOfAction != -1)
                    {
                        numberOfAction %= 5;
                        s = actions[numberOfAction];
                        Console.Write(s);
                    }
                }
                Console.WriteLine();
                if ((s = Console.ReadLine()?.ToLower()) == "Exit")
                    break;
                if (s == "Reset")
                {
                    Console.Clear();
                    gameController.Reset();
                    PrintGreeting();
                    continue;
                }

                s = gameController.CurrentPhrase;

                if (s == "1")
                    gameController.MakeAggressiveAction();
                else if (s == "2")
                    gameController.MakeFriendlyAction();
                else if (s == "3")
                    gameController.MakeIgnoreAction();
                else
                    Console.WriteLine("Такой фразы не существует! Выберете из списка существующих!!!");
                PrintAsterix(s);
            }

            Console.WriteLine("Хорошего дня!");

            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}