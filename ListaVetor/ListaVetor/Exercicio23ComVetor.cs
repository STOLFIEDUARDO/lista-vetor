using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio23ComVetor
    {
        static void Main(string[] args)
        {
            double[] notapt = new double[4];
            double[] notamt = new double[4];
            double[] notaing = new double[4];
            double[] notabio = new double[4];
            double[] notaqui = new double[4];
            double[] notafis = new double[4];
            double[] notasoc = new double[4];
            double[] notafil = new double[4];
            double[] notageo = new double[4];
            double[] notahis = new double[4];
            double[] notaedf = new double[4];

            Console.WriteLine();
            Console.WriteLine("1/11");
            Console.WriteLine();

            Console.WriteLine("Português");

            Console.Write("PT Nota1: ");
            notapt[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("PT Nota2: ");
            notapt[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("PT Nota3: ");
            notapt[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("PT Nota4: ");
            notapt[4] = Convert.ToDouble(Console.ReadLine());


            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("2/11");
            Console.WriteLine();

            Console.WriteLine("Matemática");

            Console.Write("MAT Nota1: ");
            notamt[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("MAT Nota2: ");
            notamt[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("MAT Nota3: ");
            notamt[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("MAT Nota4: ");
            notamt[3] = Convert.ToDouble(Console.ReadLine());


            Console.Clear();




            Console.WriteLine();
            Console.WriteLine("3/11");
            Console.WriteLine();

            Console.WriteLine("inglês");

            Console.Write("ING Nota1: ");
            notaing[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("ING Nota2: ");
            notaing[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("ING Nota3: ");
            notaing[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("ING Nota4: ");
            notaing[3] = Convert.ToDouble(Console.ReadLine());


            Console.Clear();


            Console.WriteLine();
            Console.WriteLine("4/11");
            Console.WriteLine();


            Console.WriteLine("Biologia");

            Console.Write("BIO Nota1: ");
            notabio[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("BIO Nota2: ");
            notabio[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("BIO Nota3: ");
            notabio[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("BIO Nota4: ");
            notabio[3] = Convert.ToDouble(Console.ReadLine());


            Console.Clear();


            Console.WriteLine();
            Console.WriteLine("5/11");
            Console.WriteLine();

            Console.WriteLine("Química ");

            Console.Write("QUI Nota1: ");
            notaqui[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("QUI Nota2: ");
            notaqui[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("QUI Nota3: ");
            notaqui[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("QUI Nota4: ");
            notaqui[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();


            Console.WriteLine();
            Console.WriteLine("6/11");
            Console.WriteLine();


            Console.WriteLine("Física");

            Console.Write("FIS Nota1: ");
            notafis[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("FIS Nota2: ");
            notafis[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("FIS Nota3: ");
            notafis[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("FIS Nota4: ");
            notafis[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();



            Console.WriteLine();
            Console.WriteLine("7/11");
            Console.WriteLine();

            Console.WriteLine("Sociologia");

            Console.Write("SOC Nota1: ");
            notasoc[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("SOC Nota2: ");
            notasoc[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("SOC Nota3: ");
            notasoc[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("SOC Nota4: ");
            notasoc[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();




            Console.WriteLine();
            Console.WriteLine("8/11");
            Console.WriteLine();


            Console.WriteLine("Filosofia");

            Console.Write("FIL Nota1: ");
            notafil[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("FIL Nota2: ");
            notafil[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("FIL Nota3: ");
            notafil[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("FIL Nota4: ");
            notafil[0] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();





            Console.WriteLine();
            Console.WriteLine("9/11");
            Console.WriteLine();


            Console.WriteLine("Geografia");

            Console.Write("GEO Nota1: ");
            notageo[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("GEO Nota2: ");
            notageo[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("GEO Nota3: ");
            notageo[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("GEO Nota4: ");
            notageo[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();




            Console.WriteLine();
            Console.WriteLine("10/11");
            Console.WriteLine();

            Console.WriteLine("História");

            Console.Write("HIS Nota1: ");
            notahis[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("HIS Nota2: ");
            notahis[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("HIS Nota3: ");
            notahis[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("HIS Nota4: ");
            notahis[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();



            Console.WriteLine();
            Console.WriteLine("11/11");
            Console.WriteLine();


            Console.WriteLine("Educação Física");

            Console.Write("EDF Nota1: ");
            notaedf[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("EDF Nota2: ");
            notaedf[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("EDF Nota3: ");
            notaedf[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("EDF Nota4: ");
            notaedf[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Média Português");

            double mediapt = (notapt[0] + notapt[1] + notapt[2] + notapt[3]) / 4;
            Console.WriteLine(

                "Média: " + mediapt
                );

            Console.WriteLine();




            Console.WriteLine("Matemática");

            double Mediamt = (notamt[0] + notamt[1] + notamt[2] + notamt[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediamt
                );

            Console.WriteLine();


            Console.WriteLine("Inglês");

            double Mediaing = (notaing[0] + notaing[1] + notaing[2] + notaing[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediaing
                );

            Console.WriteLine();


            Console.WriteLine("Biologia");

            double Mediabio = (notabio[0] + notabio[1] + notabio[2] + notabio[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediabio
                );

            Console.WriteLine();


            Console.WriteLine("Química");

            double Mediaqui = (notaqui[0] + notaqui[1] + notaqui[2] + notaqui[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediaqui
                );

            Console.WriteLine();


            Console.WriteLine("Física");

            double Mediafis = (notafis[0] + notafis[1] + notafis[2] + notafis[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediafis
                );

            Console.WriteLine();


            Console.WriteLine("Sociologia");

            double Mediasoc = (notasoc[0] + notasoc[1] + notasoc[2] + notasoc[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediasoc
                );

            Console.WriteLine();


            Console.WriteLine("Filosofia");

            double Mediafil = (notafil[0] + notafil[1] + notafil[2] + notafil[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediafil
                );

            Console.WriteLine();


            Console.WriteLine("Geografia");

            double Mediageo = (notageo[0] + notageo[1] + notageo[2] + notageo[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediageo
                );

            Console.WriteLine();


            Console.WriteLine("História");

            double Mediahis = (notahis[0] + notahis[1] + notahis[2] + notahis[3]) / 4;
            Console.WriteLine(

                "Média: " + Mediahis
                );

            Console.WriteLine();



            Console.WriteLine("Educação Física");

            double Mediaedf = (notaedf[0] + notaedf[1] + notaedf[2] + notaedf[]) / 4;
            Console.WriteLine(

                "Média: " + Mediaedf
                );

            Console.WriteLine();






           

        }
    }
}
