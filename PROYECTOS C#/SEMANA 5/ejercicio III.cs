using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        List<double> notas = new List<double>();

        foreach (string asignatura in asignaturas)
        {
            Console.Write($"Ingrese la nota de {asignatura}: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(nota);
        }

        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }
    }
}
