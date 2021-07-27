using System;

namespace Data_nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo para calcular data e converter em semanas

            Console.WriteLine("digite o seu ano de nascimento:");
            int ano = int.Parse(Console.ReadLine());

            int idade = 2020 - ano;
            double semanas = idade*52.178;

            Console.WriteLine("A sua idade é: "+ idade+" e você viveu aproximadamente " + semanas +"semanas");
        }
    }
}
