using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartaCLI_OriginalBeta.src.Models.CartaService
{
    internal class ApresentacaoDeCartas
    {
        public List<Carta> ListaDeCartas { get; set; }
        public Array ArrayCartas;
        public Carta Carta;  

        public ApresentacaoDeCartas(List<Carta> lista,Carta carta,Array arrayDeCarta) 
        {
            ListaDeCartas = lista;
            ArrayCartas = arrayDeCarta;
            Carta = carta;

        }
        public void MostrarCarta(Carta carta)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"TITULO: {carta.Titulo}");
            Console.WriteLine($"DESCRIÇÃO: {carta.Descricao}");
            Console.WriteLine($"Tipo de Dano: {carta.TipoDeDano.ToString()}");
            Console.WriteLine($"Dano: \u00b1[32m{carta.Dano}\u00b1[0m");
            Console.ResetColor();

        }
        public  void PrintarListaDeCartas()
        {
            foreach (var item in ListaDeCartas )
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"TITULO:{item.Titulo}\nDESCRIÇÂO:{item.Descricao}\nDANO:{item.Dano}\n");
            }
        }
    }
}
