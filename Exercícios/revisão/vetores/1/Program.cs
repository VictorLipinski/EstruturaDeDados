using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');

        double[] numeros = new double[n];

        for (int i = 0; i < n; i++)
        {
            numeros[i] = double.Parse(valores[i]);
        }

        double maior = numeros[0];
        int posicaoMaior = 0;

        for (int i = 1; i < n; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
                posicaoMaior = i;
            }
        }

        Console.WriteLine(maior.ToString("F1"));
        Console.WriteLine(posicaoMaior);
    }
}
