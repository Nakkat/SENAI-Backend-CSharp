﻿using System;

namespace Aula1 {
    class Program {
        static void Main (string[] args) {

            int num1, num2, num3;
            string Fulano;
            float resultado;

            Console.WriteLine ("Atividade1");
            Console.Write ("Digite seu nome: ");

            Fulano = Console.ReadLine ();

            Console.WriteLine (Fulano + ", Agora digite o valor do seu salário fixo: ");
            num1 = int.Parse (Console.ReadLine ());

            Console.WriteLine (Fulano + ", Agora digite o valor das suas vendas: ");
            num2 = int.Parse (Console.ReadLine ());

            Console.WriteLine (Fulano + ", Agora digite o valor da quantidade de vendas esse mês: ");
            num3 = int.Parse (Console.ReadLine ());

            resultado = num1 + (num2 * num3) * 5 / 100;

            Console.WriteLine ("Seu salário atual é: " + resultado);

        }
    }
}