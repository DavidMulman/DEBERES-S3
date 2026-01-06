using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese 6 números ganadores de la lotería:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }

        numeros.Sort();

        Console.WriteLine("Números ordenados:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}
