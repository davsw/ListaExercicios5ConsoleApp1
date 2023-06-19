using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_3ConsoleApp1
{
    internal class Cilindro
    {
        public decimal pi = 3.14m;
        public int raio;
        public int altura;
        public decimal volume;

        public decimal CalcularVolume()
        {
            volume = pi * (raio * raio) * altura;
            return volume;
        }
    }
}
