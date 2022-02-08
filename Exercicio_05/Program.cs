using System;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= valor; i++)
            {
                fat = fat * i;

            }

            Console.WriteLine("Fatorial de "+valor+": "+fat);

        }
    }
}
