using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios5ConsoleApp1.Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Formula formula = new Formula();

            formula.fahrenheit = 40;

            Console.WriteLine("A conversão de fahrenheit em celsius é: " + formula.CalcularTemperatura());
            Console.ReadLine();


        }
    }
}
