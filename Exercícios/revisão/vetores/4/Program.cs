using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');

        double[] numeros = new double[n];
        double soma = 0;

        for (int i = 0; i < n; i++)
        {
            numeros[i] = double.Parse(valores[i]);
            soma += numeros[i];
        }

        double media = soma / n;
        Console.WriteLine(media.ToString("F3"));

        foreach (var numero in numeros)
        {
            if (numero < media)
            {
                Console.Write(numero + " ");
            }
        }
    }
}
