using System;
using System.Globalization;

namespace Course
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
           

            Console.WriteLine("Entre o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cir = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + cir.ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine("Valor de PI " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}
