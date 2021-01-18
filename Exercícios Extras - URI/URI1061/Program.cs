using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, horaInicio, minutoInicio, segundoInicio, diaTermino, horaTermino, minutoTermino, segundoTermino, dias, horas, minutos, segundos;
            string[] diaAbertura, horarioAbertura, diaEncerramento, horarioEncerramento;

            diaAbertura = Console.ReadLine().Split(' ');
            diaInicio = int.Parse(diaAbertura[1]);
            horarioAbertura = Console.ReadLine().Split(':');
            diaEncerramento = Console.ReadLine().Split(' ');
            diaTermino = int.Parse(diaEncerramento[1]);
            horarioEncerramento = Console.ReadLine().Split(':');

            horaInicio = int.Parse(horarioAbertura[0]);
            minutoInicio = int.Parse(horarioAbertura[1]);
            segundoInicio = int.Parse(horarioAbertura[2]);

            horaTermino = int.Parse(horarioEncerramento[0]);
            minutoTermino = int.Parse(horarioEncerramento[1]);
            segundoTermino = int.Parse(horarioEncerramento[2]);

            dias = diaTermino - diaInicio;

            horas = horaTermino - horaInicio;
            if (horas < 0)
            {
                dias--;
                horas = horas + 24;
            }

            minutos = minutoTermino - minutoInicio;
            if (minutos < 0)
            {
                horas--;
                minutos = minutos + 60;
            }

            segundos = segundoTermino - segundoInicio;
            if (segundos < 0)
            {
                minutos--;
                segundos = segundos + 60;
            }

            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");
        }
    }
}
