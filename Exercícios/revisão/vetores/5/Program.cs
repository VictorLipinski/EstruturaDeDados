using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        int somaPares = 0;
        int countPares = 0;

        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
                countPares++;
            }
        }

        if (countPares > 0)
        {
            double media = (double)somaPares / countPares;
            Console.WriteLine(media.ToString("F1"));
        }
        else
        {
            Console.WriteLine("0.0");
        }
    }
}
