using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_4ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Percurso percurso = new Percurso();

            percurso.kilometragemInicial = 10;
            percurso.kilometragemFinal = 25;
            percurso.consumo = 10;

            Console.WriteLine("O consumo de combustível por Km no percurso é: {0}", percurso.CalcularGasto());
            Console.ReadLine();

        }
    }
}
