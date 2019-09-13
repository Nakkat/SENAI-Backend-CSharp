using System;

namespace Aula1 {
    class Program {
        static void Main (string[] args) {

        
            float resultado;
            int qtd;
            

            Console.WriteLine ("Atividade7");
            Console.WriteLine ("Digite quantas pessoas entraram no ônibus");
            qtd = int.Parse (Console.ReadLine());


            resultado = 4.30f * qtd;

            Console.WriteLine ("O valor que você irá receber é: " + resultado);

        }
    }
}