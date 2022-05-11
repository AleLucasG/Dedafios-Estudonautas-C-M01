using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe005
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                    Console.Write("Em que ano você nasceu: ");
                    int anoNasc = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("------------------------------");

                    int anoAtual = DateTime.Now.Year;
                    Console.WriteLine($"Estamos atualmente no ano de {anoAtual}.");

                    int idade = anoAtual - anoNasc;
                    Console.WriteLine($"Se você nasceu em {anoNasc}, em {anoAtual} vai ter {idade} anos.");

                    Console.ReadKey();
                 
        }
    }
}
