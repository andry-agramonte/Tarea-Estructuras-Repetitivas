
using System;

class Program
{
    static void Main()
    {
        int aprobados = 0;
        int reprobados = 0;

        // Solicitar la cantidad de estudiantes
        Console.Write("Cantidad de estudiantes: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Validar que la cantidad sea mayor que cero
        while (cantidad <= 0)
        {
            Console.WriteLine("Debe ingresar una cantidad mayor que cero.");
            Console.Write("Cantidad de estudiantes: ");
            cantidad = int.Parse(Console.ReadLine());
        }

        // Solicitar la calificacion de cada estudiante
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Nota " + i + ": ");
            double nota = double.Parse(Console.ReadLine());

            // Validar que la nota este entre 0 y 100
            while (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota invalida. Debe estar entre 0 y 100.");
                Console.Write("Nota " + i + ": ");
                nota = double.Parse(Console.ReadLine());
            }

            // Determinar si el estudiante aprobo o reprobo
            if (nota >= 70)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        // Calcular el porcentaje de aprobados
        double porcentaje = (double)aprobados / cantidad * 100;

        // Mostrar los resultados finales
        Console.WriteLine("\nTotal de estudiantes: " + cantidad);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
        Console.WriteLine("Porcentaje de aprobados: " + porcentaje + "%");
    }
}
