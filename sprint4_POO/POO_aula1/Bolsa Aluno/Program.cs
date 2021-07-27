using System;
using Sistema_Orientado_a_Objetos.Classes;

namespace Sistema_Orientado_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno:");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Insira o nome do curso");
            aluno1.curso = Console.ReadLine();

            Console.WriteLine("Insira a idade do aluno");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o RG do aluno");
            aluno1.rg = Console.ReadLine();

            Console.WriteLine("O aluno pe bolsista? [s]/[n]");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s")
            {
                Console.WriteLine("Sim");
                aluno1.bolsista=true;
            }
            else if (resposta.ToLower() == "n")
            { 
                 Console.WriteLine("Não");
                aluno1.bolsista=false;
            }    

            Console.WriteLine("Insira a media do aluno: ");
            aluno1.mediaFinal = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Insira o valor da mensalidade: ");
            aluno1.valorDaMensalidade = double.Parse(Console.ReadLine());

            //Exibindo as informações

            Console.WriteLine($"Nome: {aluno1.nome}");
            Console.WriteLine($"Idade: {aluno1.idade}");
            Console.WriteLine($"Curso: {aluno1.curso}");
            Console.WriteLine($"Rg: {aluno1.rg}");
            Console.WriteLine($"Bolsa: {aluno1.bolsista}");
            // Console.WriteLine(aluno1.mediaFinal);
            // Console.WriteLine(aluno1.valorDaMensalidade);

            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.VerMensalidade(aluno1.bolsista, aluno1.valorDaMensalidade);



        }
    }
}
