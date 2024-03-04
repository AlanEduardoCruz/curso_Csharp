using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando atributo
           Funcionario f1 = new Funcionario();
           Funcionario f2 = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionário:\n");

            Console.WriteLine("Informe o nome primeiro funcionário:");
            f1.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salario do primeiro funcionário");
            f1.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados do primeiro funcionário:\n");

            Console.WriteLine("Informe o nome do segundo funcionário:");
            f2.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salario segundo funcionário:");
            f2.Salario= float.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {media.ToString("F2",CultureInfo.InvariantCulture)}");


        }
    }
}