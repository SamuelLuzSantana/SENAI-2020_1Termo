using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario Cadastradopor = new Usuario();
        
        public List<Produto> ListaDeProdutos = new List<Produto>();
        
        public void Cadastrar(){

            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço do produto: ");
            novoProduto.preco = int.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            novoProduto.Marca = Marca.Cadastrar();

            novoProduto.Cadastradopor = new Usuario();

            ListaDeProdutos.Add(novoProduto);

        }

        public void Listar(){
            
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
               
            }

            Console.ResetColor();
        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(m => m.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
        
        
        
        
        
    }
}