
using System;

class Program
{
    static void Main()
    {
        double suma = 0;

        // Solicitar las cinco calificaciones
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Nota " + i + ": ");
            double nota = double.Parse(Console.ReadLine());

            // Validar que la nota este entre 0 y 100
            while (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota invalida. Introduzca una nota entre 0 y 100.");
                Console.Write("Nota " + i + ": ");
                nota = double.Parse(Console.ReadLine());
            }

            // Acumular las calificaciones
            suma = suma + nota;
        }

        // Calcular el promedio
        double promedio = suma / 5;

        // Mostrar los resultados
        Console.WriteLine("\nTotal de puntos: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }
}
