using System;

namespace Exercicio6{
    class Program{
        static void Main(String [] args){

            Aluno aluno = new Aluno();


            Console.WriteLine("Digite a nota do aluno");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());


        }
    }
}
