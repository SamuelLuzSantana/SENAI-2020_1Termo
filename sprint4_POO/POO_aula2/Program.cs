using System;

namespace Atributo_e_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando o Projeto

            Personagem jogador1 = new Personagem();
            jogador1.nome = "Golden Boy";
            jogador1.idade = 17;
            jogador1.armadura = "sky bullet";
            jogador1.IA = "Jarvan";

            Personagem jogador2 = new Personagem();
            jogador2.nome = "Aesthetic Demon ";
            jogador2.idade = 23;
            jogador2.armadura = "Gloep Stell";
            jogador2.IA = "Slayer";

            Console.WriteLine($"Partida 1 {jogador1.nome} x {jogador2.nome} ");
            
            Console.WriteLine($"Jogador 1 = {jogador1.atacar1}");
            Console.WriteLine($"Jogador 2 = {jogador2.defender}");
        }
    }
}
