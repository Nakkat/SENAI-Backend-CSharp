using System;

namespace Aula1 {
    class Program {
        static void Main (string[] args) {

            float num1, num2;
            string Fulano;
            float resultado;

            Console.WriteLine ("Atividade1");
            Console.Write ("Digite seu nome: ");
            Fulano = Console.ReadLine ();

            Console.Write ("Digite seu salário: ");
            num1 = int.Parse (Console.ReadLine ());

            Console.Write ("Digite o valor da sua conta: ");
            num2 = int.Parse (Console.ReadLine ());

            resultado = num1 - num2;

            Console.WriteLine ("O valor restante é: " + resultado);

        }
    }
}