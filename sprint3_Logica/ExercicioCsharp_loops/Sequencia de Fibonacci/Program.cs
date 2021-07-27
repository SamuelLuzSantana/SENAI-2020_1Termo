using System;

namespace Sequencia_de_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequencia de fibonacci

            int n1 = 1;
            int n2 = 0;
            int soma = 0;
            int vezes = 0;
            string continuar ="sim";

            

            do{
                Console.WriteLine("Digite o numero de vezes que gostaria de saber a sequencia: ");
                vezes = int.Parse(Console.ReadLine());
                for(var i=1; i<=vezes; i++){


                    soma = n1+n2;
                    n2 = n1;
                    n1 = soma;

                    Console.WriteLine($"A sequencia é: {soma}");     

                    Console.WriteLine("Deseja refazer?");
                    continuar = Console.ReadLine();

                    if(continuar!="sim"){
                        Console.WriteLine("Ok, muito Obrigado");
                        break;
                    }

                }      

            }while(continuar!="sim");


        }
    }
}
