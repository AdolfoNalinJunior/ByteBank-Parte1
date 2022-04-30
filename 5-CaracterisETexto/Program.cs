using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracterisETexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 5 - Caracteris e Textos! ");

            // Caracter 
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);
            
            /*
             * Quando se trata do char em relação a memoria
             * o chara é considerado um número, mais você não 
             * consegue definir um número diretamente, mias se voê 
             * fazer o casting, o C# vai endender
             */
            primeiraLetra = (char) 61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);

            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursos = 
 @".NET 
Java 
JAVAscript ";

            Console.WriteLine(cursos);

            Console.WriteLine("Fim da execução. Tecle ENTER para sair ");
            Console.ReadLine();

        }
    }
}
