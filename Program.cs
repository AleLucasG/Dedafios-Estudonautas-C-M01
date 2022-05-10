using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Exe001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1° DESAFIO DO CURSO DE CSHARP, USANDO:
             * TEMPORIZADOR,
             * POSIÇÕES ESPECIFICAS,
             * COR DE LETRA E FUNDO DE TELA.
             */

            Console.SetCursorPosition(10, 5);

            // PRIMEIRA PARTE
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("MEU ");
            Console.ResetColor();

            // SEGUNDA PARTE
            Console.ForegroundColor= ConsoleColor.Green;
            Console.BackgroundColor= ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.Write("BRASIL ");
            Console.ResetColor();

            // TERCEIRA PARTE
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor= ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.Write("BRASILEIRO");
            Thread.Sleep(1000);

            Console.ReadKey();
        }
    }
}
