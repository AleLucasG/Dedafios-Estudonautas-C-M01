using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primeira parte: Convertendo a entrada de dados
            float num;
            Console.Write("Digite um número Real: ");
            float.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("----------------------------------");

            // Segunda parte: Entrada de dados com 3 casas decimais
            Console.WriteLine($"Você digitou o valor {num:C3}");

            // Terceira parte: Conversão Explicita usando Cast
            int num1 = (int)num;
            Console.WriteLine($"A parte inteira do número é {num1}");

            // Quarta parte: Conversão Classe Auxiliar
            int num2 = Convert.ToInt16(num);
            Console.WriteLine("Arredondando temos o numero " + num2);
          
            Console.ReadLine();

        }
    }
}
