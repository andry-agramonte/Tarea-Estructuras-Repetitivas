
using System;

class Program
{
    static void Main()
    {
        // Solicitar un numero positivo
        Console.Write("Digite un numero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        // Validar que el numero sea positivo
        while (numero <= 0)
        {
            Console.WriteLine("El numero debe ser positivo.");
            Console.Write("Digite un numero positivo: ");
            numero = int.Parse(Console.ReadLine());
        }

        int suma = 0;

        // Mostrar la explicacion de la suma
        Console.WriteLine("\nPorque:");

        // Sumar los numeros desde 1 hasta N
        for (int i = 1; i <= numero; i++)
        {
            suma = suma + i;

            Console.Write(i);

            if (i < numero)
            {
                Console.Write(" + ");
            }
        }

        // Mostrar el resultado final
        Console.WriteLine(" = " + suma);
        Console.WriteLine("Resultado: " + suma);
    }
}
