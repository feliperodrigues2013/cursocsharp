using System;
using tabuleiro;
namespace Xadrez_Console
{
    /*Felipe R.*/
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
