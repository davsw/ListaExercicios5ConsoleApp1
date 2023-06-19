using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_10ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.nota1 = 10;
            aluno.nota2 = 10;

            Console.WriteLine("A média ponderada do aluno é: {0}", aluno.CalcularMediaPonderada());
            Console.ReadLine();
        }
    }
}
