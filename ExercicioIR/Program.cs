using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 2801.0;

            if (salario >= 1900 && salario <= 2800)
            {
                Console.WriteLine("O valor do imposto que você vai ter que pagar é 142 reais ");
            } else if (salario > 2800.0 && salario <= 3751.0)
            {
                Console.WriteLine("O valor do imposto que você vai ter que pagar é 350 reais "); 
            } else if(salario > 3751.0 && salario <= 4664.0)
            {
                Console.WriteLine("O valor do imposto que você vai ter que pagar é 636 reais ");
            }
        }
    }
}
