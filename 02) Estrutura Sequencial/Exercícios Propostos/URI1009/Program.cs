using System;
using System.Globalization;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, vendasEfetuadas, salarioFinal;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFinal = salarioFixo + (vendasEfetuadas * 0.15);

            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
