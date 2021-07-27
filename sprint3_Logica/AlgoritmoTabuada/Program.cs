using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALGORITMO DE UMA TABUADA

            Console.WriteLine("Algoritmo de Tabuada:");
            Console.WriteLine("Digite o numero para saber a tabuada até o 10: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            for (int num = 0;num<11;num++)
            {
                int resultado = num*numero;
                Console.WriteLine($"{numero} X {num} = {resultado}");
            }
        }
    }
}
