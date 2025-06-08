using RPGGameCli.src.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class Game
    {
        public static List<Partida> ListaDePartida = new List<Partida>();
        public void Run()
        {
            MenuOpcoes();
        }
        public void MenuOpcoes()
        {
            Console.WriteLine("1 - Iniciar novo Jogo");
            Console.WriteLine("2 - Fechar jogo");

            var opcao = Convert.ToInt64(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    CriarPartida();
                    break;
                case 2:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }
        public void CriarPartida()
        {
            Console.Write("Coloque o nome do jogador 1:");
            string? Jogador1 = Console.ReadLine();
            Console.Write("Coloque o nome do jogador 2:");
            string? Jogador2 = Console.ReadLine();
            var partidainciada = new Partida(Jogador1, Jogador2);
        }
    }
}
