using System;

namespace Data_Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");// Algoritmo para mostrar dia/mes/ano de nascimento

            Console.WriteLine("Digite a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade*65;
            int dias = idade*12;
            int horas = idade*8760;
            int minutos = idade*525600;

            Console.WriteLine("Até o momento você viveu aproximadamente,"+meses+" meses, "+dias+"dias, "+horas+" horas e "+minutos+" minutos");
        }
    }
}
