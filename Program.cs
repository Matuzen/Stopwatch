using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Menu()
        {
           
 
        }

        
        static void PreStart(int time)
        {
           
        }

        static void Start()
        {
            int time = 0;       // Quanto esse contado irá contar
            int currentTime = 11;      // Minuto atual

            while (currentTime != time)     // Exibir o tempo que ele está contando
            {
                Console.Clear();
                currentTime--;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

        }
    }
}
