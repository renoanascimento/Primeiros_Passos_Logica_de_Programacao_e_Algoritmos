using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, horasTotais, minutosTotais;
            string[] tempoDeJogo;

            tempoDeJogo = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(tempoDeJogo[0]);
            minutoInicial = int.Parse(tempoDeJogo[1]);
            horaFinal = int.Parse(tempoDeJogo[2]);
            minutoFinal = int.Parse(tempoDeJogo[3]);

            horasTotais = horaFinal - horaInicial;
            if (horasTotais < 0)
            {
                horasTotais = horasTotais + 24;
            }
            if (horaFinal == horaInicial)
            {
                horasTotais = 24;
            }

            minutosTotais = minutoFinal - minutoInicial;
            if (minutosTotais < 0)
            {
                horasTotais--;
                minutosTotais = minutosTotais + 60;
            }

            if (horasTotais == 24 && minutosTotais > 0)
            {
                horasTotais = 0;
            }

            Console.WriteLine("O JOGO DUROU " + horasTotais + " HORA(S) E " + minutosTotais + " MINUTO(S)");
        }
    }
}
