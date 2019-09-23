using System;

namespace exercicio2 {
    class Program {
        static void Main (string[] args) {
            double[] valores1 = new double[10];
            double[] valores2 = new double[10];
            double[] valores3 = new double[20];

            for (int i = 0; i <= 9; i++) {

                Console.WriteLine ("Digite o valor do primeiro vetor: ");
                valores1[i] = double.Parse (Console.ReadLine ());
            }

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite o valor do segundo vetor: ");
                valores2[i] = double.Parse (Console.ReadLine ());

            }

            for (int i = 0; i <= 9; i++) {
                valores3[i] = valores1[i];

            }
                for (int i = 0; i <= 9; i++) {
                    valores3[i+10] = valores2[i];
                }
                 for (int i = 0; i <= 19; i++) {
                Console.WriteLine (valores3[i]);
                 }
        }
    }
}