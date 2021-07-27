using System;

namespace Sistema_Orientado_a_Objetos.Classes

{
    public class Aluno
    {
        
        public string nome;
        public string curso;
        public int idade;
        public string rg; 
        public bool bolsista;
        public double mediaFinal;
        public double valorDaMensalidade;

        public void VerMediaFinal(double media){
            Console.WriteLine($"A media do Aluno é: {media}");
        }

        public void VerMensalidade(bool temBolsa, double mensalidade){
            if (temBolsa == true)
            {
                Console.WriteLine("Esse Aluno tem Bolsa");
                Console.WriteLine($"Mensalidade; {mensalidade}");


                Console.WriteLine($"Mensalidade com desconto: {0.7 * mensalidade}");

            }else
            {
                Console.WriteLine("Esse Aluno não tem Bolsa");
                Console.WriteLine($"Mensalidade; {mensalidade}");
            }
        }
    }
}