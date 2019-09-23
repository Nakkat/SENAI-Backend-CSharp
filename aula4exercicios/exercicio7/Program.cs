using System;

namespace exercicio7 {
    class Program {
        static void Main (string[] args) {
            double[] vetor1 = new double[10];
            int indice = 0;
            double maior = 0;

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite um número: ");
                vetor1[i] = double.Parse (Console.ReadLine ());

                if (vetor1[0] < 0) {
                    maior = vetor1[0];
                }
                if (maior < vetor1[i]) {
                    indice = i;
                    maior = vetor1[i];
                }

                Console.WriteLine (maior + "é o maior número, índice = " + indice);

            }
        }
    }
}