using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOOConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixaRetangular = new CaixaRetangular();

            caixaRetangular.altura = 5;
            caixaRetangular.largura = 10;
            caixaRetangular.comprimento = 15;

            Console.WriteLine($"O volume da caixa retangular é: " + caixaRetangular.CalcularVolume());
            Console.ReadLine();
        }
    }
}
