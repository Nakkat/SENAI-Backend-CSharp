using System;

namespace atividade4 {
    class Program {
        static void Main (string[] args) {
            double media = 0;
            string resultado = "";
            double num;
            int qtd = 0;
            double acum = 0;

            for (int cont = 1; cont <= 5; cont++) {
                Console.WriteLine ("Digite um número: ");
                num = double.Parse (Console.ReadLine ());
                if (num >= 0) {

                    resultado += " -> " + num;
                } else {
                    acum += num;
                    qtd++;
                    media = acum / qtd;

                }

            }
            
            Console.WriteLine (resultado);
            Console.WriteLine (media);

        }
    }
}