using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o porjeto 7-Condionais");


            int idade = 10;
            int quantidadePesosas = 1;

            if (idade >= 18)
            {
                Console.WriteLine("Você tema mais de 18 anos ");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                if (quantidadePesosas >= 2)
                {
                    Console.WriteLine("Você não tem 18 anos, mais pode entrar, pois está acompanhado ");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar ");
                }
            }
        }
    }
}
