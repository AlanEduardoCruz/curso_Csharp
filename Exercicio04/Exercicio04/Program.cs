using System;
using System.Globalization;
using System.Xml;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto a partir da classe Retangulo
            Retangulo ret = new Retangulo();

            // entrada de dados

            // Solicitando dados ao usúario 
            Console.WriteLine("Entre com a largura e altura do triangulo");

            Console.WriteLine("Largura:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Altura:");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // saida de dados

            // Imprime a área do retângulo
            Console.WriteLine("AREA " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));

            // Imprime o perimetro do retângulo            
            Console.WriteLine("PERIMETRO " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            // Imprime a diagonal do retângulo
            Console.WriteLine("DIAGONAL " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
