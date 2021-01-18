using System;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, maior;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            valor1 = int.Parse(vetor[0]);
            valor2 = int.Parse(vetor[1]);
            valor3 = int.Parse(vetor[2]);

            maior = ((valor1 + valor2 + Math.Abs(valor1 - valor2)) / 2);
            maior = ((maior + valor3 + Math.Abs(maior - valor3)) / 2);

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
