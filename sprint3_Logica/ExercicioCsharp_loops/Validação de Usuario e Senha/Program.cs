using System;

namespace Validação_de_Usuario_e_Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALGORTIMO QUE VALIDA SE USUARIO E SENHA SÃO IGUAIS
            
            string usuario = "";
            string senha = "";

            while(true){
                Console.WriteLine("Escreva seu nome de usuario");
                usuario= Console.ReadLine();

                Console.WriteLine("Escreva sua senha :");
                senha = Console.ReadLine();

                if(senha == usuario){
                    Console.WriteLine("*Seu nome de usuario não pode ser igual a sua senha!*");
                }else{break;}
            }

            Console.WriteLine("O seu nome e senha são validos , Bem vindo " + usuario);
        }
    }
}
