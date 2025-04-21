using System;

class Program
{
    static void Main()
    {
        string[] dimensoes = Console.ReadLine().Split(' ');
        int m = int.Parse(dimensoes[0]);
        int n = int.Parse(dimensoes[1]);

        int[,] matriz = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(linha[j]);
            }
        }

        Console.WriteLine("VALORES NEGATIVOS:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] < 0)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}
