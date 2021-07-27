using System;

namespace POO_celular.Classes
{
    public class Celular
    {
        string cor;
        string modelo;
        double tamanho;
        bool ligado;


        public void ligar(){
            
            Console.WriteLine("O celular esta ligado");
            Console.WriteLine("");
        }

        public void ligacao(){
            Console.WriteLine("Fazendo uma ligação para: ");
        }

        public void mensagem(){
            Console.WriteLine("Enviando mensagem para: ");
        }

    }
}