using System;

namespace MyApp
{
    internal class ExercicioFixacao5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Três numero em Sequência");
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine($"Menor = {n1}");
            }
            else if (n2 < n3)
            {
                Console.WriteLine($"Menor = {n2}");
            }
            else
            {
                Console.WriteLine($"Menor = {n3}");
            }
        }
    }
}