using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 1;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Você pode entrar, você tem 18 anos e está acompanhado");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
       }
    }
}