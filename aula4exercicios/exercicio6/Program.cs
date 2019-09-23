using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores1 = new double[10];
            double[] valores2 = new double[10];
            double[] valores3 = new double[10];

            for (int i = 0; i <= 9; i++) {

                Console.WriteLine ($"Digite o valor do vetor 1 na posição {i}: ");
                valores1[i] = double.Parse (Console.ReadLine ());
            }

            for (int c = 0; c <= 9; c++) {
                Console.WriteLine ("Digite o valor do vetor 2 na posição " + c + ":");
                valores2[c] = double.Parse (Console.ReadLine ());

            }

            Console.WriteLine("Os valores somados são: ");

            for (int i = 0; i <= 9; i++) {
                valores3[i] = valores1[i];
                valores3[i] = valores1[i] + valores2[i];
                Console.WriteLine (valores3[i]);
            }
                
        }
    }
}
        
    

