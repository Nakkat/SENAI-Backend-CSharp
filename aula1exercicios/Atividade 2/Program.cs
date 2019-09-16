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

            Console.WriteLine (Fulano + ", Agora digite o valor que quer consultar: ");

            num1 = int.Parse (Console.ReadLine ());

            resultado = num1 * 30 / 100 + num1;

            Console.WriteLine ("Seu valor é: " + resultado);

        }
    }
}