using System;


namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan mega = new MegaMan();
            Zero zero = new Zero();

            Console.Write("O mega man está "); 
            mega.Correr();

            Console.WriteLine("");

            Console.Write("O zero está "); 
            zero.Correr();

        }
    }
}
