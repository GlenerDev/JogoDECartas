using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class CartasDoJogo
    {
        public static Dictionary<int, Carta> DeckGame { get; } = new()
        {
            { 1, new Carta("Cura do arcano", "Cura 10 de vida.", 10, Tipo.Magia) },
            { 2, new Carta("Bola de fogo", "tira 30 de vida do adversario.", 30, Tipo.Magia) },
            { 3, new Carta("Ataque da serpente", "Tira 12 de vida do adversario.", 12, Tipo.Fisico)},
            { 4, new Carta("Guinada da espada", "tira 5 de vida.", 5, Tipo.Fisico) },
            { 5, new Carta("Flexa da Guerra", "Tira 45 de vida do adversário.", 45, Tipo.Magia) },
            { 6, new Carta("Chora mana", "A cada round sera dado 10 de mana no  maximo 2 veses.", 10, Tipo.Fisico) },
            { 7, new Carta("Big bundada", "Tira 25 de vida.", 25, Tipo.Fisico) },
            { 8, new Carta("Escudo Da Misericordia", "Os proximo 10 de dano que receber sera discontado no atacante.", 10, Tipo.Defesa) },
            { 9, new Carta("Ladrao de Coringa", "Pega a melhor carta do adversario.", 0, Tipo.Fisico) },
            { 10, new Carta("Ataque da serpente", "Tira 12 de vida do adversario", 12, Tipo.Fisico) },
        };
        public static void ListarTodasAsCartasDoGame()
        {
            foreach (var item in DeckGame)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"TITULO:{item.Key}\nDESCRIÇÂO:{item.Value.Descricao}\nDANO:{item.Value.Dano}\n");
            }
        }
        public static Carta CartaAleatoria()
        {
            var cards = new Dictionary<Carta, int>();
            foreach (var item in DeckGame.Values)
            {
                Random random = new Random();
                var numero = random.Next(1, 100);
                cards.Add(item, numero);
            }
            int maxvalue = cards.Values.Max();
            Carta card2 = cards.FirstOrDefault(pair => pair.Value == maxvalue).Key;
            return card2;
        }
        static public List<Carta> Embaralhar(List<Carta> depositoDecarta)
        {
            int[] contagem = { 1, 2, 3 };
            foreach (var numero in contagem)
            {
                depositoDecarta.Add(CartaAleatoria());
            }
            return depositoDecarta;
        }
        static public void DistribuirCartas(Jogador jogadorAReceber1, Jogador jogadorAReceber2)
        {
            jogadorAReceber1.Deck = Embaralhar(DeckGame.Values.ToList());
            jogadorAReceber2.Deck = Embaralhar(DeckGame.Values.ToList());
        }
    }
}
