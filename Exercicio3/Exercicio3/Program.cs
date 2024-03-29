﻿using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(String[] args)
        {


            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());


            Console.WriteLine();
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque:");
            qte = int.Parse(Console.ReadLine());

            Console.WriteLine();
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);            
            Console.ReadLine();



        }
    }
}

