using System;
using GameTop.Lib;

namespace GameTop.App
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new JogoFoda(new Jogador1("Fernando"), new Jogador2());
            jogo.IniciarJogo();
        }
    }
}
