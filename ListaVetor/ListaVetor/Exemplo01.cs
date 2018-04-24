using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploVetor
{
    class Program
    {
        static void Main1111111111111(string[] args)
        {
            // 6 pôneis
            // cor
            // nome
            // fofinho
            //corcrista

            string[] cores = new string[6];
            string[] nomes = new string[6];
            bool[] fofinhos = new bool[6];
            string[] corescristas = new string[6];

            Console.WriteLine("Pônei 01 \nCor: ");
            cores[0] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Fofinho? : ");
            string fofinho = Console.ReadLine().ToLower();

            /*if (fofinho == "sim")
            {
                fofinhos[0] = true;
            }
            else
            {
                fofinhos[0] = false;
            }*/

            fofinhos[0] = fofinho == "sim";
            Console.Write("Cor da Crista: ");
            corescristas[0] = Console.ReadLine();
            Console.Clear();

            Console.Write("Pônei 02 \nCor: ");
            cores[1] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[1] = Console.ReadLine();
            Console.Write("Fofinho? : ");
            string fofinhoss = Console.ReadLine().ToLower();
            fofinhos[1] = fofinhoss == "sim";
            Console.Write("Cor da Crista: ");
            corescristas[1] = Console.ReadLine();

            Console.Clear();

            Console.Write("Pônei 03 \nCor: ");
            cores[2] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[2] = Console.ReadLine();
            Console.Write("Fofinho? : ");
            string fofinhosss = Console.ReadLine().ToLower();
            fofinhos[2] = fofinhosss == "sim";
            Console.Write("Cor da Crista: ");
            corescristas[2] = Console.ReadLine();

            Console.Clear();

            Console.Write("Pônei 04 \nCor: ");
            cores[3] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[3] = Console.ReadLine();
            Console.Write("Fofinho? : ");
            string fofinhossss = Console.ReadLine().ToLower();
            fofinhos[3] = fofinhossss == "sim";
            Console.Write("Cor da Crista: ");
            corescristas[3] = Console.ReadLine();

            Console.Clear();

            Console.Write("Pônei 05 \nCor: ");
            cores[4] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[4] = Console.ReadLine();
            Console.Write("Fofinho? : ");
            string fofinhosssss = Console.ReadLine().ToLower();
            fofinhos[4] = fofinhosssss == "sim";
            Console.Write("Cor da Crista: ");
            corescristas[4] = Console.ReadLine();

            Console.Clear();

            Console.Write("Pônei 06 \nCor: ");
            cores[5] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[5] = Console.ReadLine();
            Console.Write("Fofinho? : ");
            string fofinhossssss = Console.ReadLine().ToLower();
            fofinhos[5] = fofinhossssss == "sim";
            Console.Write("Cor da Crista: ");
            corescristas[5] = Console.ReadLine();




         }
    }
}
