using System;

namespace Algoritmo_nadador
{
    class Program
    {
        static void Main(string[] args)
        {

            //ALGORITMO QUE DEFINE EM QUAL CATEGORIA O NADADOR IRÁ PARTICIPAR.
            Console.WriteLine("Digite sua idade para saber em qual categoria voce irá participar: (5-20) ");
            Console.WriteLine("Digite sua idade para saber em qual categoria voce irá participar: (5-20) ");
            int idade = int.Parse(Console.ReadLine());

            if(idade>=18){
               Console.WriteLine("Categoria Senior");
            }
            if(idade>=5 && idade<=7){
                Console.WriteLine("Categoria Infantil A");
            }
            if(idade>=8 && idade<=10){
                 Console.WriteLine("Categoria Infantil B");
            }
            if(idade>=11 && idade<=13){
                 Console.WriteLine("Categoria Juvenil A");
            }
            if(idade>=14 && idade<=17){
                 Console.WriteLine("Categoria Juvenil B");
            }if(idade<5){    
                 Console.WriteLine("Idade não permitida para competir");
            }else{}

        }
    }
}
