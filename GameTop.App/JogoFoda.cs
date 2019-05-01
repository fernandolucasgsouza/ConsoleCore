
using System;
using GameTop.Interface;

namespace GameTop.App
{
     class JogoFoda
    {
        private IJogador _JogadorA;
        private IJogador _JogadorB;

        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
           Console.Write(_JogadorA.Chuta());
           Console.Write(_JogadorA.Chuta());
           Console.Write(_JogadorA.Corre());
           
           Console.Write("\n PRÓXIMO JOGADOR \n\n");

           Console.Write(_JogadorB.Corre());
           Console.Write(_JogadorB.Passe());
           Console.Write(_JogadorB.Passe());
        }
    }
}