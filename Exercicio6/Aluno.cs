using System;


namespace Exercicio6
{
    class Aluno
    {

        public String Nome;
        public double nota1;
        public double nota2;
        public double nota3;
        public double notaFinal;


        public double TotalNotas()
        {

            notaFinal = nota1 + nota2 + nota3;
        }


    }
}