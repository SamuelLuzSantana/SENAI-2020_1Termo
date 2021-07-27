using System;

namespace Validação_de_Especificações
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ALGORITMO PARA VALIDAR AS INFORMAÇÕES DE : NOME, IDADE,SALARIO E ESTADO CIVIL

            string nome;
            int idade;
            float salario;
            string civil;
            
            do{
                
                Console.WriteLine("\n Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("");
                
                if(nome == " "){Console.WriteLine("Defina um nome valido \n");}
            }while(nome == " ");

            do{
                
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                
                if(idade <=0 || idade>150){Console.WriteLine("Defina uma idade Valida \n");}
            }while(idade <=0 || idade>150);

            do{
                
                Console.WriteLine("Digite seu Salario: ");
                salario = float.Parse(Console.ReadLine());
                Console.WriteLine("");
                
                if(salario == 0){Console.WriteLine("Digite um Salario Valido \n");}
            }while(salario == 0);

            do{
                
                Console.WriteLine("Digite seu estado civil [s]Solteiro | [c]Casado | [v]Viuvo: ");
                civil = Console.ReadLine();
                Console.WriteLine("");

                switch(civil){
                    case"s":
                        civil="Solteiro";
                        break;
                    case"c":
                        civil="Casado";
                        break;
                    case"v":
                        civil="Viuvo";
                        break;        
                }
                
                if(civil != "v" || civil != "c" || civil != "s"){Console.WriteLine("Digite um estado civil das Opções pré determinadas.\n");}
            }while(civil != "v" || civil != "c" || civil != "s");

            Console.WriteLine("Confirme seus dados: ");
             Console.WriteLine("----------------------------");
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"Salario: R${salario}");
            Console.WriteLine($"Estado Civíl: {civil}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");


    }   
}

}
