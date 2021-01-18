using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, novoSalario, valorReajuste, percentualReajuste;

            salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salarioAtual > 0.00 && salarioAtual <= 400.00)
            {
                percentualReajuste = 15.00;
                valorReajuste = salarioAtual * percentualReajuste / 100.00;
                novoSalario = salarioAtual + valorReajuste;
            }
            else if (salarioAtual > 400.00 && salarioAtual <= 800.00)
            {
                percentualReajuste = 12.00;
                valorReajuste = salarioAtual * percentualReajuste / 100.00;
                novoSalario = salarioAtual + valorReajuste;
            }
            else if (salarioAtual > 800.00 && salarioAtual <= 1200.00)
            {
                percentualReajuste = 10.00;
                valorReajuste = salarioAtual * percentualReajuste / 100.00;
                novoSalario = salarioAtual + valorReajuste;
            }
            else if (salarioAtual > 1200.00 && salarioAtual <= 2000.00)
            {
                percentualReajuste = 7.00;
                valorReajuste = salarioAtual * percentualReajuste / 100.00;
                novoSalario = salarioAtual + valorReajuste;
            }
            else
            {
                percentualReajuste = 4.00;
                valorReajuste = salarioAtual * percentualReajuste / 100.00;
                novoSalario = salarioAtual + valorReajuste;
            }

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentualReajuste + " %");
        }
    }
}
