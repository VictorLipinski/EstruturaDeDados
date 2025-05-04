using System;
using System.Collections.Generic;

class Paciente
{
    public string Nome { get; set; }
    public double PressaoArterial { get; set; }
    public double Temperatura { get; set; }
    public double Oxigenacao { get; set; }
    public string Prioridade { get; set; }

    public Paciente(string nome, double pressaoArterial, double temperatura, double oxigenacao)
    {
        Nome = nome;
        PressaoArterial = pressaoArterial;
        Temperatura = temperatura;
        Oxigenacao = oxigenacao;
        Prioridade = ClassificarPrioridade();
    }

    private string ClassificarPrioridade()
    {
        if (PressaoArterial > 18 || Temperatura > 39 || Oxigenacao < 90)
            return "Vermelha"; 
        if (PressaoArterial > 14 || Temperatura > 37.5 || Oxigenacao < 95)
            return "Amarela"; 
        return "Verde"; 
    }
}

class FilaDeTriagem
{
    private Queue<Paciente> fila = new Queue<Paciente>();

    public void AdicionarPaciente(Paciente paciente)
    {
        fila.Enqueue(paciente);
    }

    public Paciente AtenderPaciente()
    {
        return fila.Dequeue();
    }

    public bool EstaVazia()
    {
        return fila.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var filaTriagem = new FilaDeTriagem();
        var historicoAtendimentos = new Stack<Paciente>();

        Console.WriteLine("Quantos pacientes irão ser cadastrados?");
        int quantidadePacientes = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadePacientes; i++)
        {
            Console.WriteLine($"\nCadastro do Paciente #{i + 1}:");

            Console.Write("Nome do paciente: ");
            string nome = Console.ReadLine();

            Console.Write("Pressão Arterial: ");
            double pressaoArterial = double.Parse(Console.ReadLine());

            Console.Write("Temperatura: ");
            double temperatura = double.Parse(Console.ReadLine());

            Console.Write("Oxigenação: ");
            double oxigenacao = double.Parse(Console.ReadLine());

            Paciente paciente = new Paciente(nome, pressaoArterial, temperatura, oxigenacao);
            filaTriagem.AdicionarPaciente(paciente);
        }

        while (!filaTriagem.EstaVazia())
        {
            var paciente = filaTriagem.AtenderPaciente();
            Console.WriteLine($"\nAtendendo paciente: {paciente.Nome} - Prioridade: {paciente.Prioridade}");

            historicoAtendimentos.Push(paciente);
        }


        Console.WriteLine("\nHistórico de atendimentos:");
        while (historicoAtendimentos.Count > 0)
        {
            var paciente = historicoAtendimentos.Pop();
            Console.WriteLine($"{paciente.Nome} - {paciente.Prioridade}");
        }
    }
}
