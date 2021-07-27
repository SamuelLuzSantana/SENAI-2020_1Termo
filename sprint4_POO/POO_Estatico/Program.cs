using System;
using Metodos_Estáticos.Classes;



namespace Metodos_Estáticos
{
    class Program
    {
        static void Main(string[] args)
        {

          int escolha;
          string continuar="s";

            //Inicio Algoritmo
            Console.Clear();
            Console.WriteLine(" Programa de Conversão ");
            Console.WriteLine("----------------------");

          do
          {
              
            Console.WriteLine("");
            Console.WriteLine("O que gostaria de Fazer?");
            Console.WriteLine("[1] - Converter DOLAR para REAL | [2] - Converter REAL para DOLAR |  [3] - Converter EURO para REAL | [4] - Converter REAL para EURO ");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite o Valor em DOLAR ($): ");
                    Conversor.valorUsuario = float.Parse(Console.ReadLine());

                    Console.Write("O valor de Dolar para Real é");
                    Console.Write(" R$: " + Conversor.DolarReal() );

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja fazer Outra Conversão? [s]/[n]");
                    continuar = Console.ReadLine();
                    Console.WriteLine("");

                    if (continuar == "n")//caso de repetição
                    {
                        Console.WriteLine("Obrigado e até breve.");
                    }
                    else
                    {
                        continuar="s";
                    }
                    break;
                
                case 2:
                    Console.Write("Digite o Valor em REAL (R$): ");
                    Conversor.valorUsuario = float.Parse(Console.ReadLine());

                    Console.Write("O valor de Real para dolar é");
                    Console.Write(" US$: " + Conversor.RealDolar() );

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja fazer Outra Conversão? [s]/[n]");
                    continuar = Console.ReadLine();
                    Console.WriteLine("");

                    if (continuar == "n")//caso de repetição
                    {
                        Console.WriteLine("Obrigado e até breve.");
                    }
                    else
                    {
                        continuar="s";
                    }

                    break;
                
                case 3:
                    Console.Write("Digite o Valor em EURO (£): ");
                    Conversor.valorUsuario = float.Parse(Console.ReadLine());

                    Console.Write("O valor de EURO para REAL é");
                    Console.Write(" R$: " + Conversor.EuroReal() );

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja fazer Outra Conversão? [s]/[n]");
                    continuar = Console.ReadLine();
                    Console.WriteLine("");

                    if (continuar == "n")//caso de repetição
                    {
                        Console.WriteLine("Obrigado e até breve.");
                    }
                    else
                    {
                        continuar="s";
                    }

                    break;
                
                case 4:
                    Console.Write("Digite o Valor em REAL (R$): ");
                    Conversor.valorUsuario = float.Parse(Console.ReadLine());

                    Console.Write("O valor de REAL para EURO é");
                    Console.Write(" £: " + Conversor.RealEuro() );

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja fazer Outra Conversão? [s]/[n]");
                    continuar = Console.ReadLine();
                    Console.WriteLine("");

                    if (continuar == "n")//caso de repetição
                    {
                        Console.WriteLine("Obrigado e até breve.");
                    }
                    else
                    {
                        continuar="s";
                    }

                    break;



                default:
                    Console.WriteLine("Por Favor insira uma opção valida!");
                    continuar="s";
                    break;
            }
                } while (continuar=="s");

        }
    }
}
