using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05_7ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor funcionario = new Vendedor();

            funcionario.salarioFixo = 2000;
            funcionario.totalVendas = 20000;
            funcionario.percentualGanho = 30;

            Console.WriteLine("O salário total do vendedor é: {0}", funcionario.CalcularSalario());
            Console.ReadKey();

        }
    }
}
