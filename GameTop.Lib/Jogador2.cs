using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
         public string Chuta()
        {
            return "Maradona estas Pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas Corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas Pasando \n";
        }
    }
}