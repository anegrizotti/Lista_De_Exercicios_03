using System;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somador = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0)
                {
                    if (i % 3 == 0)
                    {
                        somador = somador + i;
                    }
                }
            }

            Console.WriteLine("A soma de todos os números ímpares e multiplos de 3 entre 1 e 500 é: "+somador);
        }
    }
}
