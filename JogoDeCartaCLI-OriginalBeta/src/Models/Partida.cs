using JogoDeCartaCLI_OriginalBeta.src.Models.CartaService;
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
        public void ComeçarRounds(int TempoDeRounds)
        {
            var j1 = Jogadores[0];
            var j2 = Jogadores[1];


            var manipulacao = new ManipulacaoDeCartas();
            manipulacao.DistribuirCartas(j1, j2);
            Jogador[] vez = { j1, j2 };
            while (j1.Vida > 0 && j2.Vida > 0)
            {
                for (int i = 0; i < vez.Length; i++)
                {
                    Console.Clear();
                    var CartasDaMAo = vez[i].PuxarTrescartas();
                    var apresentacao = new ApresentacaoDeCartas(CartasDaMAo);
                    apresentacao.PrintarListaDeCartas();

                    var CartaDaEscolhida = int.Parse(Console.ReadLine());
                    switch (CartaDaEscolhida)
                    {
                        case 1:
                            apresentacao.MostrarCarta(CartasDaMAo[0]);
                            CartaAttack.LogicAttack(CartasDaMAo, i, vez, 0); break;
                        case 2:
                            apresentacao.MostrarCarta(CartasDaMAo[1]);
                            CartaAttack.LogicAttack(CartasDaMAo, i, vez, 1); break;
                        case 3:
                            apresentacao.MostrarCarta(CartasDaMAo[2]);
                            CartaAttack.LogicAttack(CartasDaMAo, i, vez, 2); break;
                    }
                }
            }
            Vencedor = j1.Vida > 0 ? j1 : j2;
            Console.Clear();
            Console.WriteLine($"PARABENS O VENCEDOR È {Vencedor.Nome}");
        }

    }
}
