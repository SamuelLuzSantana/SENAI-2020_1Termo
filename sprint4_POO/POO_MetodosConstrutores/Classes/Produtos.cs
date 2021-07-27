using System;
namespace Metodos_Construtores.Classes
{
    public class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        
        public Produtos(int codigo, string nome, string descricao, int estoque){

            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;

            Console.WriteLine($"Produto Cadastrado {nome} Codigo -  {Codigo}");



        }//fim construtor

        public Produtos(int codigo){
            if (codigo >=0)
            {
                Codigo = codigo;
                Console.WriteLine($"Produto cadastrado | Codigo - {Codigo} - Nome {Nome ?? "Sem Nome"}");
            }
        }


        
        
                
        
        
        
    }
}