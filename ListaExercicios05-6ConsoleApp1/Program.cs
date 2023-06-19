using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_6ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formula formula = new Formula();

            formula.celsius = 30;

            Console.WriteLine("O resultado da conversão é: {0} graus Fahrenheit.", formula.ObterFahrenheit());
            Console.ReadKey(); 
        }
    }
}
