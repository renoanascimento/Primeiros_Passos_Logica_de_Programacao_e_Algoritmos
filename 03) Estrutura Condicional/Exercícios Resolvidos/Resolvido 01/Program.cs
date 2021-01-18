using System;
using System.Globalization;

namespace Resolvido_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, total;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + total.ToString("F1", CultureInfo.InvariantCulture));

            if (total < 60)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
