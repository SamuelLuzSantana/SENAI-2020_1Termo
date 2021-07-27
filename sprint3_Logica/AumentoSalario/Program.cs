using System;

namespace Algortimo_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo Aumento de salario


            Console.WriteLine("Bem Vindo :)");
            Console.WriteLine("Esse algoritmo atravez do seu salario determina se voce receberá aumento ou não");
            Console.WriteLine("Primeiro, Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            if(salario>500){
                Console.WriteLine("Você não tem direito ao aumento de salario :c");
            }else{
                double aumento = (salario*0.3);
                double liquido = (salario+aumento);

                Console.WriteLine("Parabens, o seu salario com o aumento de 30% foi de: R$:"+salario+", para: R$:"+liquido);
            }


        }
    }
}
