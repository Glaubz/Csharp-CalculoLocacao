using System;
using Aula195_Ex.Entities;
using System.Globalization;

namespace Aula195_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("- Entre com os dados da locação:");
            System.Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            System.Console.Write("Data da locação (dd/mm/aaaa hh:mm): ");
            DateTime dataAluguel = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Data da devolução (dd/mm/aaaa hh:mm): ");
            DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Insira o valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Insira o valor por dia: ");
            double valorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Locacao aluguel = new Locacao(modelo, dataAluguel, dataDevolucao, valorHora, valorDia);

            System.Console.WriteLine("\n"+aluguel);

        }
    }
}
