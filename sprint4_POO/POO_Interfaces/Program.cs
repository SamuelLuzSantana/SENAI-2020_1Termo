using System;
using Interface.Classes;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "Bananinha";
            p1.Preco = 2;

            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Nome = "Goiaba";
            p2.Preco = 3;


            carrinho.Cadastrar(p1);
            carrinho.Listar();

            carrinho.Cadastrar(p2);

            carrinho.Alterar(p1.Codigo, p2);
            carrinho.Listar();
            
        }
    }
}
