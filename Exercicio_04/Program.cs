using System;

//Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
//calcule a tabuada de N.
//• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
//10N.


namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número de 1 a 10: ");
            int numero = int.Parse(Console.ReadLine());


            while (numero != 1 && numero != 2 && numero != 3 && numero != 4 && numero != 5 && numero != 6 && numero != 7 && numero != 8 && numero != 9 && numero != 10)
            { 
                Console.WriteLine("Número inválido. Escreva um número de 1 a 10: ");
                numero = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i <= 10; i++)
            {
                int multiplicacao = numero * i;
                Console.WriteLine(numero + " * " + i + " = " + multiplicacao);
            }

        }
    }
}
