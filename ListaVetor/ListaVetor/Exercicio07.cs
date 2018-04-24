using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio07
    {
        static void Main2222(string[] args)
        {
            double[] altura = new double[4];
            double menoraltura = 9999999999999;

            Console.Write("Altura 1: ");
            altura[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Altura 2: ");
            altura[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Altura 3: ");
            altura[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Altura 4: ");
            altura[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (altura[0] < menoraltura)
            {
                menoraltura = altura[0];
            }
            if (altura[1] < menoraltura)
            {
                menoraltura = altura[1];
            }
            if (altura[2] < menoraltura)
            {
                menoraltura = altura[2];
            }
            if (altura[3] < menoraltura)
            {
                menoraltura = altura[3];
            }


            Console.Write("Menor Altura: " + menoraltura);
            Console.WriteLine();
        }
    }
}
