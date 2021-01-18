using System;
using System.Globalization;

namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, numeroHorasTrabalhadas;
            double valorHoraTrabalhada, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            numeroHorasTrabalhadas = int.Parse(Console.ReadLine());
            valorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = numeroHorasTrabalhadas * valorHoraTrabalhada;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
