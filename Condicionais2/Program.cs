using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - condicionais 2 ");

            int idade = 18;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2; 

            bool acompanhado = true;

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Você está liberado, pode entrar! ");
            }
            else
            {
                Console.WriteLine("Você não pode entrar, pois você não está acompanhado e não tem 18 anos");
            }
        }
    }
}
