using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_9ConsoleApp1
{
    public class Aluno
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;

        public double CalcularMediaHarmonica()
        {
            double mediaHarmonica =
                (4 / 
                (1 / nota1) +
                (1 / nota2) +
                (1 / nota3) +
                (1 / nota4));

            return mediaHarmonica;
        }
    }
}
