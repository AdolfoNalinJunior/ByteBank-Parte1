
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execusão do projeto 6 Atribuições de variáveis");

            int idade = 32;
            int idadeGustavo = idade;
            /*
             * Quando você realiza isso, você pede para o C# para fazer uma copia
             * dos valores do tipo principal
             */

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.WriteLine("Fim da execusão");
            Console.ReadLine();
        }
    }
}
