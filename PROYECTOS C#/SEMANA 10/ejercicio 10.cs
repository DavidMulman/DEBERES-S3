using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // ==============================
        // 1. Crear conjunto de 500 ciudadanos
        // ==============================
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // ==============================
        // 2. Crear conjunto vacunados Pfizer (75)
        // ==============================
        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add($"Ciudadano {i}");
        }

        // ==============================
        // 3. Crear conjunto vacunados AstraZeneca (75)
        // ==============================
        HashSet<string> astraZeneca = new HashSet<string>();

        for (int i = 50; i < 125; i++)
        {
            astraZeneca.Add($"Ciudadano {i}");
        }

        // ==============================
        // OPERACIONES DE CONJUNTOS
        // ==============================

        // Ciudadanos con ambas dosis (intersección)
        var ambasDosis = pfizer.Intersect(astraZeneca);

        // Ciudadanos no vacunados (diferencia)
        var vacunados = pfizer.Union(astraZeneca);
        var noVacunados = ciudadanos.Except(vacunados);

        // Solo Pfizer
        var soloPfizer = pfizer.Except(astraZeneca);

        // Solo AstraZeneca
        var soloAstraZeneca = astraZeneca.Except(pfizer);

        // ==============================
        // RESULTADOS
        // ==============================

        Console.WriteLine("Ciudadanos NO vacunados: " + noVacunados.Count());
        Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count());
        Console.WriteLine("Ciudadanos solo Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Ciudadanos solo AstraZeneca: " + soloAstraZeneca.Count());

        Console.ReadLine();
    }
}