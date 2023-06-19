using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_3ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            cilindro.altura = 10;
            cilindro.raio = 6;

            Console.WriteLine("O volume do cilindro é: " + cilindro.CalcularVolume());
            Console.ReadLine();
        }
        
    }
}
