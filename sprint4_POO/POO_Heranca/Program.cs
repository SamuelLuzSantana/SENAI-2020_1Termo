using System;
using Heranças_de_Classes.Classes;

namespace Heranças_de_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string nome;
            int escolha;
            string continuar;
            

            Pessoas pessoa1 = new Pessoas();

            Console.WriteLine("Entre com seu nome");
            nome = Console.ReadLine();

            Console.WriteLine(pessoa1.BoasVindas(nome));
            Console.WriteLine("");

            do{
                Console.WriteLine("");
                Console.WriteLine("Você é pessoa FÍSICA ou pessoa JURIDICA ");
                Console.WriteLine("[1] - PESSOA FÍSICA | [2] - PESSOA JURIDICA");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        PessoaFisica p1 = new PessoaFisica();
                    do{ 
                        Console.WriteLine("");  
                        Console.WriteLine("Digite seu rg (sem pontos ou traços): ");
                        p1.rg = Console.ReadLine();

                        p1.Verificar(p1.rg);

                        if(p1.Verificar(p1.rg)==true)
                        {
                            Console.Write("Favor digitar um rg valido");
                        }
                    }
                    while (p1.Verificar(p1.rg)==true);

                    do{ 
                        Console.WriteLine("");  
                        Console.WriteLine("Digite seu cpf (sem pontos ou traços): ");
                        p1.cpf = Console.ReadLine();

                        p1.Verificar(p1.cpf);

                        if(p1.Verificar(p1.cpf)==true)
                        {
                            Console.Write("Favor digitar um cpf valido");
                        }
                    }
                    while (p1.Verificar(p1.cpf)==true);  
                    Console.WriteLine("");
                    Console.WriteLine("Deseja continuar? [s]/[n]");
                    continuar = Console.ReadLine();           
                    
                    break;

                    case 2:
                        PessoaJuridica p2 = new PessoaJuridica();

                    do{ 
                        Console.WriteLine("");  
                        Console.WriteLine("Digite o cnpj (sem pontos ou traços): ");
                        p2.cnpj = Console.ReadLine();

                        p2.Verificar1(p2.cnpj);

                        if(p2.Verificar1(p2.cnpj)==true)
                        {
                            Console.Write("Favor digitar um cnpj valido");
                        }
                    }
                    while (p2.Verificar1(p2.cnpj)==true);            
                    
                    Console.WriteLine("");
                    Console.WriteLine("Deseja continuar? [s]/[n]");
                    continuar = Console.ReadLine();

                    break;


                    default:
                        Console.WriteLine("favor escolher uma opção valida.");
                        continuar = "s";
                     break;
                }
            
            }while(continuar=="s".ToLower());
        }
    }
}
