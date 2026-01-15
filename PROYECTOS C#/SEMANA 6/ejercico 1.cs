using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public void Insertar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    public void EliminarFueraDeRango(int min, int max)
    {
        // Eliminar nodos al inicio
        while (cabeza != null && (cabeza.Dato < min || cabeza.Dato > max))
            cabeza = cabeza.Siguiente;

        Nodo actual = cabeza;

        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato < min || actual.Siguiente.Dato > max)
                actual.Siguiente = actual.Siguiente.Siguiente;
            else
                actual = actual.Siguiente;
        }
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random rnd = new Random();

        for (int i = 0; i < 50; i++)
            lista.Insertar(rnd.Next(1, 1000));

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        Console.Write("Ingrese valor mínimo: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese valor máximo: ");
        int max = int.Parse(Console.ReadLine());

        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine("Lista filtrada:");
        lista.Mostrar();
    }
}
