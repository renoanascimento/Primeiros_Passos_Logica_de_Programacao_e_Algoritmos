using System;
using System.Globalization;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] notasPrimeiroSemestre = new double[n];
            double[] notasSegundoSemestre = new double[n];
            double[] mediaFinal = new double[n];
            string[] entradas = new string[2];

            for (int i = 0; i < n; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                nomes[i] = entradas[0];
                notasPrimeiroSemestre[i] = double.Parse(entradas[1], CultureInfo.InvariantCulture);
                notasSegundoSemestre[i] = double.Parse(entradas[2], CultureInfo.InvariantCulture);
                mediaFinal[i] = (notasPrimeiroSemestre[i] + notasSegundoSemestre[i]) / 2.0;
            }

            Console.WriteLine("Alunos aprovados:");

            for (int j = 0; j < n; j++)
            {
                if (mediaFinal[j] >= 6.0)
                {
                    Console.WriteLine(nomes[j]);
                }
            }
        }
    }
}
