using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double maiorAltura = double.MinValue;
        double menorAltura = double.MaxValue;
        double somaAlturasMulheres = 0;
        int numeroMulheres = 0;
        int numeroHomens = 0;

        for (int i = 0; i < n; i++)
        {
            string[] dados = Console.ReadLine().Split(' ');
            double altura = double.Parse(dados[0]);
            char sexo = char.Parse(dados[1]);

            if (altura > maiorAltura)
            {
                maiorAltura = altura;
            }

            if (altura < menorAltura)
            {
                menorAltura = altura;
            }

            if (sexo == 'F' || sexo == 'f')
            {
                somaAlturasMulheres += altura;
                numeroMulheres++;
            }
            else if (sexo == 'M' || sexo == 'm')
            {
                numeroHomens++;
            }
        }

        double mediaAlturasMulheres = (numeroMulheres > 0) ? somaAlturasMulheres / numeroMulheres : 0;

        Console.WriteLine($"Menor altura = {menorAltura:F2}");
        Console.WriteLine($"Maior altura = {maiorAltura:F2}");
        Console.WriteLine($"Media das alturas das mulheres = {mediaAlturasMulheres:F2}");
        Console.WriteLine($"Numero de homens = {numeroHomens}");
    }
}
