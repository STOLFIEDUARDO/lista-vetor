using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio01
    {
        static void Main4(string[] args)
        {
            int[] numerosinteiros = new int[16];

            Console.WriteLine("Apresentar numeros inteiros");

            Console.WriteLine("Numero 1: ");
            numerosinteiros[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 2: ");
            numerosinteiros[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 3: ");
            numerosinteiros[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 4: ");
            numerosinteiros[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Clear();
            Console.WriteLine("Numero 5: ");
            numerosinteiros[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 6: ");
            numerosinteiros[5] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 7: ");
            numerosinteiros[6] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 8: ");
            numerosinteiros[7] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Clear();
            Console.WriteLine("Numero 9: ");
            numerosinteiros[8] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 10: ");
            numerosinteiros[9] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 11: ");
            numerosinteiros[10] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 12: ");
            numerosinteiros[11] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Clear();
            Console.WriteLine("Numero 13: ");
            numerosinteiros[12] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 14: ");
            numerosinteiros[13] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 15: ");
            numerosinteiros[14] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Numero 16: ");
            numerosinteiros[15] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Clear();

            int somar = numerosinteiros[0] + numerosinteiros[1] + numerosinteiros[2] + numerosinteiros[3] + numerosinteiros[4] + numerosinteiros[5] + numerosinteiros[6] + numerosinteiros[7] + numerosinteiros[8] + numerosinteiros[9] + numerosinteiros[10] + numerosinteiros[11] + numerosinteiros[12] + numerosinteiros[13] + numerosinteiros[14] + numerosinteiros[15];

            Console.WriteLine("Somas: " + somar);
            
        }
    }
}
