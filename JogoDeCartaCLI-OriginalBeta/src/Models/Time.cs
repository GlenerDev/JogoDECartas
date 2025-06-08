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
        
        public static int PrintarOTempo(int timeEmMinutos,Jogador p1 , Jogador p2,Partida partida)
        {
            int MinutosEmSegudos = timeEmMinutos * Minutos;
            int contador = 0;
            for ( contador = MinutosEmSegudos; contador > 0; contador--)
            {
                Console.Write($"{contador / Minutos}:");
                Console.Write($"{contador % Minutos}");
                Thread.Sleep(1000);
                if (p1.Vida <= 0 || p2.Vida <= 0) 
                {
                    return contador;
                }
                Console.Clear();
            }
            if (contador == 0) 
            {
                if (p1.Vida < p2.Vida) 
                {
                    partida.Vencedor = p2;
                    return contador;
                }
                partida.Vencedor = p1;


            }
            return contador;
        }
    }
}
