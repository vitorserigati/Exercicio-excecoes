using System;

namespace Exercicio_excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                int a = int.Parse(Console.ReadLine());
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }
}
