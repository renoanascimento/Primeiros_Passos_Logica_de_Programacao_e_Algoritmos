using System;
using System.Globalization;

namespace AtribCumulativa
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos, conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50;

            if (minutos > 100)
            {
                conta += (minutos - 100) * 2;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
