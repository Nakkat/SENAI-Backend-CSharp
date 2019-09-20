using System;

namespace atividade3 {
    class Program {
        static void Main (string[] args) {
            int n;
            int cont = 0;
            string resultado = "";

            Console.WriteLine ("Digite um número: ");
            n = int.Parse (Console.ReadLine ());

            while (cont < n) {
               
                if (cont % 5 == 0) {
                    resultado += " -> "+ cont;
                }
                cont++;
            }

            Console.WriteLine ("Os números que são múltiplos de 5 do 1 ao número que você escolheu são: " + resultado);
        }
    }
}