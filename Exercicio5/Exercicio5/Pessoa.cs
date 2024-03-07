using System;
using System.Globalization;


namespace Exercicio5
{
    class Pessoa
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;
    
      
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void NovoSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto *  (porcentagem / 100));
        }

        public override String ToString()
        {
            return Nome 
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
                    
        }
    }
}
