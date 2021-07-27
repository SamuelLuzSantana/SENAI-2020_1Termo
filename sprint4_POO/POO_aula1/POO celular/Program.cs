using System;
using POO_celular.Classes;

namespace POO_celular
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa Celular

            string ligado;
            int escolha;
            string continuar="";
            string nome;
           
            Console.Clear();

            Celular celular1 = new Celular();

            Console.WriteLine("Bem vindo ao SUPER SMARTPHONE 2020 v1.0.1!!!");
            Console.WriteLine("Primeiro, o celular esta ligado? [s]/[n]");
            ligado = Console.ReadLine().ToLower();

            if (ligado=="n")
            {
                Console.WriteLine("Deseja Ligalo? [s]/[n]");
                ligado = Console.ReadLine();

                if (ligado=="n")
                {
                    Console.WriteLine("Obrigado por usar o SUPER SMARTPHONE 2020 v1.0.1!!!");
                }
                
            } 

            celular1.ligar();
            

            do
            {
                Console.WriteLine("O que deseja fazer?: ");
                Console.WriteLine("[1] - ligar | [2] - Enviar Menssagem | [0] - Sair");
                escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Para quem deseja Ligar? ");
                        nome = Console.ReadLine();
                        Console.WriteLine("-");
                        Console.WriteLine("");

                        celular1.ligacao();Console.Write(nome);
                        Console.WriteLine("");

                        
                        Console.WriteLine("Deseja Continuar? [s]/[n] ");
                        continuar = Console.ReadLine();

                        break;

                    case 2:
                        Console.WriteLine("Para quem deseja enviar Mensagem? ");
                        nome = Console.ReadLine();
                        Console.WriteLine("-");
                        Console.WriteLine("");

                        celular1.mensagem();Console.Write(nome);
                        Console.WriteLine("");

                        
                        Console.WriteLine("Deseja Continuar? [s]/[n] ");
                        continuar = Console.ReadLine();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por usar o SUPER SMARTPHONE 2020 v1.0.1!!!");
                         continuar = "n";
                        break;                        

                    default:
                        Console.WriteLine("Favor selecionar uma opção valida");
                        continuar = "s";
                        break;
                }
                
                
            } while (continuar=="s");

            Console.WriteLine("Obrigado por usar o SUPER SMARTPHONE 2020 v1.0.1!!!");
            




        }
    }
}
