using System;

namespace aula10_funcao {
    class Program {
        //Criar uma função do tipo double que
        //recebe como argumentos valor e
        //porcentagem, onde o intuito é atribuir um desconto sobre a porcentagem e retornar
        //o valor aplicado o desconto
        static void Main (string[] args) {
            double valor = 0;
            double porcentagem = 0;

            Console.WriteLine ("Digite o valor: ");
            valor = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite uma porcentagem: ");
            porcentagem = double.Parse (Console.ReadLine ());

            Console.WriteLine("Seu valor final é: " + aplicaDesconto(porcentagem, valor));

        }

        static double aplicaDesconto (double porcentagem, double valor) {
            double desconto = 0;
            porcentagem = porcentagem / 100;
            desconto = valor * porcentagem;
            valor = valor - desconto;   
            return valor;
        }

    }
}