using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] valoresA = Console.ReadLine().Split(' ');
        string[] valoresB = Console.ReadLine().Split(' ');

        int[] A = new int[n];
        int[] B = new int[n];
        int[] C = new int[n];

        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(valoresA[i]);
            B[i] = int.Parse(valoresB[i]);
            C[i] = A[i] + B[i];
        }

        Console.WriteLine(string.Join(" ", C));
    }
}
