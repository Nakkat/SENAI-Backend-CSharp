using System;

namespace Aula1 {
    class Program {
        static void Main (string[] args) {

            float num1;
            string Fulano;
            float resultado;

            Console.WriteLine ("Atividade1");
            Console.Write ("Digite seu nome: ");

            Fulano = Console.ReadLine ();

            // Concatenação
            Console.WriteLine (Fulano + ", Agora digite seu número: ");

            // Converto o texto capturado para o tipo inteiro
            num1 = float.Parse (Console.ReadLine ());

            resultado = num1 * 3;

            Console.WriteLine ("Seu resultado é: " + resultado);

        }
    }
}