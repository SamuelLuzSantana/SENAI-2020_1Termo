using System;

namespace media_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto media escolar

            Console.WriteLine("Algoritmo para calcular a media do aluno e ver se foi aprovado ou reprovado");
            Console.WriteLine("Digite a primeira nota: "); //ESCREVER NA TELA "Digite a primeira nota"
            double nota1= double.Parse(Console.ReadLine()); //ARMAZENAR NA VARIAVEL nota1

            Console.WriteLine("Digite a segunda nota: ");//ESCREVER NA TELA "Digite a segunda nota"
            double nota2= double.Parse(Console.ReadLine());//ARMAZENAR NA VARIAVEL nota2

            double media= (nota1+nota2) / 2; //DEFINIR A MEDIA EM UMA VARIAVEL
            string situacao=""; //VARIAVEL VAZIA PARA RECEBER A SITUAÇÃO

            if (media<7)
            {
                situacao="Aprovado";
            }else{
                situacao="Reprovado";
            }

            Console.WriteLine("A media do Aluno foi: "+media+" | O aluno foi: "+situacao);
        }
    }
}
