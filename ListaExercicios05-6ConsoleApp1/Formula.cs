using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_6ConsoleApp1
{
    public class Formula
    {
        public int celsius;

        public double ObterFahrenheit()
        {
            double fahrenheit = (((9 * celsius) + 160) / 5);

            return fahrenheit;
        }
    }
}
