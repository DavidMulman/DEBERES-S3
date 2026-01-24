using System;
using System.Collections.Generic;

class TorresHanoi
{
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                            string nomOrigen, string nomDestino, string nomAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nomOrigen} a {nomDestino}");
            return;
        }

        MoverDiscos(n - 1, origen, auxiliar, destino, nomOrigen, nomAuxiliar, nomDestino);

        int d = origen.Pop();
        destino.Push(d);
        Console.WriteLine($"Mover disco {d} de {nomOrigen} a {nomDestino}");

        MoverDiscos(n - 1, auxiliar, destino, origen, nomAuxiliar, nomDestino, nomOrigen);
    }

    static void Main()
    {
        int n = 3; // número de discos

        Stack<int> A = new Stack<int>();
        Stack<int> B = new Stack<int>();
        Stack<int> C = new Stack<int>();

        for (int i = n; i >= 1; i--)
            A.Push(i);

        MoverDiscos(n, A, C, B, "A", "C", "B");
    }
}
