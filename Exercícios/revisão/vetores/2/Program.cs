using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');

        int[] numeros = new int[n];
        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(valores[i]);
        }

        var pares = numeros.Where(x => x % 2 == 0).ToArray();
        Console.WriteLine(string.Join(" ", pares));
        Console.WriteLine(pares.Length);
    }
}
