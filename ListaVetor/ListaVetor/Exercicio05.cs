using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio05
    {
        static void Main32323(string[] args)
        {
            double[] peso = new double[5];

            Console.Write("Peso1: ");
            peso[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Peso2: ");
            peso[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Peso3: ");
            peso[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Peso4: ");
            peso[3] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Peso5: ");
            peso[4] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double media = (peso[0] + peso[1] + peso[2] + peso[3] + peso[4]) / 5;
            double soma = peso[0] + peso[1] + peso[2] + peso[3] + peso[4];

            Console.Write("Soma :" + soma);
            Console.WriteLine();
            Console.Write("Media :" + media);
            Console.WriteLine();



        }
    }
}
