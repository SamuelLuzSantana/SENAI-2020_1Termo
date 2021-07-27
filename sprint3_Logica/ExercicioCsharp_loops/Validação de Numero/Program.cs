using System;

namespace Validação_de_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algotimo para validação de um Numero de 0-10

            int numero;

            do{
                Console.WriteLine("Digite um Numero de 0-10: ");
                numero = int.Parse(Console.ReadLine());
               
                if(numero<0 || numero>10){
                    Console.WriteLine("Numero Invalido \nTente novamente");
                }


            }while(numero<0 || numero>10);
               
            Console.WriteLine("Numero Valido, Obrigado!");
        }
    }
}
