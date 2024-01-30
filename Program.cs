using System;
using System.ComponentModel.Design;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = Char.Parse(data.Substring(data.Length - 1, 1));
            int tempo = int.Parse(data.Substring(0, data.Length - 1));
            int multipler = 1;

            if (type == 'm')
                multipler = 60;
            if (tempo == 0)
                System.Environment.Exit(0);

            PreStart(tempo * multipler);
        }
        static void PreStart(int tempo)
        {
            Console.Clear();

            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(tempo);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2000);

            Menu();
        }
    }
}