using System;

namespace Equação_2grau
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALGORTIMO PARA EQUAÇÃO DE SEGUNDO GRAU ONDE MOSTRA X1 E X2.
            Console.WriteLine("Algoritmo para determinar o Valor de x1 e x2");
            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int c = int.Parse(Console.ReadLine());

            double bquadrado = Math.Pow(b , 2);
            double delta = (bquadrado-(4*a*c));
            int div = (2*a);

            double x1 = ((-b + delta)/div);
            double x2 = ((-b - delta)/div);

            Console.WriteLine("O Valor do X1 é: " + x1);
            Console.WriteLine("O Valor do X2 é: " + x2);
            Console.WriteLine("O Valor do Delta é: " + delta);

        }
    }
}
