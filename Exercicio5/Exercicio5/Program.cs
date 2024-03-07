using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa funcionario = new Pessoa();

            Console.WriteLine("Digite seu nome:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário bruto");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

            Console.WriteLine("Digite o valor total do imposto");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + funcionario);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.NovoSalario(porcentagem);

            Console.WriteLine("Dados Atualizados: " + funcionario);



        }
    }
}
