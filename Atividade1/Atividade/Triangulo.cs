using System;

namespace Atividade

{
    class Triangulo
    {

        // Criando atributo, primeira letra maiscula
        public double A;
        public double B;
        public double C;


        // Criando metodos
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
