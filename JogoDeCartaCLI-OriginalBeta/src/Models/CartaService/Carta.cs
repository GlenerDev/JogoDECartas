using RPGGameCli.src.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartaCLI_OriginalBeta.src.Models.CartaService
{
    internal class Carta
    {
        public string Titulo { get; private set; }
        public string Descricao { get; set; }
        public void LogicaDeAcao { get; set; }
        public int Dano { get; set; }
        public  Tipo TipoDeDano { get; set; }
        public Carta(string titulo, string descricao, int dano, Tipo tipoDano)
        {
            TipoDeDano = tipoDano;
            Descricao = descricao;
            Titulo = titulo;
            Dano = dano;
        }

    }

}

