using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTipoNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // Casting 

            Console.WriteLine(salarioEmInteiro);

            int idade;
            idade = 2000000000;
            Console.WriteLine(idade);

            short quantidadeProduto;
            quantidadeProduto = 15000;
            Console.WriteLine(quantidadeProduto);

            float altura = 1.80f; 
            Console.WriteLine (altura);

            /*
             * Para que fique claro para a linguagem que esta sendo tradado de um tipo float, é necessario que você esclareça para a IDE com um F após o valor
             */
            
            /* float = 8 bts 
             * short = 16 bts
             * int = 32 bts
             * long = 64 bts
            */
           
        }       
    }
}
