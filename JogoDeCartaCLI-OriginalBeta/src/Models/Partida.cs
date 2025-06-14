using JogoDeCartaCLI_OriginalBeta.src.Models.CartaService;
using JogoDeCartaCLI_OriginalBeta.src.Models.JogadorService;
using JogoDeCartaCLI_OriginalBeta.src.Models.TimerService;
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
        public Jogador Vencedor { get; set; }
        public List<Carta> DeckPrincipal = new List<Carta>();
        public Time Tempo { get; set; }
        public int Rounds { get; private set; }
        public Jogador[] Jogadores = new Jogador[2];
        public Partida(string nomeDojogador1, string nomeDojogador2)
        {
            Jogadores[0] = new Jogador(nomeDojogador1);
            Jogadores[1] = new Jogador(nomeDojogador2);
        }
        public void ComeçarRounds()
        {
            //colocar os jogadores dentro uma array pra ficar mais fácil de manipular
            var j1 = Jogadores[0];
            var j2 = Jogadores[1];
            Jogador[] VezDoJogador = { j1, j2 };

            var manipulacao = new ManipulacaoDeCartas();
            manipulacao.DistribuirCartas(j1, j2);

            while (j1.Vida > 0 && j2.Vida > 0)
            {
                var indexplay1 = 0;
                var indexplay2 = 1;
                for (int i = 0; i < VezDoJogador.Length; i++)
                {
                    Console.Clear();
                    var CartasDaMAo = VezDoJogador[indexplay1].Mao = VezDoJogador[indexplay1].PuxarTrescartas().ToArray();
                    var apresentacao = new ApresentacaoDeCartas(CartasDaMAo);
                    MostrarJogador.MostrarAVezDoJogador(VezDoJogador[indexplay1]);
                    Console.WriteLine($"{VezDoJogador[indexplay2].Nome}\nVIDAS:{VezDoJogador[indexplay1].Nome}:{VezDoJogador[indexplay1].Vida}|{VezDoJogador[indexplay2].Nome}:{VezDoJogador[indexplay2].Vida}");
                    apresentacao.PrintarArrayDeCartas();
                    VezDoJogador[indexplay1].Atacando(VezDoJogador[indexplay2]);
                    indexplay1 = 1;
                    indexplay2 = 0;
                }
            }
            Vencedor = j1.Vida > 0 ? j1 : j2;
            Console.Clear();
            Console.WriteLine($"PARABÉNS, O VENCEDOR È {Vencedor.Nome.ToUpper()}");
        }
    }
}

