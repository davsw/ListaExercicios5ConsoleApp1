using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios5ConsoleApp1.Exercicio2
{
    internal class Formula
    {
        
        public decimal fahrenheit;
        public decimal celsius;

        

        public decimal CalcularTemperatura()
        {
            celsius = (fahrenheit - 32m) / 1.8m;

            return celsius;
        }
    }
}
