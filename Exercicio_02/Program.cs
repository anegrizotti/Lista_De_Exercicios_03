using System;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <=200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("O número "+i+" é ímpar e está entre 100 e 200.");
                }
            }
        }
    }
}
