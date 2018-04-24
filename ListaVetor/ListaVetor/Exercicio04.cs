using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio04
    {
        static void Main22222(string[] args)
        {

            
            double[] nota = new double[4];

            Console.Write("Disciplina: ");
            string materia = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Nota1: ");
            nota[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nota2: ");
            nota[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nota3: ");
            nota[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nota4: ");
            nota[3] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Clear();

            double media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;
            Console.Write("Media :" + media);
            Console.WriteLine();
            

        }
    }
}
