using System;
using System.Globalization;

namespace URI1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, totalImposto;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalImposto = 0.0;

            if (valor <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                if (valor <= 3000.00)
                {
                    totalImposto = (valor - 2000.00) * 0.08;
                }
                else if (valor <= 4500.00)
                {
                    totalImposto = totalImposto + (1000.00 * 0.08) + ((valor - 3000.00) * 0.18);
                }
                else
                {
                    totalImposto = totalImposto + (1000.00 * 0.08) + (1500.00 * 0.18) + ((valor - 4500.00) * 0.28);
                }
                Console.WriteLine("R$ " + totalImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
