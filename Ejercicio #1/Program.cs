
using System;

class Program
{
    static void Main()
    {
        // Solicitar un número al usuario
        Console.Write("Digite un numero: ");
        int numero = int.Parse(Console.ReadLine());

        // Mostrar el titulo de la tabla
        Console.WriteLine("\nTabla del " + numero);

        // Ciclo para multiplicar desde 1 hasta 12
        for (int i = 1; i <= 12; i++)
        {
            int resultado = numero * i;

            // Mostrar cada multiplicacion
            Console.WriteLine(numero + " x " + i + " = " + resultado);
        }
    }
}
