
using System;

class Program
{
    static void Main()
    {
        double balance = 0;

        // Solicitar la cantidad de depositos
        Console.Write("¿Cuantos depositos realizara?: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Validar que la cantidad sea mayor que cero
        while (cantidad <= 0)
        {
            Console.WriteLine("Debe realizar al menos un deposito.");
            Console.Write("¿Cuantos depositos realizara?: ");
            cantidad = int.Parse(Console.ReadLine());
        }

        // Solicitar el monto de cada deposito
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Deposito " + i + ": RD$");
            double deposito = double.Parse(Console.ReadLine());

            // Validar que el deposito sea mayor que cero
            while (deposito <= 0)
            {
                Console.WriteLine("El deposito debe ser mayor que cero.");
                Console.Write("Deposito " + i + ": RD$");
                deposito = double.Parse(Console.ReadLine());
            }

            // Acumular el dinero depositado
            balance = balance + deposito;
        }

        // Mostrar el balance final
        Console.WriteLine("\nBalance acumulado: RD$" + balance);
    }
}
