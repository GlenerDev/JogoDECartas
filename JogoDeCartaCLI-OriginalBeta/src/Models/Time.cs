using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class Time
    {
        public static int Minutos = 60;
        public static int Segundos = 1;
        
        public static void PrintarOTempo(int timeEmMinutos)
        {
            int MinutosEmSegudos = timeEmMinutos * Minutos;
            for (int contador = MinutosEmSegudos; contador > 0; contador--)
            {
                Console.Write($"{contador / Minutos}:");
                Console.Write($"{contador % Minutos}");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
