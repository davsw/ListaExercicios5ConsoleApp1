using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_8ConsoleApp1
{
    public class LataOleo
    {
        public int raio;
        public int altura;

        public double ObterVolume()
        {
            double volume = ((Math.PI * raio) - (2 * altura));

            return volume;
        }
    }
}
