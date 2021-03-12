using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Digite uma mensagem:");
            String mensagem = Console.ReadLine();
            mensagem = mensagem.Replace("a","4")
                               .Replace("A","4")
                               .Replace("e","3")
                               .Replace("E","3")
                               .Replace("i","1")
                               .Replace("I","1")
                               .Replace("l","1")
                               .Replace("L","1")
                               .Replace("o","0")
                               .Replace("O","0")
                               .Replace("t","7")
                               .Replace("T","7")
                               .Replace("s","5")
                               .Replace("S","5");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{mensagem}");
            Console.ResetColor();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Escolha uma tecla e clique nela para limpar sua tela");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
