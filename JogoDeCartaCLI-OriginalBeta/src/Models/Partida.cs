using RPGGameCli.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class Partida
    {
        public List<Carta> DeckPrincipal = new List<Carta>();
        public Time Tempo { get; set; }
        public int Rounds { get; private set; }
        public Jogador[] Jogadores = new Jogador[2];
        public Partida(string nomeDojogador1, string nomeDojogador2)
        {
            Jogadores[0] = new Jogador(nomeDojogador1);
            Jogadores[1] = new Jogador(nomeDojogador2);
        }
        public void ComeçarRounds(int TempoDeRounds)
        {
            Time.PrintarOTempo(TempoDeRounds);
            var j1 = Jogadores[0];
            var j2 = Jogadores[1];
            CartasDoJogo.DistribuirCartas(j1, j2);
            while (j1.Vida > 0 && j2.Vida > 0)
            {
                Jogador[] vez = { j1, j2 };
                for (int i = 0; i < vez.Length; i++) 
                {
                    var CartaParaOAtaque = vez[i].
                    Console.WriteLine("Escolha a carta que esta na sua mão:");
                    var CartaDaEscolhida = int.Parse(Console.ReadLine());
                    switch (Carta) 
                    {
                        case 1:

                    
                    
                    
                    }

                    
                }


            }

        }

    }
}
