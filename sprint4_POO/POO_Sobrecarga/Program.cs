using System;
using Polimorfismo.Classes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionario fun = new Funcionario();
           fun.Mostrar();
           fun.Mostrar("Samuel");
           fun.Mostrar(2); 
        }
    }
}
