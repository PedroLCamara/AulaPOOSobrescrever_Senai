using System;

namespace AulaPOOSobrescrever.classes
{
    public class Player
    {
        public float velocidade;
        public float forcaPulo;

        public virtual string pular(){
            return "O personagem pulou!";
        }
        public virtual string correr(){
            return "O personagem correu!";
        }
    }
}