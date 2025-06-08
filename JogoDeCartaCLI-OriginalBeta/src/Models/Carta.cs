using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class Carta
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Dano;
        public Tipo TipoDeDano { get; set; }
        public Carta(string titulo,string descricao,int dano,Tipo tipoDano)
        {
            TipoDeDano = tipoDano;
            Descricao = descricao;
            Titulo = titulo;
            Dano = dano;
        }
        public void MostrarCarta()
        {
            Console.WriteLine($"TITULO: {Titulo}");
            Console.WriteLine($"DESCRIÇÃO: {Descricao}");
            Console.WriteLine($"Tipo de Dano: {TipoDeDano.ToString()}");
        }
    }
}
