using System;
using AulaPOOSobrescrever.classes;
namespace AulaPOOSobrescrever
{
    class Program
    {
        static void Main(string[] args)
        {
            string personagem;
            bool respostaValida= true;
            do
            {
                Console.WriteLine(@"Com qual personagem você deseja jogar?
            M- MegaMan
            Z- Zero");
                personagem= Console.ReadLine().Substring(0,1).ToUpper();
                if (personagem == "Z")
                {
                    Zero z = new Zero();
                    Console.WriteLine($"{z.pular()}");   
                    Console.WriteLine($"{z.correr()}");
                    respostaValida = true; 
                }
                else if (personagem == "M")
                {
                    MegaMan m = new MegaMan();
                    Console.WriteLine($"{m.pular()}");   
                    Console.WriteLine($"{m.correr()}");  
                    respostaValida = true; 
                } else
                {
                    Console.WriteLine("Resposta inválida, digite 'Z' para jogar com Zero e 'M' para jogar com o MegaMan");
                    respostaValida = false;
                }
            } while (respostaValida==false);
        }
    }
}
