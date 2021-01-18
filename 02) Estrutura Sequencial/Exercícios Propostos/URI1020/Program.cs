using System;

namespace URI1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDias, ano, restoAno, mes, dia;

            quantidadeDias = int.Parse(Console.ReadLine());

            ano = quantidadeDias / 365;
            restoAno = quantidadeDias % 365;
            mes = restoAno / 30;
            dia = restoAno % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
