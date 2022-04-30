using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11__CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 Calcula Poupança 2 ");

            double valoreInvestimento = 1000.0;

            for (int quantidadeMes = 1; quantidadeMes <= 12; quantidadeMes++)
            {
                // valorInvestimento = valorInvestimento + valorInvestimento * (0.36 / 100);
                // valorInvestimento = valorInvestimento * 1.0036;
                // valorInvestimento *= 1.0036;
                valoreInvestimento += valoreInvestimento * (0.36 / 100);
                Console.WriteLine("O valor que você tera dentro de " + quantidadeMes + " é R$ " + valoreInvestimento);
            }
        }
    }
}
