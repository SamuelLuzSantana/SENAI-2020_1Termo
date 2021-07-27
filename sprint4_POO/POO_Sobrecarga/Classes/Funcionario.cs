using System;

namespace Polimorfismo.Classes
{
    public class Funcionario
    {
        
        public string [] lista = {"Samuel","Lucas","neospoli", "Chris"};

        public void Mostrar(){

            foreach (var item in lista)
            {
                Console.WriteLine(item);    

            }
        }

        public void Mostrar(int indice){

            Console.WriteLine(lista[indice]);                

        }

        public void Mostrar (string busca){

             foreach (var item in lista)
            {
               if (item==busca)
               {
                    Console.WriteLine("Resultado da busca: " + item);    

               }
            }

        }




    }
}