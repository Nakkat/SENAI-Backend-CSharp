using System;

namespace exercicio4 {
    class Program {
        static void Main (string[] args) {


            double[] v1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            System.Console.WriteLine("O maior valor é: " + VetorMaior(v1));

        }

        static double VetorMaior (double[] v1) {
            double resultado = 0;
            for (int i = 0; i < v1.Length; i++) {
                if (v1[i] > resultado) {
                    resultado = v1[i];
                }
            }
            return resultado;
        }
    }
}