using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_5ConsoleApp1
{
    public class Esfera
    {
        public int raio;

        public double CalcularVolume()
        {
            double volume =((4 * Math.PI * Math.Pow(raio, 3) / 3));

            return volume;
        }
    }
}
