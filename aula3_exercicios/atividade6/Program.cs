using System;

namespace atividade6 {
    class Program {
        static void Main (string[] args) {
            int atual = 0;
            int cont = 0;
            int anterior = 0;

            while (cont <= 18) {
                if (atual == 0) {
                    Console.WriteLine (atual);

                    atual = 1;
                    anterior = 0;
                } else {
                    atual = atual + anterior;
                    anterior = atual - anterior;
                }
                cont++;
                Console.WriteLine (atual);

            }

        }
    }
}