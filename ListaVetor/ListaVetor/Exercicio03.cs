using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio03
    {
        static void Main22222(string[] args)
        {
            string[] nome = new string[7];
            double[] preço = new double[7];

            Console.WriteLine("Nome 1: ");
            nome[0] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço 1: ");
            preço[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Nome 2: ");
            nome[1] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço 2: ");
            preço[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Nome 3: ");
            nome[2] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço 3: ");
            preço[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Nome 4: ");
            nome[3] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço 4: ");
            preço[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Nome 5: ");
            nome[4] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço 5: ");
            preço[4] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();



            Console.WriteLine("Nome 6: ");
            nome[5] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço 6: ");
            preço[5] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Nome 7: ");
            nome[6] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço 7: ");
            preço[6] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Preços: " + preço[0] + "/" + preço[1] + "/" + preço[2] + "/" + preço[3] + "/" + preço[4] + "/" + preço[5] + "/" + preço[6]);
            Console.WriteLine("Nomes: " + nome[0] + "," + nome[1] + "," + nome[2] + "," + nome[3] + "," + nome[4] + "," + nome[5] + "," + nome[6]);



        }
    }
}
