using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_4ConsoleApp1
{
    internal class Percurso
    {
        public int kilometragemInicial;
        public int kilometragemFinal;
        public int consumo;

        public double CalcularGasto()
        {
            double distanciaPercorrida = kilometragemFinal - kilometragemInicial;

            double gastoTotal = distanciaPercorrida / consumo;

            return gastoTotal;
        }
    }
}
