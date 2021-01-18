using System;
using System.Globalization;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, numeroPecas1, codigoPeca2, numeroPecas2;
            double valorUnitarioPeca1, valorUnitarioPeca2, valorTotalPecas;

            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(peca1[0]);
            numeroPecas1 = int.Parse(peca1[1]);
            valorUnitarioPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            codigoPeca2 = int.Parse(peca2[0]);
            numeroPecas2 = int.Parse(peca2[1]);
            valorUnitarioPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            valorTotalPecas = (numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotalPecas.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
