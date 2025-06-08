using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RPGGameCli.src.Services.Models
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public int Vida { get; private set; } = 100;
        public int Vigor { get; set; } = 50;
        private int Mana { get; set; } = 50;
        public List<Carta> Deck = new List<Carta>();

        public Carta[] Mao { get; set; }
        public Jogador(string nome)
        {
            Nome = nome;
        }
        public void Atacar(Carta cartausadaF, Jogador oponente)
        {
            if (cartausadaF.TipoDeDano == Tipo.Fisico)
            {
                if (cartausadaF.Dano < 0 && oponente.Vida > 0)
                {
                    var acrecimoDeDano = cartausadaF.Dano = (Vigor + (Vigor * (Vigor / 100)));
                    oponente.Vida -= acrecimoDeDano;
                    return;

                }
            }
        }
        public void Enfeiticar(Carta cartausadaM, Jogador oponente2)
        {
            if (cartausadaM.TipoDeDano == Tipo.Magia)
            {
                if (cartausadaM.Dano < 0 && oponente2.Vida > 0)
                {
                    var acrecimoDeFeitico = cartausadaM.Dano = (Mana + (Mana * (Mana / 100)));
                    oponente2.Vida -= acrecimoDeFeitico;
                    return;
                }
            }
        }
        public List<Carta> PuxarTrescartas()
        {
            List<Carta> cartas = new List<Carta>(3);
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                cartas.Add(Deck[rnd.Next()]);
            }
            return cartas;
        }

    }
}

