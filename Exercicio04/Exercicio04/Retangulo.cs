using System;
using System.Globalization;


namespace Exercicio04
{
    class Retangulo
    {


        // variavel publica para armenar a altura do retangulo
        public double Altura;

        // variavel publica para armenar a largura do retangulo
        public double Largura;

        // processamento

        // Criando metodo para calcular area
        public double Area()
        {

            return Largura * Altura;

        }
        // Criando metodo para calcular o perimetro
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        // Criando método para calcular a Diagonal
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }


    }
}

