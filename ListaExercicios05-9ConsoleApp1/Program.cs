using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_9ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.nota1 = 10;
            aluno.nota2 = 10;
            aluno.nota3 = 10;
            aluno.nota4 = 10;

            Console.WriteLine("A média harmônica do aluno é: {0}", aluno.CalcularMediaHarmonica());
            Console.ReadLine();
        }
    }
}
