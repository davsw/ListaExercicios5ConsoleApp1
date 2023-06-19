using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_5ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            esfera.raio = 10;

            Console.WriteLine("O volume da esfera é: {0}", esfera.CalcularVolume());
            Console.ReadLine();
        }
    }
}
