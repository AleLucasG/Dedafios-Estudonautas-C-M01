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

            Console.SetCursorPosition(10,5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("MEU ");
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Green;
            Console.BackgroundColor= ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.Write("BRASIL ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor= ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.Write("BRASILEIRO");
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
