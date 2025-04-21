using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[,] pelotao = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                pelotao[i, j] = int.Parse(linha[j]);
            }
        }

        int fila = int.Parse(Console.ReadLine()) - 1;

        int ultimo = pelotao[fila, n - 1];
        for (int j = n - 1; j > 0; j--)
        {
            pelotao[fila, j] = pelotao[fila, j - 1];
        }
        pelotao[fila, 0] = ultimo;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(pelotao[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
