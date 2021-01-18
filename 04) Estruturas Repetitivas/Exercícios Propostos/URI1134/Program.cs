using System;

namespace URI1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int combustivel, contAlcool, contGasolina, contDiesel;
            contAlcool = 0;
            contGasolina = 0;
            contDiesel = 0;

            combustivel = int.Parse(Console.ReadLine());

            while (combustivel != 4)
            {
                if (combustivel == 1)
                {
                    contAlcool++;
                }
                else if (combustivel == 2)
                {
                    contGasolina++;
                }
                else if (combustivel == 3)
                {
                    contDiesel++;
                }

                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contAlcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Diesel: " + contDiesel);
        }
    }
}
