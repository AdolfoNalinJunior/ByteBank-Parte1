using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorDeMes = 11;
            double valorInvestido = 1000.0;

            while (contadorDeMes >= 1 && contadorDeMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * (0.36 / 100);
                Console.WriteLine("Após " + contadorDeMes + " mes, você tera R$" + valorInvestido);
                 contadorDeMes += 1;   
            }
        }
    }
}
