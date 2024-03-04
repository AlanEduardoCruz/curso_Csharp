using exercicio1; // Importa o namespace "exercicio1". (não necessário para este exercício)
using System;

namespace Execicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa(); // Cria uma instância da classe Pessoa para a primeira pessoa.
            Pessoa pessoa2 = new Pessoa(); // Cria uma instância da classe Pessoa para a segunda pessoa.
            Pessoa pessoa3 = new Pessoa();
            // Solicita e armazena o nome da primeira pessoa.
            Console.WriteLine("Informe o  nome da primeira pessoa:");
            pessoa1.Nome = Console.ReadLine();

            // Solicita e armazena a idade da primeira pessoa.
            Console.WriteLine("Informe a sua idade da primeira pessoa:");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            // Solicita e armazena o nome da segunda pessoa.
            Console.WriteLine("Informe o  nome da segunda pessoa:");
            pessoa2.Nome = Console.ReadLine();

            // Solicita e armazena a idade da segunda pessoa.
            Console.WriteLine("Informe a idade da segunda pessoa:");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            // Compara as idades das duas pessoas e imprime o resultado.
            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha:  {pessoa1.Nome}"); // Imprime o nome da pessoa mais velha.
                Console.WriteLine($"Idade:  {pessoa1.Idade}"); // Imprime a idade da pessoa mais velha.             

            }
            else if (pessoa1.Idade < pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha:  {pessoa2.Nome}"); // Imprime o nome da pessoa mais velha.
                Console.WriteLine($"Idade:  {pessoa2.Idade}"); // Imprime a idade da pessoa mais velha.

            }
            else
            {
                Console.WriteLine($"As duas pessoas têm a mesma idade."); // Imprime se as duas pessoas têm a mesma idade.
            }
        }
    }
}
