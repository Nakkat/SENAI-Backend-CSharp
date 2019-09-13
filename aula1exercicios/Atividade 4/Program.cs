using System;

namespace Aula1 {
    class Program {
        static void Main (string[] args) {

            int num1;
            string Fulano;
            double resultado;

            Console.WriteLine ("Atividade1");
            Console.Write ("Digite seu nome: ");

            Fulano = Console.ReadLine ();

            // Concatenação
            Console.WriteLine (Fulano + ", Agora digite o  valor que você quer consultar: ");

            // Converto o texto capturado para o tipo inteiro
            num1 = int.Parse (Console.ReadLine ());

            resultado = num1 / 4.07;

            Console.WriteLine ("Seu resultado é: " + resultado);

        }
    }
}