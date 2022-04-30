using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            int quantidadePessoas = 3;
            bool acompanhado;

            if (quantidadePessoas >= 18)  
            {
                 acompanhado = true;
            }
            else
            {
                 acompanhado =false;
            }
            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
        }
    }
}
