using System;
using System.Globalization;

namespace Resolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double soma = 0, media = 0;
            double[] vetor = null;
            string[] valores = null;

            n = int.Parse(Console.ReadLine());
            vetor = new double[n];
            valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
                soma = soma + vetor[i];
            }

            media = soma / n;

            for (int j = 0; j < n; j++)
            {
                Console.Write(vetor[j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
