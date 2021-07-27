using System;

namespace Projeto_de_Produtos.Classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Logar();

            if(Logado == true){
                GerarMenu();
            }
        }
        
        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();
            
            string opcao = "n";
            string continuar ="s";

            do{

                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("[1] - Cadastrar Marca | [2] - Listar Marca | [3] - Excluir Marca | [4] - Cadastrar Produto | [5] - Listar Produto | [6] - Excluir Produto | [0] - Sair da aplicação");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        marca.Cadastrar();
                        Console.WriteLine("Deseja Fazer outra operação? [s] - sim / [n] - não");
                        
                        continuar = Console.ReadLine();

                        break;

                    case "2":
                        marca.Listar();
                        Console.WriteLine("Deseja Fazer outra operação? [s] - sim / [n] - não");
                        
                        continuar = Console.ReadLine();
                        break;

                    case "3":

                        Console.WriteLine("Digite o codigo para excluir a marca: ");
                        int codigo = int.Parse(Console.ReadLine());

                        marca.Deletar(codigo);
                        Console.WriteLine("Deseja Fazer outra operação? [s] - sim / [n] - não");
                        
                        continuar = Console.ReadLine();

                        break;

                    case "4":
                        produto.Cadastrar();
                        Console.WriteLine("Deseja Fazer outra operação? [s] - sim / [n] - não");
                        
                        continuar = Console.ReadLine();

                        break;

                    case "5":
                        produto.Listar();
                        Console.WriteLine("Deseja Fazer outra operação? [s] - sim / [n] - não");
                        
                        continuar = Console.ReadLine();
                        break;

                    case "6":

                         Console.WriteLine("Digite o codigo para excluir o produto: ");
                        int codigo1 = int.Parse(Console.ReadLine());

                        produto.Deletar(codigo1);
                        Console.WriteLine("Deseja Fazer outra operação? [s] - sim / [n] - não");
                        
                        continuar = Console.ReadLine();

                        break;

                    case "0":
                        Console.WriteLine("Obrigado por usar a aplicação :)");
                        break;


                    default:
                        Console.WriteLine("Favor selecione uma opção Valida");
                        
                        continuar = "s";
                        break;
                }
                


            }while(continuar == "s" );

            
        }


        public void Logar(){
            
            while(Logado == false){
                
                Usuario user = new Usuario();

                Console.WriteLine("Digite seu email: ");
                string emailLogin = Console.ReadLine();
                
                Console.WriteLine("Digite sua senha: ");
                string senhaLogin = Console.ReadLine();

                if(emailLogin == user.Email && senhaLogin == user.Senha){
                    Logado = true;
                    Console.WriteLine("Login efetuado com sucesso!");
                }else{
                    Console.WriteLine("Falha ao realizar login tente novamente");
                }
                
            }
        }

        public void Deslogar(){
            Logado = false;
        }
    }
}