
using System;

class Program
{
    static void Main()
    {
        int pares = 0;
        int impares = 0;

        // Solicitar diez numeros enteros
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Numero " + i + ": ");
            int numero = int.Parse(Console.ReadLine());

            // Comprobar si el numero es par o impar
            if (numero % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        // Mostrar los resultados finales
        Console.WriteLine("\nCantidad de pares: " + pares);
        Console.WriteLine("Cantidad de impares: " + impares);
    }
}
