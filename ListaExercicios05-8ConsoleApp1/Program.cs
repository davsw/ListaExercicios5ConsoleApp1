using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_8ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            LataOleo lata = new LataOleo();

            lata.raio = 3;
            lata.altura = 5;

            Console.WriteLine("O volume da lata de óleo é: {0}", lata.ObterVolume());
            Console.ReadLine();
        }
    }
}
