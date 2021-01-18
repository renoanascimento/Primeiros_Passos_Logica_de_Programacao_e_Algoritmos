using System;

namespace URI1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, horaTermino, duracao;
            string[] horarios;

            horarios = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(horarios[0]);
            horaTermino = int.Parse(horarios[1]);

            duracao = horaTermino - horaInicio;

            if (duracao < 0)
            {
                duracao = duracao + 24;
            }
            if (horaInicio == horaTermino)
            {
                duracao = 24;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
