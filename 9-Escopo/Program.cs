using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo ");

            int idade = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João esta acoampanhado ";
            }
            else
            {
                mensagemAdicional = "João não pode entrar ";
            }
            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Você está liberado, pode entrar! ");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Você não pode entrar, pois você não está acompanhado e não tem 18 anos");
            }
        }
    }
}
