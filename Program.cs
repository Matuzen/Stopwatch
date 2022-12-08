using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("0 = Sair");

            string data = Console.ReadLine().ToLower();     // ToLower converte tudo para minúsculo
            
            char type = char.Parse(data.Substring(data.Length -1, 1));            // Todo tipo string pode ser cortado através do Substring
                                                                                  // data.Length = quantidade de caracteres que o usuário digitou
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            Start(time * multiplier);  
 
        }

        static void Start(int time)
        {
           
            int currentTime = 0;
            while (currentTime != time)     // Condição
            {
                Console.Clear();
                currentTime ++;             // Incremento
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);             // Thread é a execução atual
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
        }
    }
}
