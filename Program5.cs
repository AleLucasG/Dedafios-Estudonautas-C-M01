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
            
            try // Como mostrar mensagem de erro?
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
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("VOCÊ DIGITOU O ANO DE NASCIMENTO ERRADO.");
                Console.WriteLine("TENTE NOVAMENTE. \nDIGITE O ANO DE NASCIMENTO COM 4 DIGITOS.");
                
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
