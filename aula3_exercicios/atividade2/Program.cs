using System;

namespace atividade2 {
    class Program {
        static void Main (string[] args) {
            int num;

            Console.WriteLine ("escreva um numero de 1 a 10: ");
            num = int.Parse (Console.ReadLine ());
            for (int cont = 1; cont <= 10; cont++) {
                
                Console.WriteLine ($"{num} x  {cont} = {num * cont}");
            }

        }
    }
}